# Subscribers
(*Subscribers*)

## Overview

### Available Operations

* [Search](#search) - Search subscribers
* [Create](#create) - Create a subscriber
* [Retrieve](#retrieve) - Retrieve a subscriber
* [Patch](#patch) - Update a subscriber
* [Delete](#delete) - Delete a subscriber
* [CreateBulk](#createbulk) - Bulk create subscribers
* [UpdateCredentials](#updatecredentials) - Upsert provider credentials
* [AppendCredentials](#appendcredentials) - Update provider credentials
* [DeleteCredentials](#deletecredentials) - Delete provider credentials
* [UpdateOnlineStatus](#updateonlinestatus) - Update subscriber online status

## Search

Search subscribers by their **email**, **phone**, **subscriberId** and **name**. 
    The search is case sensitive and supports pagination.Checkout all available filters in the query section.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_searchSubscribers" method="get" path="/v2/subscribers" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

SubscribersControllerSearchSubscribersRequest? req = null;

var res = await sdk.Subscribers.SearchAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                               | [SubscribersControllerSearchSubscribersRequest](../../Models/Requests/SubscribersControllerSearchSubscribersRequest.md) | :heavy_check_mark:                                                                                                      | The request object to use for the request.                                                                              |

### Response

**[SubscribersControllerSearchSubscribersResponse](../../Models/Requests/SubscribersControllerSearchSubscribersResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Create

Create a subscriber with the subscriber attributes. 
      **subscriberId** is a required field, rest other fields are optional, if the subscriber already exists, it will be updated

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_createSubscriber" method="post" path="/v2/subscribers" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.CreateAsync(createSubscriberRequestDto: new CreateSubscriberRequestDto() {
    SubscriberId = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `CreateSubscriberRequestDto`                                                             | [CreateSubscriberRequestDto](../../Models/Components/CreateSubscriberRequestDto.md)      | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `FailIfExists`                                                                           | *bool*                                                                                   | :heavy_minus_sign:                                                                       | If true, the request will fail if a subscriber with the same subscriberId already exists |
| `IdempotencyKey`                                                                         | *string*                                                                                 | :heavy_minus_sign:                                                                       | A header for idempotency purposes                                                        |

### Response

**[SubscribersControllerCreateSubscriberResponse](../../Models/Requests/SubscribersControllerCreateSubscriberResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Novu.Models.Errors.SubscriberResponseDto | 409                                      | application/json                         |
| Novu.Models.Errors.ErrorDto              | 414                                      | application/json                         |
| Novu.Models.Errors.ErrorDto              | 400, 401, 403, 404, 405, 413, 415        | application/json                         |
| Novu.Models.Errors.ValidationErrorDto    | 422                                      | application/json                         |
| Novu.Models.Errors.ErrorDto              | 500                                      | application/json                         |
| Novu.Models.Errors.APIException          | 4XX, 5XX                                 | \*/\*                                    |

## Retrieve

Retrieve a subscriber by its unique key identifier **subscriberId**. 
    **subscriberId** field is required.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_getSubscriber" method="get" path="/v2/subscribers/{subscriberId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.RetrieveAsync(subscriberId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `SubscriberId`                    | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[SubscribersControllerGetSubscriberResponse](../../Models/Requests/SubscribersControllerGetSubscriberResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Patch

Update a subscriber by its unique key identifier **subscriberId**. 
    **subscriberId** is a required field, rest other fields are optional

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_patchSubscriber" method="patch" path="/v2/subscribers/{subscriberId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.PatchAsync(
    subscriberId: "<id>",
    patchSubscriberRequestDto: new PatchSubscriberRequestDto() {}
);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `SubscriberId`                                                                    | *string*                                                                          | :heavy_check_mark:                                                                | N/A                                                                               |
| `PatchSubscriberRequestDto`                                                       | [PatchSubscriberRequestDto](../../Models/Components/PatchSubscriberRequestDto.md) | :heavy_check_mark:                                                                | N/A                                                                               |
| `IdempotencyKey`                                                                  | *string*                                                                          | :heavy_minus_sign:                                                                | A header for idempotency purposes                                                 |

### Response

**[SubscribersControllerPatchSubscriberResponse](../../Models/Requests/SubscribersControllerPatchSubscriberResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Deletes a subscriber entity from the Novu platform along with associated messages, preferences, and topic subscriptions. 
      **subscriberId** is a required field.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_removeSubscriber" method="delete" path="/v2/subscribers/{subscriberId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.DeleteAsync(subscriberId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `SubscriberId`                    | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[SubscribersControllerRemoveSubscriberResponse](../../Models/Requests/SubscribersControllerRemoveSubscriberResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## CreateBulk


      Using this endpoint multiple subscribers can be created at once. The bulk API is limited to 500 subscribers per request.
    

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersV1Controller_bulkCreateSubscribers" method="post" path="/v1/subscribers/bulk" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.CreateBulkAsync(bulkSubscriberCreateDto: new BulkSubscriberCreateDto() {
    Subscribers = new List<CreateSubscriberRequestDto>() {
        new CreateSubscriberRequestDto() {
            SubscriberId = "<id>",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `BulkSubscriberCreateDto`                                                     | [BulkSubscriberCreateDto](../../Models/Components/BulkSubscriberCreateDto.md) | :heavy_check_mark:                                                            | N/A                                                                           |
| `IdempotencyKey`                                                              | *string*                                                                      | :heavy_minus_sign:                                                            | A header for idempotency purposes                                             |

### Response

**[SubscribersV1ControllerBulkCreateSubscribersResponse](../../Models/Requests/SubscribersV1ControllerBulkCreateSubscribersResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## UpdateCredentials

Upsert credentials for a provider such as slack and push tokens. 
      **providerId** is required field. This API creates **deviceTokens** or appends to the existing ones.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersV1Controller_updateSubscriberChannel" method="put" path="/v1/subscribers/{subscriberId}/credentials" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.UpdateCredentialsAsync(
    subscriberId: "<id>",
    updateSubscriberChannelRequestDto: new UpdateSubscriberChannelRequestDto() {
        ProviderId = ChatOrPushProviderEnum.Slack,
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
    }
);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `SubscriberId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | N/A                                                                                               |
| `UpdateSubscriberChannelRequestDto`                                                               | [UpdateSubscriberChannelRequestDto](../../Models/Components/UpdateSubscriberChannelRequestDto.md) | :heavy_check_mark:                                                                                | N/A                                                                                               |
| `IdempotencyKey`                                                                                  | *string*                                                                                          | :heavy_minus_sign:                                                                                | A header for idempotency purposes                                                                 |

### Response

**[SubscribersV1ControllerUpdateSubscriberChannelResponse](../../Models/Requests/SubscribersV1ControllerUpdateSubscriberChannelResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## AppendCredentials

Update credentials for a provider such as **slack** and **FCM**. 
      **providerId** is required field. This API creates the **deviceTokens** or replaces the existing ones.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersV1Controller_modifySubscriberChannel" method="patch" path="/v1/subscribers/{subscriberId}/credentials" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.AppendCredentialsAsync(
    subscriberId: "<id>",
    updateSubscriberChannelRequestDto: new UpdateSubscriberChannelRequestDto() {
        ProviderId = ChatOrPushProviderEnum.OneSignal,
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
    }
);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `SubscriberId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | N/A                                                                                               |
| `UpdateSubscriberChannelRequestDto`                                                               | [UpdateSubscriberChannelRequestDto](../../Models/Components/UpdateSubscriberChannelRequestDto.md) | :heavy_check_mark:                                                                                | N/A                                                                                               |
| `IdempotencyKey`                                                                                  | *string*                                                                                          | :heavy_minus_sign:                                                                                | A header for idempotency purposes                                                                 |

### Response

**[SubscribersV1ControllerModifySubscriberChannelResponse](../../Models/Requests/SubscribersV1ControllerModifySubscriberChannelResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## DeleteCredentials

Delete subscriber credentials for a provider such as **slack** and **FCM** by **providerId**. 
    This action is irreversible and will remove the credentials for the provider for particular **subscriberId**.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersV1Controller_deleteSubscriberCredentials" method="delete" path="/v1/subscribers/{subscriberId}/credentials/{providerId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.DeleteCredentialsAsync(
    subscriberId: "<id>",
    providerId: "<id>"
);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `SubscriberId`                    | *string*                          | :heavy_check_mark:                | N/A                               |
| `ProviderId`                      | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[SubscribersV1ControllerDeleteSubscriberCredentialsResponse](../../Models/Requests/SubscribersV1ControllerDeleteSubscriberCredentialsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## UpdateOnlineStatus

Update the subscriber online status by its unique key identifier **subscriberId**

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersV1Controller_updateSubscriberOnlineFlag" method="patch" path="/v1/subscribers/{subscriberId}/online-status" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.UpdateOnlineStatusAsync(
    subscriberId: "<id>",
    updateSubscriberOnlineFlagRequestDto: new UpdateSubscriberOnlineFlagRequestDto() {
        IsOnline = false,
    }
);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `SubscriberId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | N/A                                                                                                     |
| `UpdateSubscriberOnlineFlagRequestDto`                                                                  | [UpdateSubscriberOnlineFlagRequestDto](../../Models/Components/UpdateSubscriberOnlineFlagRequestDto.md) | :heavy_check_mark:                                                                                      | N/A                                                                                                     |
| `IdempotencyKey`                                                                                        | *string*                                                                                                | :heavy_minus_sign:                                                                                      | A header for idempotency purposes                                                                       |

### Response

**[SubscribersV1ControllerUpdateSubscriberOnlineFlagResponse](../../Models/Requests/SubscribersV1ControllerUpdateSubscriberOnlineFlagResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |