namespace Novu.Hooks
{
    using Novu.Utils;
    using Novu.Models.Components;
    using System.Net.Http.Headers;

    public class NovuCustomHook : IBeforeRequestHook
    {
        public Task<HttpRequestMessage> BeforeRequestAsync(BeforeRequestContext hookCtx, HttpRequestMessage request)
        {
            // Retrieve authorization header
            var authHeader = request.Headers.Authorization;
            if (authHeader != null && !string.IsNullOrEmpty(authHeader.Parameter))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("ApiKey", authHeader.Parameter);
            }

            // Add an idempotency key to the header if it is not already present
            if (!request.Headers.Contains("idempotency-key"))
            {
                request.Headers.Add("idempotency-key", Guid.NewGuid().ToString());
            }

            return Task.FromResult(request);
        }

        // TODO: Implement AfterSuccessAsync if needed
        // public Task<HttpResponseMessage> AfterSuccessAsync(AfterSuccessContext hookCtx, HttpResponseMessage response)
        // {
        //     // Modify the response object before deserialization or throw an exception to stop the response from being returned
        //     return Task.FromResult(response);
        // }
    }
}