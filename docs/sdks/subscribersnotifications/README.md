# SubscribersNotifications
(*SubscribersNotifications*)

## Overview

### Available Operations

* [Feed](#feed) - Get in-app notification feed for a particular subscriber
* [UnseenCount](#unseencount) - Get the unseen in-app notifications count for subscribers feed

## Feed

Get in-app notification feed for a particular subscriber

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

SubscribersV1ControllerGetNotificationsFeedRequest req = new SubscribersV1ControllerGetNotificationsFeedRequest() {
    SubscriberId = "<id>",
    Payload = "btoa(JSON.stringify({ foo: 123 })) results in base64 encoded string like eyJmb28iOjEyM30=",
};

var res = await sdk.SubscribersNotifications.FeedAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                         | Type                                                                                                                              | Required                                                                                                                          | Description                                                                                                                       |
| --------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                         | [SubscribersV1ControllerGetNotificationsFeedRequest](../../Models/Requests/SubscribersV1ControllerGetNotificationsFeedRequest.md) | :heavy_check_mark:                                                                                                                | The request object to use for the request.                                                                                        |

### Response

**[SubscribersV1ControllerGetNotificationsFeedResponse](../../Models/Requests/SubscribersV1ControllerGetNotificationsFeedResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## UnseenCount

Get the unseen in-app notifications count for subscribers feed

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.SubscribersNotifications.UnseenCountAsync(
    subscriberId: "<id>",
    seen: false,
    limit: 100D,
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter                                      | Type                                           | Required                                       | Description                                    |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| `SubscriberId`                                 | *string*                                       | :heavy_check_mark:                             | N/A                                            |
| `Seen`                                         | *bool*                                         | :heavy_minus_sign:                             | Indicates whether to count seen notifications. |
| `Limit`                                        | *double*                                       | :heavy_minus_sign:                             | The maximum number of notifications to return. |
| `IdempotencyKey`                               | *string*                                       | :heavy_minus_sign:                             | A header for idempotency purposes              |

### Response

**[SubscribersV1ControllerGetUnseenCountResponse](../../Models/Requests/SubscribersV1ControllerGetUnseenCountResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |