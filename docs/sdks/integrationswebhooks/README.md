# IntegrationsWebhooks
(*IntegrationsWebhooks*)

## Overview

### Available Operations

* [GetStatus](#getstatus) - Get webhook support status for provider

## GetStatus

Return the status of the webhook for this provider, if it is supported or if it is not based on a boolean value

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.IntegrationsWebhooks.GetStatusAsync(
    providerOrIntegrationId: "<id>",
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `ProviderOrIntegrationId`         | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[IntegrationsControllerGetWebhookSupportStatusResponse](../../Models/Requests/IntegrationsControllerGetWebhookSupportStatusResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |