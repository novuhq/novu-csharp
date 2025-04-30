# SubscribersMessages
(*SubscribersMessages*)

## Overview

### Available Operations

* [UpdateAction](#updateaction) - Mark message action as seen
* [MarkAll](#markall) - Marks all the subscriber messages as read, unread, seen or unseen. Optionally you can pass feed id (or array) to mark messages of a particular feed.
* [MarkAllAs](#markallas) - Mark a subscriber messages as seen, read, unseen or unread

## UpdateAction

Mark message action as seen

### Example Usage

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
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## MarkAll

Marks all the subscriber messages as read, unread, seen or unseen. Optionally you can pass feed id (or array) to mark messages of a particular feed.

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.SubscribersMessages.MarkAllAsync(
    subscriberId: "<id>",
    markAllMessageAsRequestDto: new MarkAllMessageAsRequestDto() {
        MarkAs = MarkAs.Seen,
    },
    idempotencyKey: "<value>"
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
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## MarkAllAs

Mark a subscriber messages as seen, read, unseen or unread

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.SubscribersMessages.MarkAllAsAsync(
    subscriberId: "<id>",
    messageMarkAsRequestDto: new MessageMarkAsRequestDto() {
        MessageId = MessageId.CreateStr(
            "<id>"
        ),
        MarkAs = MessageMarkAsRequestDtoMarkAs.Unread,
    },
    idempotencyKey: "<value>"
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
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |