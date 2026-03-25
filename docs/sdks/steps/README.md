# Workflows.Steps

## Overview

### Available Operations

* [GeneratePreview](#generatepreview) - Generate step preview
* [Retrieve](#retrieve) - Retrieve workflow step

## GeneratePreview

Generates a preview for a specific workflow step by its unique identifier **stepId**

### Example Usage

<!-- UsageSnippet language="csharp" operationID="WorkflowController_generatePreview" method="post" path="/v2/workflows/{workflowId}/step/{stepId}/preview" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Workflows.Steps.GeneratePreviewAsync(
    workflowId: "<id>",
    stepId: "<id>",
    generatePreviewRequestDto: new GeneratePreviewRequestDto() {
        PreviewPayload = new PreviewPayloadDto() {
            Subscriber = new SubscriberResponseDtoOptional() {
                FirstName = "Kennith",
                LastName = "Schneider",
                Channels = new List<ChannelSettingsDto>() {
                    new ChannelSettingsDto() {
                        ProviderId = ChatOrPushProviderEnum.Slack,
                        IntegrationIdentifier = "<value>",
                        Credentials = new ChannelCredentials() {
                            WebhookUrl = "https://example.com/webhook",
                            Channel = "general",
                            DeviceTokens = new List<string>() {
                                "token1",
                                "token2",
                                "token3",
                            },
                            AlertUid = "12345-abcde",
                            Title = "Critical Alert",
                            ImageUrl = "https://example.com/image.png",
                            State = "resolved",
                            ExternalUrl = "https://example.com/details",
                        },
                        IntegrationId = "<id>",
                    },
                },
                IsOnline = false,
                LastOnlineAt = "<value>",
            },
            Context = new Dictionary<string, PreviewPayloadDtoContext>() {
                { "key", PreviewPayloadDtoContext.CreateStr(
                    "org-acme"
                ) },
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `WorkflowId`                                                                      | *string*                                                                          | :heavy_check_mark:                                                                | N/A                                                                               |
| `StepId`                                                                          | *string*                                                                          | :heavy_check_mark:                                                                | N/A                                                                               |
| `GeneratePreviewRequestDto`                                                       | [GeneratePreviewRequestDto](../../Models/Components/GeneratePreviewRequestDto.md) | :heavy_check_mark:                                                                | Preview generation details                                                        |
| `IdempotencyKey`                                                                  | *string*                                                                          | :heavy_minus_sign:                                                                | A header for idempotency purposes                                                 |

### Response

**[WorkflowControllerGeneratePreviewResponse](../../Models/Requests/WorkflowControllerGeneratePreviewResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Retrieve

Retrieves data for a specific step in a workflow

### Example Usage

<!-- UsageSnippet language="csharp" operationID="WorkflowController_getWorkflowStepData" method="get" path="/v2/workflows/{workflowId}/steps/{stepId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Workflows.Steps.RetrieveAsync(
    workflowId: "<id>",
    stepId: "<id>"
);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `WorkflowId`                      | *string*                          | :heavy_check_mark:                | N/A                               |
| `StepId`                          | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[WorkflowControllerGetWorkflowStepDataResponse](../../Models/Requests/WorkflowControllerGetWorkflowStepDataResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |