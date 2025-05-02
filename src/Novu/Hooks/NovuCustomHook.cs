using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Novu.Utils;
using Novu.Models.Components;

namespace Novu.Hooks
{
    public class NovuCustomHook : IBeforeRequestHook
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
    }
}