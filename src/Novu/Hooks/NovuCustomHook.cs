using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using Novu.Utils;

namespace Novu.Hooks
{
    public class NovuCustomHook : IBeforeRequestHook, IAfterSuccessHook, ISDKInitHook
    {
        public (string, ISpeakeasyHttpClient) SDKInit(string baseUrl, ISpeakeasyHttpClient client)
        {
            // Wrap the client if it doesn't support DefaultHeaders
            var extendedClient = client as ExtendedSpeakeasyHttpClient ?? new ExtendedSpeakeasyHttpClient(client);

            if (!extendedClient.DefaultHeaders.TryGetValue("Authorization", out var authHeader))
                return (baseUrl, extendedClient);
            if (!string.IsNullOrEmpty(authHeader) &&
                !authHeader.StartsWith("apikey ", StringComparison.OrdinalIgnoreCase))
            {
                extendedClient.DefaultHeaders["Authorization"] = $"apikey {authHeader}";
            }

            return (baseUrl, extendedClient);
        }

        public Task<HttpRequestMessage> BeforeRequestAsync(BeforeRequestContext hookCtx, HttpRequestMessage request)
        {
            var authHeader = request.Headers.Authorization;
            if (authHeader != null && !string.IsNullOrEmpty(authHeader.Parameter))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("ApiKey", authHeader.Parameter);
            }

            if (!request.Headers.Contains("idempotency-key"))
            {
                request.Headers.Add("idempotency-key", Guid.NewGuid().ToString());
            }

            return Task.FromResult(request);
        }

        public async Task<HttpResponseMessage> AfterSuccessAsync(AfterSuccessContext hookCtx,
            HttpResponseMessage response)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            var contentType = response.Content.Headers.ContentType?.MediaType ?? string.Empty;

            if (string.IsNullOrEmpty(responseContent) || contentType.Contains("text/html"))
            {
                return response;
            }

            try
            {
                var jsonResponse = JsonSerializer.Deserialize<JsonElement>(responseContent);

                if (jsonResponse.ValueKind == JsonValueKind.Object &&
                    jsonResponse.EnumerateObject().MoveNext() &&
                    jsonResponse.TryGetProperty("data", out JsonElement dataProperty))
                {
                    var newContent = new StringContent(
                        dataProperty.GetRawText(),
                        Encoding.UTF8,
                        response.Content.Headers.ContentType?.MediaType ?? "application/json"
                    );
                    var newResponse = new HttpResponseMessage(response.StatusCode)
                    {
                        Content = newContent,
                        ReasonPhrase = response.ReasonPhrase
                    };

                    foreach (var header in response.Headers)
                    {
                        newResponse.Headers.TryAddWithoutValidation(header.Key, header.Value);
                    }

                    return newResponse;
                }
            }
            catch (JsonException ex)
            {
                await Console.Error.WriteLineAsync($"JSON parsing error: {ex.Message}");
            }

            return response;
        }
    }
}

internal class ExtendedSpeakeasyHttpClient(ISpeakeasyHttpClient client) : ISpeakeasyHttpClient
{
    public Dictionary<string, string> DefaultHeaders { get; set; } = new Dictionary<string, string>();

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
    {
        // Apply DefaultHeaders to the request if needed
        foreach (var header in DefaultHeaders)
        {
            request.Headers.TryAddWithoutValidation(header.Key, header.Value);
        }
        return await client.SendAsync(request);
    }

    public Task<HttpRequestMessage> CloneAsync(HttpRequestMessage request)
    {
        return client.CloneAsync(request);
    }
}