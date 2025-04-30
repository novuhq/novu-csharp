using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Linq;
using System.Threading.Tasks;

namespace Hooks
{
    public class NovuCustomHook : 
        IBeforeRequestHook, 
        IAfterSuccessHook, 
        IBeforeCreateRequestHook
    {
        public (RequestInput requestInput, Exception error) BeforeCreateRequest(HookContext hookCtx, RequestInput input)
        {
            const string idempotencyKey = "idempotency-key";
            var headers = input.Options?.Headers;
            
            if (headers == null)
            {
                return (input, null);
            }

            var updatedHeaders = UpdateHeaderValue(
                headers, 
                idempotencyKey, 
                GenerateIdempotencyKey
            );

            var updatedInput = new RequestInput
            {
                Request = input.Request,
                Options = new RequestOptions
                {
                    Headers = updatedHeaders
                }
            };

            return (updatedInput, null);
        }

        public (HttpRequestMessage request, Exception error) BeforeRequest(BeforeRequestContext hookCtx, HttpRequestMessage request)
        {
            const string authKey = "authorization";
            const string apiKeyPrefix = "ApiKey";

            if (request.Headers.TryGetValues(authKey, out var existingValues))
            {
                var key = existingValues.FirstOrDefault();
                
                if (!string.IsNullOrEmpty(key) && !key.Contains(apiKeyPrefix))
                {
                    request.Headers.Remove(authKey);
                    request.Headers.TryAddWithoutValidation(authKey, $"{apiKeyPrefix} {key}");
                }
            }

            return (request, null);
        }

        public async Task<(HttpResponseMessage response, Exception error)> AfterSuccess(AfterSuccessContext hookCtx, HttpResponseMessage response)
        {
            var contentType = response.Content.Headers.ContentType?.ToString() ?? string.Empty;
            
            // Clone the response content
            var responseContent = await response.Content.ReadAsStringAsync();
            
            if (string.IsNullOrEmpty(responseContent) || contentType.Contains("text/html"))
            {
                return (response, null);
            }

            try
            {
                using var jsonDocument = JsonDocument.Parse(responseContent);
                var root = jsonDocument.RootElement;

                // Check if the response is a single 'data' property
                if (root.ValueKind == JsonValueKind.Object && 
                    root.EnumerateObject().Count() == 1 && 
                    root.TryGetProperty("data", out var dataProperty))
                {
                    // Create a new response with just the data
                    var newContent = new StringContent(dataProperty.GetRawText());
                    var newResponse = new HttpResponseMessage(response.StatusCode)
                    {
                        Content = newContent
                    };
                    
                    // Copy headers
                    foreach (var header in response.Headers)
                    {
                        newResponse.Headers.TryAddWithoutValidation(header.Key, header.Value);
                    }

                    return (newResponse, null);
                }
            }
            catch (JsonException)
            {
                // If JSON parsing fails, return original response
                return (response, null);
            }

            return (response, null);
        }

        private string GenerateIdempotencyKey()
        {
            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            var randomString = Guid.NewGuid().ToString("N")[..9]; // Get first 9 characters
            return $"{timestamp}{randomString}".Trim();
        }

        private Dictionary<string, string> UpdateHeaderValue(
            Dictionary<string, string> headers, 
            string key, 
            Func<string> defaultValueFunction)
        {
            var headersRecord = new Dictionary<string, string>(headers);

            if (!headersRecord.ContainsKey(key) || string.IsNullOrEmpty(headersRecord[key]))
            {
                headersRecord[key] = defaultValueFunction();
            }

            return headersRecord;
        }
    }

    // Supporting interfaces and classes
    public interface IBeforeCreateRequestHook
    {
        (RequestInput requestInput, Exception error) BeforeCreateRequest(HookContext hookCtx, RequestInput input);
    }

    public class RequestInput
    {
        public HttpRequestMessage Request { get; set; }
        public RequestOptions Options { get; set; }
    }

    public class RequestOptions
    {
        public Dictionary<string, string> Headers { get; set; }
    }

    // Placeholder context classes
    public class HookContext { }
    public class BeforeRequestContext { }
    public class AfterSuccessContext { }
}