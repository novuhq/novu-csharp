# Subscribers
(*Subscribers*)

## Overview

### Available Operations

* [Search](#search) - Search for subscribers
* [Create](#create) - Create subscriber
* [Retrieve](#retrieve) - Get subscriber
* [Patch](#patch) - Patch subscriber
* [Delete](#delete) - Delete subscriber
* [GetAll](#getall) - Get subscribers
* [Upsert](#upsert) - Upsert subscriber
* [CreateBulk](#createbulk) - Bulk create subscribers
* [UpdateCredentials](#updatecredentials) - Update subscriber credentials
* [AppendCredentials](#appendcredentials) - Modify subscriber credentials
* [DeleteCredentials](#deletecredentials) - Delete subscriber credentials by providerId
* [GetChatAccessOauth](#getchataccessoauth) - Handle chat oauth
* [UpdateOnlineStatus](#updateonlinestatus) - Update subscriber online status

## Search

Search for subscribers

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

SubscribersControllerSearchSubscribersRequest req = new SubscribersControllerSearchSubscribersRequest() {};

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
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Create

Create subscriber with the given data

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.CreateAsync(
    createSubscriberRequestDto: new CreateSubscriberRequestDto() {
        SubscriberId = "<id>",
    },
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `CreateSubscriberRequestDto`                                                        | [CreateSubscriberRequestDto](../../Models/Components/CreateSubscriberRequestDto.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `IdempotencyKey`                                                                    | *string*                                                                            | :heavy_minus_sign:                                                                  | A header for idempotency purposes                                                   |

### Response

**[SubscribersControllerCreateSubscriberResponse](../../Models/Requests/SubscribersControllerCreateSubscriberResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Retrieve

Get subscriber by your internal id used to identify the subscriber

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.RetrieveAsync(
    subscriberId: "<id>",
    idempotencyKey: "<value>"
);

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
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Patch

Patch subscriber by your internal id used to identify the subscriber

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.PatchAsync(
    subscriberId: "<id>",
    patchSubscriberRequestDto: new PatchSubscriberRequestDto() {},
    idempotencyKey: "<value>"
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
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Deletes a subscriber entity from the Novu platform

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.DeleteAsync(
    subscriberId: "<id>",
    idempotencyKey: "<value>"
);

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
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## GetAll

Returns a list of subscribers, could paginated using the `page` and `limit` query parameter

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

SubscribersV1ControllerListSubscribersResponse? res = await sdk.Subscribers.GetAllAsync(
    page: 4610.08D,
    limit: 10D,
    idempotencyKey: "<value>"
);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Page`                            | *double*                          | :heavy_minus_sign:                | N/A                               |
| `Limit`                           | *double*                          | :heavy_minus_sign:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[SubscribersV1ControllerListSubscribersResponse](../../Models/Requests/SubscribersV1ControllerListSubscribersResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Upsert

Used to upsert the subscriber entity with new information

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.UpsertAsync(
    subscriberId: "<id>",
    updateSubscriberRequestDto: new UpdateSubscriberRequestDto() {
        Email = "john.doe@example.com",
        FirstName = "John",
        LastName = "Doe",
        Phone = "+1234567890",
        Avatar = "https://example.com/avatar.jpg",
        Locale = "en-US",
        Data = new Dictionary<string, object>() {
            { "preferences", new Dictionary<string, object>() {
                { "notifications", true },
                { "theme", "dark" },
            } },
            { "tags", new List<object>() {
                "premium",
                "newsletter",
            } },
        },
    },
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `SubscriberId`                                                                      | *string*                                                                            | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `UpdateSubscriberRequestDto`                                                        | [UpdateSubscriberRequestDto](../../Models/Components/UpdateSubscriberRequestDto.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `IdempotencyKey`                                                                    | *string*                                                                            | :heavy_minus_sign:                                                                  | A header for idempotency purposes                                                   |

### Response

**[SubscribersV1ControllerUpdateSubscriberResponse](../../Models/Requests/SubscribersV1ControllerUpdateSubscriberResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## CreateBulk


      Using this endpoint you can create multiple subscribers at once, to avoid multiple calls to the API.
      The bulk API is limited to 500 subscribers per request.
    

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.CreateBulkAsync(
    bulkSubscriberCreateDto: new BulkSubscriberCreateDto() {
        Subscribers = new List<CreateSubscriberRequestDto>() {
            new CreateSubscriberRequestDto() {
                SubscriberId = "<id>",
            },
        },
    },
    idempotencyKey: "<value>"
);

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
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## UpdateCredentials

Subscriber credentials associated to the delivery methods such as slack and push tokens.

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.UpdateCredentialsAsync(
    subscriberId: "<id>",
    updateSubscriberChannelRequestDto: new UpdateSubscriberChannelRequestDto() {
        ProviderId = ChatOrPushProviderEnum.PushWebhook,
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
    },
    idempotencyKey: "<value>"
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
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## AppendCredentials

Subscriber credentials associated to the delivery methods such as slack and push tokens.

    This endpoint appends provided credentials and deviceTokens to the existing ones.

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.AppendCredentialsAsync(
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
    },
    idempotencyKey: "<value>"
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
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## DeleteCredentials

Delete subscriber credentials such as slack and expo tokens.

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.DeleteCredentialsAsync(
    subscriberId: "<id>",
    providerId: "<id>",
    idempotencyKey: "<value>"
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
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## GetChatAccessOauth

Handle chat oauth

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

SubscribersV1ControllerChatAccessOauthRequest req = new SubscribersV1ControllerChatAccessOauthRequest() {
    SubscriberId = "<id>",
    ProviderId = "<value>",
    HmacHash = "<value>",
    EnvironmentId = "<id>",
};

var res = await sdk.Subscribers.GetChatAccessOauthAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                               | [SubscribersV1ControllerChatAccessOauthRequest](../../Models/Requests/SubscribersV1ControllerChatAccessOauthRequest.md) | :heavy_check_mark:                                                                                                      | The request object to use for the request.                                                                              |

### Response

**[SubscribersV1ControllerChatAccessOauthResponse](../../Models/Requests/SubscribersV1ControllerChatAccessOauthResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## UpdateOnlineStatus

Used to update the subscriber isOnline flag.

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.UpdateOnlineStatusAsync(
    subscriberId: "<id>",
    updateSubscriberOnlineFlagRequestDto: new UpdateSubscriberOnlineFlagRequestDto() {
        IsOnline = false,
    },
    idempotencyKey: "<value>"
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
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |