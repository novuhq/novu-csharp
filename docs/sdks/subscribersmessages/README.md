# ~~SubscribersMessages~~

> [!WARNING]
> This SDK is **DEPRECATED**

## Overview

### Available Operations

* [~~UpdateAction~~](#updateaction) - Update notification action status :warning: **Deprecated**
* [~~MarkAll~~](#markall) - Update all notifications state :warning: **Deprecated**
* [~~MarkAllAs~~](#markallas) - Update notifications state :warning: **Deprecated**

## ~~UpdateAction~~

This API is deprecated, use v2 API instead. Update in-app notification's action status by its unique key identifier **messageId** and type field **type**. 
      **type** field can be **primary** or **secondary**

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersV1Controller_markActionAsSeen" method="post" path="/v1/subscribers/{subscriberId}/messages/{messageId}/actions/{type}" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

SubscribersV1ControllerMarkActionAsSeenRequest req = new SubscribersV1ControllerMarkActionAsSeenRequest() {
    MessageId = "<id>",
    Type = "<value>",
    SubscriberId = "<id>",
    MarkMessageActionAsSeenDto = new MarkMessageActionAsSeenDto() {
        Status = MarkMessageActionAsSeenDtoStatus.Pending,
    },
};

var res = await sdk.SubscribersMessages.UpdateActionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                 | Type                                                                                                                      | Required                                                                                                                  | Description                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                 | [SubscribersV1ControllerMarkActionAsSeenRequest](../../Models/Requests/SubscribersV1ControllerMarkActionAsSeenRequest.md) | :heavy_check_mark:                                                                                                        | The request object to use for the request.                                                                                |

### Response

**[SubscribersV1ControllerMarkActionAsSeenResponse](../../Models/Requests/SubscribersV1ControllerMarkActionAsSeenResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## ~~MarkAll~~

This API is deprecated, use v2 API instead. Update all subscriber in-app notifications state such as read, unread, seen or unseen by **subscriberId**.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersV1Controller_markAllUnreadAsRead" method="post" path="/v1/subscribers/{subscriberId}/messages/mark-all" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.SubscribersMessages.MarkAllAsync(
    subscriberId: "<id>",
    markAllMessageAsRequestDto: new MarkAllMessageAsRequestDto() {
        MarkAs = MarkAs.Read,
    }
);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `SubscriberId`                                                                      | *string*                                                                            | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `MarkAllMessageAsRequestDto`                                                        | [MarkAllMessageAsRequestDto](../../Models/Components/MarkAllMessageAsRequestDto.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `IdempotencyKey`                                                                    | *string*                                                                            | :heavy_minus_sign:                                                                  | A header for idempotency purposes                                                   |

### Response

**[SubscribersV1ControllerMarkAllUnreadAsReadResponse](../../Models/Requests/SubscribersV1ControllerMarkAllUnreadAsReadResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## ~~MarkAllAs~~

This API is deprecated, use v2 API instead. Update subscriber's multiple in-app notifications state such as seen, read, unseen or unread by **subscriberId**. 
      **messageId** is of type mongodbId of notifications.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersV1Controller_markMessagesAs" method="post" path="/v1/subscribers/{subscriberId}/messages/mark-as" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.SubscribersMessages.MarkAllAsAsync(
    subscriberId: "<id>",
    messageMarkAsRequestDto: new MessageMarkAsRequestDto() {
        MessageId = MessageId.CreateArrayOfStr(
            new List<string>() {}
        ),
        MarkAs = MessageMarkAsRequestDtoMarkAs.Seen,
    }
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `SubscriberId`                                                                | *string*                                                                      | :heavy_check_mark:                                                            | N/A                                                                           |
| `MessageMarkAsRequestDto`                                                     | [MessageMarkAsRequestDto](../../Models/Components/MessageMarkAsRequestDto.md) | :heavy_check_mark:                                                            | N/A                                                                           |
| `IdempotencyKey`                                                              | *string*                                                                      | :heavy_minus_sign:                                                            | A header for idempotency purposes                                             |

### Response

**[SubscribersV1ControllerMarkMessagesAsResponse](../../Models/Requests/SubscribersV1ControllerMarkMessagesAsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |