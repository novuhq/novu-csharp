namespace Novu.Hooks
{
    using Novu.Utils;
    using Novu.Models.Components;

    public class NovuCustomHook : ISDKInitHook, IBeforeRequestHook, IAfterSuccessHook, IAfterErrorHook
    {
        public async Task<HttpRequestMessage> BeforeRequestAsync(BeforeRequestContext hookCtx, HttpRequestMessage request)
        {
            // retreive authorization header 
            var authHeader = request.Headers.Authorization;
            if (authHeader != null)
            {
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("ApiKey", authHeader.Parameter);
            }

            // Add an idempotency key to the in header if it is not already present
            if (!request.Headers.Contains("idempotency-key"))
            {
                request.Headers.Add("idempotency-key", Guid.NewGuid().ToString());
            }
            return request;
        }

        // public async Task<HttpResponseMessage> AfterSuccessAsync(AfterSuccessContext hookCtx, HttpResponseMessage response)
        // {
        //     // modify the response object before deserialization or throw an exception to stop the response from being returned
        //     return response;
        // }

    }
}