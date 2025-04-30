# SubscribersAuthentication
(*SubscribersAuthentication*)

## Overview

### Available Operations

* [OauthCallback](#oauthcallback) - Handle providers oauth redirect

## OauthCallback

Handle providers oauth redirect

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

SubscribersV1ControllerChatOauthCallbackRequest req = new SubscribersV1ControllerChatOauthCallbackRequest() {
    SubscriberId = "<id>",
    ProviderId = "<value>",
    HmacHash = "<value>",
    EnvironmentId = "<id>",
    Code = "<value>",
};

var res = await sdk.SubscribersAuthentication.OauthCallbackAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                   | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                   | [SubscribersV1ControllerChatOauthCallbackRequest](../../Models/Requests/SubscribersV1ControllerChatOauthCallbackRequest.md) | :heavy_check_mark:                                                                                                          | The request object to use for the request.                                                                                  |

### Response

**[SubscribersV1ControllerChatOauthCallbackResponse](../../Models/Requests/SubscribersV1ControllerChatOauthCallbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |