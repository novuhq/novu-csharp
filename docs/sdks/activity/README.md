# Activity

## Overview

### Available Operations

* [Track](#track) - Track activity and engagement events

## Track

Track activity and engagement events for a specific delivery provider

### Example Usage

<!-- UsageSnippet language="csharp" operationID="InboundWebhooksController_handleWebhook" method="post" path="/v2/inbound-webhooks/delivery-providers/{environmentId}/{integrationId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Activity.TrackAsync(
    environmentId: "<id>",
    integrationId: "<id>",
    requestBody: "<value>"
);

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `EnvironmentId`                                      | *string*                                             | :heavy_check_mark:                                   | The environment identifier                           |
| `IntegrationId`                                      | *string*                                             | :heavy_check_mark:                                   | The integration identifier for the delivery provider |
| `RequestBody`                                        | *object*                                             | :heavy_check_mark:                                   | Webhook event payload from the delivery provider     |
| `IdempotencyKey`                                     | *string*                                             | :heavy_minus_sign:                                   | A header for idempotency purposes                    |

### Response

**[InboundWebhooksControllerHandleWebhookResponse](../../Models/Requests/InboundWebhooksControllerHandleWebhookResponse.md)**

### Errors

| Error Type                      | Status Code                     | Content Type                    |
| ------------------------------- | ------------------------------- | ------------------------------- |
| Novu.Models.Errors.APIException | 4XX, 5XX                        | \*/\*                           |