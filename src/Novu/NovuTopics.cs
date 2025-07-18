//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Novu
{
    using Newtonsoft.Json;
    using Novu.Hooks;
    using Novu.Models.Components;
    using Novu.Models.Errors;
    using Novu.Models.Requests;
    using Novu.Utils;
    using Novu.Utils.Retries;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    public interface INovuTopics
    {

        /// <summary>
        /// Retrieve subscriber subscriptions
        /// 
        /// <remarks>
        /// Retrieve subscriber&apos;s topic subscriptions by its unique key identifier **subscriberId**. <br/>
        ///     Checkout all available filters in the query section.
        /// </remarks>
        /// </summary>
        Task<SubscribersControllerListSubscriberTopicsResponse> ListAsync(SubscribersControllerListSubscriberTopicsRequest request, RetryConfig? retryConfig = null);
    }

    public class NovuTopics: INovuTopics
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "2.3.0-alpha.1";
        private const string _sdkGenVersion = "2.636.0";
        private const string _openapiDocVersion = "2.3.0";

        public NovuTopics(SDKConfig config)
        {
            SDKConfiguration = config;
        }

        public async Task<SubscribersControllerListSubscriberTopicsResponse> ListAsync(SubscribersControllerListSubscriberTopicsRequest request, RetryConfig? retryConfig = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v2/subscribers/{subscriberId}/subscriptions", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", SDKConfiguration.UserAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (SDKConfiguration.SecuritySource != null)
            {
                httpRequest = new SecurityMetadata(SDKConfiguration.SecuritySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(SDKConfiguration, baseUrl, "SubscribersController_listSubscriberTopics", new List<string> {  }, SDKConfiguration.SecuritySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);
            if (retryConfig == null)
            {
                if (this.SDKConfiguration.RetryConfig != null)
                {
                    retryConfig = this.SDKConfiguration.RetryConfig;
                }
                else
                {
                    var backoff = new BackoffStrategy(
                        initialIntervalMs: 1000L,
                        maxIntervalMs: 30000L,
                        maxElapsedTimeMs: 3600000L,
                        exponent: 1.5
                    );
                    retryConfig = new RetryConfig(
                        strategy: RetryConfig.RetryStrategy.BACKOFF,
                        backoff: backoff,
                        retryConnectionErrors: true
                    );
                }
            }

            List<string> statusCodes = new List<string>
            {
                "408",
                "409",
                "429",
                "5XX",
            };

            Func<Task<HttpResponseMessage>> retrySend = async () =>
            {
                var _httpRequest = await SDKConfiguration.Client.CloneAsync(httpRequest);
                return await SDKConfiguration.Client.SendAsync(_httpRequest);
            };
            var retries = new Novu.Utils.Retries.Retries(retrySend, retryConfig, statusCodes);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await retries.Run();
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode == 403 || _statusCode == 404 || _statusCode == 405 || _statusCode == 409 || _statusCode == 413 || _statusCode == 414 || _statusCode == 415 || _statusCode == 422 || _statusCode == 429 || _statusCode >= 400 && _statusCode < 500 || _statusCode == 500 || _statusCode == 503 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ListTopicSubscriptionsResponseDto>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new SubscribersControllerListSubscriberTopicsResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.ListTopicSubscriptionsResponseDto = obj;
                    return response;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode == 414)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ErrorDto>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    throw obj!;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
            else if(new List<int>{400, 401, 403, 404, 405, 409, 413, 415}.Contains(responseStatusCode))
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ErrorDto>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    throw obj!;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode == 422)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ValidationErrorDto>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    throw obj!;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode == 429)
            {
                throw new Models.Errors.APIException("API error occurred", httpRequest, httpResponse);
            }
            else if(responseStatusCode == 500)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ErrorDto>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    throw obj!;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode == 503)
            {
                throw new Models.Errors.APIException("API error occurred", httpRequest, httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500)
            {
                throw new Models.Errors.APIException("API error occurred", httpRequest, httpResponse);
            }
            else if(responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.APIException("API error occurred", httpRequest, httpResponse);
            }

            throw new Models.Errors.APIException("Unknown status code received", httpRequest, httpResponse);
        }
    }
}