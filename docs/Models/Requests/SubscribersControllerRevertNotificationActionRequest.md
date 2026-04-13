# SubscribersControllerRevertNotificationActionRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SubscriberId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | The identifier of the subscriber                                    |
| `NotificationId`                                                    | *string*                                                            | :heavy_check_mark:                                                  | The identifier of the notification                                  |
| `ActionType`                                                        | [PathParamActionType](../../Models/Requests/PathParamActionType.md) | :heavy_check_mark:                                                  | The type of action (primary or secondary)                           |
| `ContextKeys`                                                       | List<*string*>                                                      | :heavy_minus_sign:                                                  | Context keys for filtering                                          |
| `IdempotencyKey`                                                    | *string*                                                            | :heavy_minus_sign:                                                  | A header for idempotency purposes                                   |