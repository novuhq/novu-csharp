# Subscribers.Notifications

## Overview

### Available Operations

* [List](#list) - Retrieve subscriber notifications
* [Delete](#delete) - Delete a notification
* [CompleteAction](#completeaction) - Complete a notification action
* [RevertAction](#revertaction) - Revert a notification action
* [Archive](#archive) - Archive a notification
* [MarkAsRead](#markasread) - Mark a notification as read
* [Snooze](#snooze) - Snooze a notification
* [Unarchive](#unarchive) - Unarchive a notification
* [MarkAsUnread](#markasunread) - Mark a notification as unread
* [Unsnooze](#unsnooze) - Unsnooze a notification
* [ArchiveAll](#archiveall) - Archive all notifications
* [Count](#count) - Retrieve subscriber notifications count
* [DeleteAll](#deleteall) - Delete all notifications
* [MarkAllAsRead](#markallasread) - Mark all notifications as read
* [ArchiveAllRead](#archiveallread) - Archive all read notifications
* [MarkAsSeen](#markasseen) - Mark notifications as seen

## List

Retrieve in-app (inbox) notifications for a subscriber by its unique key identifier **subscriberId**. 
    Supports filtering by tags, read/archived/snoozed/seen state, data attributes, severity, date range, and context keys.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_getSubscriberNotifications" method="get" path="/v2/subscribers/{subscriberId}/notifications" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

SubscribersControllerGetSubscriberNotificationsRequest req = new SubscribersControllerGetSubscriberNotificationsRequest() {
    SubscriberId = "<id>",
    Offset = 0D,
    CreatedGte = 1704067200000D,
    CreatedLte = 1735689599999D,
};

var res = await sdk.Subscribers.Notifications.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                                 | Type                                                                                                                                      | Required                                                                                                                                  | Description                                                                                                                               |
| ----------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                                 | [SubscribersControllerGetSubscriberNotificationsRequest](../../Models/Requests/SubscribersControllerGetSubscriberNotificationsRequest.md) | :heavy_check_mark:                                                                                                                        | The request object to use for the request.                                                                                                |

### Response

**[SubscribersControllerGetSubscriberNotificationsResponse](../../Models/Requests/SubscribersControllerGetSubscriberNotificationsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Delete a specific in-app (inbox) notification permanently by its unique identifier **notificationId**.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_deleteNotification" method="delete" path="/v2/subscribers/{subscriberId}/notifications/{notificationId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Notifications.DeleteAsync(
    subscriberId: "<id>",
    notificationId: "<id>"
);

// handle response
```

### Parameters

| Parameter                          | Type                               | Required                           | Description                        |
| ---------------------------------- | ---------------------------------- | ---------------------------------- | ---------------------------------- |
| `SubscriberId`                     | *string*                           | :heavy_check_mark:                 | The identifier of the subscriber   |
| `NotificationId`                   | *string*                           | :heavy_check_mark:                 | The identifier of the notification |
| `ContextKeys`                      | List<*string*>                     | :heavy_minus_sign:                 | Context keys for filtering         |
| `IdempotencyKey`                   | *string*                           | :heavy_minus_sign:                 | A header for idempotency purposes  |

### Response

**[SubscribersControllerDeleteNotificationResponse](../../Models/Requests/SubscribersControllerDeleteNotificationResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## CompleteAction

Mark a single in-app (inbox) notification's action (primary or secondary) as completed by its unique identifier **notificationId** and action type **actionType**.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_completeNotificationAction" method="patch" path="/v2/subscribers/{subscriberId}/notifications/{notificationId}/actions/{actionType}/complete" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

SubscribersControllerCompleteNotificationActionRequest req = new SubscribersControllerCompleteNotificationActionRequest() {
    SubscriberId = "<id>",
    NotificationId = "<id>",
    ActionType = ActionType.Secondary,
};

var res = await sdk.Subscribers.Notifications.CompleteActionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                                 | Type                                                                                                                                      | Required                                                                                                                                  | Description                                                                                                                               |
| ----------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                                 | [SubscribersControllerCompleteNotificationActionRequest](../../Models/Requests/SubscribersControllerCompleteNotificationActionRequest.md) | :heavy_check_mark:                                                                                                                        | The request object to use for the request.                                                                                                |

### Response

**[SubscribersControllerCompleteNotificationActionResponse](../../Models/Requests/SubscribersControllerCompleteNotificationActionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## RevertAction

Revert a single in-app (inbox) notification's action (primary or secondary) to pending state by its unique identifier **notificationId** and action type **actionType**.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_revertNotificationAction" method="patch" path="/v2/subscribers/{subscriberId}/notifications/{notificationId}/actions/{actionType}/revert" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

SubscribersControllerRevertNotificationActionRequest req = new SubscribersControllerRevertNotificationActionRequest() {
    SubscriberId = "<id>",
    NotificationId = "<id>",
    ActionType = PathParamActionType.Primary,
};

var res = await sdk.Subscribers.Notifications.RevertActionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                             | Type                                                                                                                                  | Required                                                                                                                              | Description                                                                                                                           |
| ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                             | [SubscribersControllerRevertNotificationActionRequest](../../Models/Requests/SubscribersControllerRevertNotificationActionRequest.md) | :heavy_check_mark:                                                                                                                    | The request object to use for the request.                                                                                            |

### Response

**[SubscribersControllerRevertNotificationActionResponse](../../Models/Requests/SubscribersControllerRevertNotificationActionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Archive

Archive a specific in-app (inbox) notification by its unique identifier **notificationId**.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_archiveNotification" method="patch" path="/v2/subscribers/{subscriberId}/notifications/{notificationId}/archive" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Notifications.ArchiveAsync(
    subscriberId: "<id>",
    notificationId: "<id>"
);

// handle response
```

### Parameters

| Parameter                          | Type                               | Required                           | Description                        |
| ---------------------------------- | ---------------------------------- | ---------------------------------- | ---------------------------------- |
| `SubscriberId`                     | *string*                           | :heavy_check_mark:                 | The identifier of the subscriber   |
| `NotificationId`                   | *string*                           | :heavy_check_mark:                 | The identifier of the notification |
| `ContextKeys`                      | List<*string*>                     | :heavy_minus_sign:                 | Context keys for filtering         |
| `IdempotencyKey`                   | *string*                           | :heavy_minus_sign:                 | A header for idempotency purposes  |

### Response

**[SubscribersControllerArchiveNotificationResponse](../../Models/Requests/SubscribersControllerArchiveNotificationResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## MarkAsRead

Mark a specific in-app (inbox) notification as read by its unique identifier **notificationId**.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_markNotificationAsRead" method="patch" path="/v2/subscribers/{subscriberId}/notifications/{notificationId}/read" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Notifications.MarkAsReadAsync(
    subscriberId: "<id>",
    notificationId: "<id>"
);

// handle response
```

### Parameters

| Parameter                          | Type                               | Required                           | Description                        |
| ---------------------------------- | ---------------------------------- | ---------------------------------- | ---------------------------------- |
| `SubscriberId`                     | *string*                           | :heavy_check_mark:                 | The identifier of the subscriber   |
| `NotificationId`                   | *string*                           | :heavy_check_mark:                 | The identifier of the notification |
| `ContextKeys`                      | List<*string*>                     | :heavy_minus_sign:                 | Context keys for filtering         |
| `IdempotencyKey`                   | *string*                           | :heavy_minus_sign:                 | A header for idempotency purposes  |

### Response

**[SubscribersControllerMarkNotificationAsReadResponse](../../Models/Requests/SubscribersControllerMarkNotificationAsReadResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Snooze

Snooze a specific in-app (inbox) notification by its unique identifier **notificationId** until a specified time.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_snoozeNotification" method="patch" path="/v2/subscribers/{subscriberId}/notifications/{notificationId}/snooze" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;
using System;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

SubscribersControllerSnoozeNotificationRequest req = new SubscribersControllerSnoozeNotificationRequest() {
    SubscriberId = "<id>",
    NotificationId = "<id>",
    SnoozeSubscriberNotificationDto = new SnoozeSubscriberNotificationDto() {
        SnoozeUntil = System.DateTime.Parse("2026-03-01T10:00:00Z").ToUniversalTime(),
    },
};

var res = await sdk.Subscribers.Notifications.SnoozeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                 | Type                                                                                                                      | Required                                                                                                                  | Description                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                 | [SubscribersControllerSnoozeNotificationRequest](../../Models/Requests/SubscribersControllerSnoozeNotificationRequest.md) | :heavy_check_mark:                                                                                                        | The request object to use for the request.                                                                                |

### Response

**[SubscribersControllerSnoozeNotificationResponse](../../Models/Requests/SubscribersControllerSnoozeNotificationResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Unarchive

Unarchive a specific in-app (inbox) notification by its unique identifier **notificationId**.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_unarchiveNotification" method="patch" path="/v2/subscribers/{subscriberId}/notifications/{notificationId}/unarchive" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Notifications.UnarchiveAsync(
    subscriberId: "<id>",
    notificationId: "<id>"
);

// handle response
```

### Parameters

| Parameter                          | Type                               | Required                           | Description                        |
| ---------------------------------- | ---------------------------------- | ---------------------------------- | ---------------------------------- |
| `SubscriberId`                     | *string*                           | :heavy_check_mark:                 | The identifier of the subscriber   |
| `NotificationId`                   | *string*                           | :heavy_check_mark:                 | The identifier of the notification |
| `ContextKeys`                      | List<*string*>                     | :heavy_minus_sign:                 | Context keys for filtering         |
| `IdempotencyKey`                   | *string*                           | :heavy_minus_sign:                 | A header for idempotency purposes  |

### Response

**[SubscribersControllerUnarchiveNotificationResponse](../../Models/Requests/SubscribersControllerUnarchiveNotificationResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## MarkAsUnread

Mark a specific in-app (inbox) notification as unread by its unique identifier **notificationId**.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_markNotificationAsUnread" method="patch" path="/v2/subscribers/{subscriberId}/notifications/{notificationId}/unread" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Notifications.MarkAsUnreadAsync(
    subscriberId: "<id>",
    notificationId: "<id>"
);

// handle response
```

### Parameters

| Parameter                          | Type                               | Required                           | Description                        |
| ---------------------------------- | ---------------------------------- | ---------------------------------- | ---------------------------------- |
| `SubscriberId`                     | *string*                           | :heavy_check_mark:                 | The identifier of the subscriber   |
| `NotificationId`                   | *string*                           | :heavy_check_mark:                 | The identifier of the notification |
| `ContextKeys`                      | List<*string*>                     | :heavy_minus_sign:                 | Context keys for filtering         |
| `IdempotencyKey`                   | *string*                           | :heavy_minus_sign:                 | A header for idempotency purposes  |

### Response

**[SubscribersControllerMarkNotificationAsUnreadResponse](../../Models/Requests/SubscribersControllerMarkNotificationAsUnreadResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Unsnooze

Unsnooze a specific in-app (inbox) notification by its unique identifier **notificationId**.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_unsnoozeNotification" method="patch" path="/v2/subscribers/{subscriberId}/notifications/{notificationId}/unsnooze" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Notifications.UnsnoozeAsync(
    subscriberId: "<id>",
    notificationId: "<id>"
);

// handle response
```

### Parameters

| Parameter                          | Type                               | Required                           | Description                        |
| ---------------------------------- | ---------------------------------- | ---------------------------------- | ---------------------------------- |
| `SubscriberId`                     | *string*                           | :heavy_check_mark:                 | The identifier of the subscriber   |
| `NotificationId`                   | *string*                           | :heavy_check_mark:                 | The identifier of the notification |
| `ContextKeys`                      | List<*string*>                     | :heavy_minus_sign:                 | Context keys for filtering         |
| `IdempotencyKey`                   | *string*                           | :heavy_minus_sign:                 | A header for idempotency purposes  |

### Response

**[SubscribersControllerUnsnoozeNotificationResponse](../../Models/Requests/SubscribersControllerUnsnoozeNotificationResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## ArchiveAll

Archive all in-app (inbox) notifications matching the specified filters. Supports context-based filtering.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_archiveAllNotifications" method="post" path="/v2/subscribers/{subscriberId}/notifications/archive" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Notifications.ArchiveAllAsync(
    subscriberId: "<id>",
    updateAllSubscriberNotificationsDto: new UpdateAllSubscriberNotificationsDto() {}
);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `SubscriberId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | The identifier of the subscriber                                                                      |
| `UpdateAllSubscriberNotificationsDto`                                                                 | [UpdateAllSubscriberNotificationsDto](../../Models/Components/UpdateAllSubscriberNotificationsDto.md) | :heavy_check_mark:                                                                                    | N/A                                                                                                   |
| `IdempotencyKey`                                                                                      | *string*                                                                                              | :heavy_minus_sign:                                                                                    | A header for idempotency purposes                                                                     |

### Response

**[SubscribersControllerArchiveAllNotificationsResponse](../../Models/Requests/SubscribersControllerArchiveAllNotificationsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Count

Retrieve count of in-app (inbox) notifications for a subscriber by its unique key identifier **subscriberId**. 
    Supports multiple filters to count in-app (inbox) notifications by different criteria, including context keys.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_getSubscriberNotificationsCount" method="get" path="/v2/subscribers/{subscriberId}/notifications/count" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Notifications.CountAsync(
    subscriberId: "<id>",
    filters: "[{\"read\":false,\"archived\":false},{\"tags\":[\"important\"]},{\"tags\":{\"and\":[{\"or\":[\"a\",\"b\"]},{\"or\":[\"c\"]}]}}]"
);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               | Example                                                                                                   |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `SubscriberId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | The identifier of the subscriber                                                                          |                                                                                                           |
| `Filters`                                                                                                 | *string*                                                                                                  | :heavy_check_mark:                                                                                        | Array of filter objects (max 30) to count notifications by different criteria                             | [{"read":false,"archived":false},{"tags":["important"]},{"tags":{"and":[{"or":["a","b"]},{"or":["c"]}]}}] |
| `IdempotencyKey`                                                                                          | *string*                                                                                                  | :heavy_minus_sign:                                                                                        | A header for idempotency purposes                                                                         |                                                                                                           |

### Response

**[SubscribersControllerGetSubscriberNotificationsCountResponse](../../Models/Requests/SubscribersControllerGetSubscriberNotificationsCountResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## DeleteAll

Permanently delete all in-app (inbox) notifications matching the specified filters. Supports context-based filtering.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_deleteAllNotifications" method="post" path="/v2/subscribers/{subscriberId}/notifications/delete" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Notifications.DeleteAllAsync(
    subscriberId: "<id>",
    updateAllSubscriberNotificationsDto: new UpdateAllSubscriberNotificationsDto() {}
);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `SubscriberId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | The identifier of the subscriber                                                                      |
| `UpdateAllSubscriberNotificationsDto`                                                                 | [UpdateAllSubscriberNotificationsDto](../../Models/Components/UpdateAllSubscriberNotificationsDto.md) | :heavy_check_mark:                                                                                    | N/A                                                                                                   |
| `IdempotencyKey`                                                                                      | *string*                                                                                              | :heavy_minus_sign:                                                                                    | A header for idempotency purposes                                                                     |

### Response

**[SubscribersControllerDeleteAllNotificationsResponse](../../Models/Requests/SubscribersControllerDeleteAllNotificationsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## MarkAllAsRead

Mark all in-app (inbox) notifications matching the specified filters as read. Supports context-based filtering.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_markAllNotificationsAsRead" method="post" path="/v2/subscribers/{subscriberId}/notifications/read" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Notifications.MarkAllAsReadAsync(
    subscriberId: "<id>",
    updateAllSubscriberNotificationsDto: new UpdateAllSubscriberNotificationsDto() {}
);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `SubscriberId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | The identifier of the subscriber                                                                      |
| `UpdateAllSubscriberNotificationsDto`                                                                 | [UpdateAllSubscriberNotificationsDto](../../Models/Components/UpdateAllSubscriberNotificationsDto.md) | :heavy_check_mark:                                                                                    | N/A                                                                                                   |
| `IdempotencyKey`                                                                                      | *string*                                                                                              | :heavy_minus_sign:                                                                                    | A header for idempotency purposes                                                                     |

### Response

**[SubscribersControllerMarkAllNotificationsAsReadResponse](../../Models/Requests/SubscribersControllerMarkAllNotificationsAsReadResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## ArchiveAllRead

Archive all read in-app (inbox) notifications matching the specified filters. Supports context-based filtering.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_archiveAllReadNotifications" method="post" path="/v2/subscribers/{subscriberId}/notifications/read-archive" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Notifications.ArchiveAllReadAsync(
    subscriberId: "<id>",
    updateAllSubscriberNotificationsDto: new UpdateAllSubscriberNotificationsDto() {}
);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `SubscriberId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | The identifier of the subscriber                                                                      |
| `UpdateAllSubscriberNotificationsDto`                                                                 | [UpdateAllSubscriberNotificationsDto](../../Models/Components/UpdateAllSubscriberNotificationsDto.md) | :heavy_check_mark:                                                                                    | N/A                                                                                                   |
| `IdempotencyKey`                                                                                      | *string*                                                                                              | :heavy_minus_sign:                                                                                    | A header for idempotency purposes                                                                     |

### Response

**[SubscribersControllerArchiveAllReadNotificationsResponse](../../Models/Requests/SubscribersControllerArchiveAllReadNotificationsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## MarkAsSeen

Mark specific and multiple in-app (inbox) notifications as seen. Supports context-based filtering.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_markNotificationsAsSeen" method="post" path="/v2/subscribers/{subscriberId}/notifications/seen" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Notifications.MarkAsSeenAsync(
    subscriberId: "<id>",
    markSubscriberNotificationsAsSeenDto: new MarkSubscriberNotificationsAsSeenDto() {}
);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `SubscriberId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | The identifier of the subscriber                                                                        |
| `MarkSubscriberNotificationsAsSeenDto`                                                                  | [MarkSubscriberNotificationsAsSeenDto](../../Models/Components/MarkSubscriberNotificationsAsSeenDto.md) | :heavy_check_mark:                                                                                      | N/A                                                                                                     |
| `IdempotencyKey`                                                                                        | *string*                                                                                                | :heavy_minus_sign:                                                                                      | A header for idempotency purposes                                                                       |

### Response

**[SubscribersControllerMarkNotificationsAsSeenResponse](../../Models/Requests/SubscribersControllerMarkNotificationsAsSeenResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |