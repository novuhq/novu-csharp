# Layouts
(*Layouts*)

## Overview

Layouts are reusable wrappers for your email notifications.
<https://docs.novu.co/platform/workflow/layouts>

### Available Operations

* [Create](#create) - Create a layout
* [List](#list) - List all layouts
* [Update](#update) - Update a layout
* [Retrieve](#retrieve) - Retrieve a layout
* [Delete](#delete) - Delete a layout
* [Duplicate](#duplicate) - Duplicate a layout
* [GeneratePreview](#generatepreview) - Generate layout preview
* [Usage](#usage) - Get layout usage

## Create

Creates a new layout in the Novu Cloud environment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="LayoutsController_create" method="post" path="/v2/layouts" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Layouts.CreateAsync(createLayoutDto: new CreateLayoutDto() {
    LayoutId = "<id>",
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `CreateLayoutDto`                                             | [CreateLayoutDto](../../Models/Components/CreateLayoutDto.md) | :heavy_check_mark:                                            | Layout creation details                                       |
| `IdempotencyKey`                                              | *string*                                                      | :heavy_minus_sign:                                            | A header for idempotency purposes                             |

### Response

**[LayoutsControllerCreateResponse](../../Models/Requests/LayoutsControllerCreateResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## List

Retrieves a list of layouts with optional filtering and pagination

### Example Usage

<!-- UsageSnippet language="csharp" operationID="LayoutsController_list" method="get" path="/v2/layouts" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

LayoutsControllerListRequest? req = null;

var res = await sdk.Layouts.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [LayoutsControllerListRequest](../../Models/Requests/LayoutsControllerListRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[LayoutsControllerListResponse](../../Models/Requests/LayoutsControllerListResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Update

Updates the details of an existing layout, here **layoutId** is the identifier of the layout

### Example Usage

<!-- UsageSnippet language="csharp" operationID="LayoutsController_update" method="put" path="/v2/layouts/{layoutId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Layouts.UpdateAsync(
    layoutId: "<id>",
    updateLayoutDto: new UpdateLayoutDto() {
        Name = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `LayoutId`                                                    | *string*                                                      | :heavy_check_mark:                                            | N/A                                                           |
| `UpdateLayoutDto`                                             | [UpdateLayoutDto](../../Models/Components/UpdateLayoutDto.md) | :heavy_check_mark:                                            | Layout update details                                         |
| `IdempotencyKey`                                              | *string*                                                      | :heavy_minus_sign:                                            | A header for idempotency purposes                             |

### Response

**[LayoutsControllerUpdateResponse](../../Models/Requests/LayoutsControllerUpdateResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Retrieve

Fetches details of a specific layout by its unique identifier **layoutId**

### Example Usage

<!-- UsageSnippet language="csharp" operationID="LayoutsController_get" method="get" path="/v2/layouts/{layoutId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Layouts.RetrieveAsync(layoutId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `LayoutId`                        | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[LayoutsControllerGetResponse](../../Models/Requests/LayoutsControllerGetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Removes a specific layout by its unique identifier **layoutId**

### Example Usage

<!-- UsageSnippet language="csharp" operationID="LayoutsController__delete" method="delete" path="/v2/layouts/{layoutId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Layouts.DeleteAsync(layoutId: "<id>");

// handle response
```

### Parameters

| Parameter                           | Type                                | Required                            | Description                         |
| ----------------------------------- | ----------------------------------- | ----------------------------------- | ----------------------------------- |
| `LayoutId`                          | *string*                            | :heavy_check_mark:                  | The unique identifier of the layout |
| `IdempotencyKey`                    | *string*                            | :heavy_minus_sign:                  | A header for idempotency purposes   |

### Response

**[LayoutsControllerDeleteResponse](../../Models/Requests/LayoutsControllerDeleteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Duplicate

Duplicates a layout by its unique identifier **layoutId**. This will create a new layout with the content of the original layout.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="LayoutsController_duplicate" method="post" path="/v2/layouts/{layoutId}/duplicate" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Layouts.DuplicateAsync(
    layoutId: "<id>",
    duplicateLayoutDto: new DuplicateLayoutDto() {
        Name = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `LayoutId`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `DuplicateLayoutDto`                                                | [DuplicateLayoutDto](../../Models/Components/DuplicateLayoutDto.md) | :heavy_check_mark:                                                  | N/A                                                                 |
| `IdempotencyKey`                                                    | *string*                                                            | :heavy_minus_sign:                                                  | A header for idempotency purposes                                   |

### Response

**[LayoutsControllerDuplicateResponse](../../Models/Requests/LayoutsControllerDuplicateResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## GeneratePreview

Generates a preview for a layout by its unique identifier **layoutId**

### Example Usage

<!-- UsageSnippet language="csharp" operationID="LayoutsController_generatePreview" method="post" path="/v2/layouts/{layoutId}/preview" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Layouts.GeneratePreviewAsync(
    layoutId: "<id>",
    layoutPreviewRequestDto: new LayoutPreviewRequestDto() {
        PreviewPayload = new LayoutPreviewPayloadDto() {
            Subscriber = new SubscriberResponseDtoOptional() {
                Channels = new List<ChannelSettingsDto>() {
                    new ChannelSettingsDto() {
                        ProviderId = ChatOrPushProviderEnum.Mattermost,
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
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `LayoutId`                                                                    | *string*                                                                      | :heavy_check_mark:                                                            | N/A                                                                           |
| `LayoutPreviewRequestDto`                                                     | [LayoutPreviewRequestDto](../../Models/Components/LayoutPreviewRequestDto.md) | :heavy_check_mark:                                                            | Layout preview generation details                                             |
| `IdempotencyKey`                                                              | *string*                                                                      | :heavy_minus_sign:                                                            | A header for idempotency purposes                                             |

### Response

**[LayoutsControllerGeneratePreviewResponse](../../Models/Requests/LayoutsControllerGeneratePreviewResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Usage

Retrieves information about workflows that use the specified layout by its unique identifier **layoutId**

### Example Usage

<!-- UsageSnippet language="csharp" operationID="LayoutsController_getUsage" method="get" path="/v2/layouts/{layoutId}/usage" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Layouts.UsageAsync(layoutId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `LayoutId`                        | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[LayoutsControllerGetUsageResponse](../../Models/Requests/LayoutsControllerGetUsageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |