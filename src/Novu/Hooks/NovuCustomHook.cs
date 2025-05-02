using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Novu.Utils;
using Novu.Models.Components;

namespace Novu.Hooks
{
    public class NovuCustomHook : IBeforeRequestHook, IAfterSuccessHook
    {
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
        public async Task<HttpResponseMessage> AfterSuccessAsync(AfterSuccessContext hookCtx, HttpResponseMessage response)
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
                    jsonResponse.EnumerateObject().Count() == 1 &&
                    jsonResponse.TryGetProperty("data", out var dataProperty))
                {
                    var newContent = new StringContent(dataProperty.GetRawText(), response.Content.Headers.ContentType?.Encoding, response.Content.Headers.ContentType?.MediaType);
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
                Console.Error.WriteLine($"JSON parsing error: {ex.Message}");
            }
            return response;
        }
    }
}