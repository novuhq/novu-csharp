namespace Novu.Hooks
{
    using Novu.Utils;
    using Novu.Models.Components;

    public class ExampleHook : ISDKInitHook, IBeforeRequestHook, IAfterSuccessHook, IAfterErrorHook
    {
        public (string, ISpeakeasyHttpClient) SDKInit(string baseURL, ISpeakeasyHttpClient client)
        {
            // modify the baseURL or wrap the client used by the SDK here and return the updated values
            return (baseURL, client);
        }

        public async Task<HttpRequestMessage> BeforeRequestAsync(BeforeRequestContext hookCtx, HttpRequestMessage request)
        {
            // check if idempotency-key exists in the request headers and add it if not 
        
            return request;
        }

        public async Task<HttpResponseMessage> AfterSuccessAsync(AfterSuccessContext hookCtx, HttpResponseMessage response)
        {
            // modify the response object before deserialization or throw an exception to stop the response from being returned
            return response;
        }

        public async Task<(HttpResponseMessage?, Exception?)> AfterErrorAsync(AfterErrorContext hookCtx, HttpResponseMessage? response, Exception error)
        {
            // modify the response before it is deserialized as a custom error
            // return (response, null);

            // OR modify the exception object before it is thrown
            // return (null, error);

            // OR abort the processing of subsequent AfterError hooks
            // throw new FailEarlyException("return early", error);

            // response and error cannot both be null
            return (response, error);
        }
    }
}