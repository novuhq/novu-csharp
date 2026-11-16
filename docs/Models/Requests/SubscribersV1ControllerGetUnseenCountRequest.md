# SubscribersV1ControllerGetUnseenCountRequest


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `SubscriberId`                                                          | *string*                                                                | :heavy_check_mark:                                                      | N/A                                                                     |
| `FeedId`                                                                | List<*string*>                                                          | :heavy_minus_sign:                                                      | Identifier for the feed. Can be a single string or an array of strings. |
| `Seen`                                                                  | *bool*                                                                  | :heavy_minus_sign:                                                      | Indicates whether to count seen notifications.                          |
| `Limit`                                                                 | *double*                                                                | :heavy_minus_sign:                                                      | The maximum number of notifications to return.                          |
| `IdempotencyKey`                                                        | *string*                                                                | :heavy_minus_sign:                                                      | A header for idempotency purposes                                       |