# SubscribersV1ControllerMarkAllUnreadAsReadRequest


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `SubscriberId`                                                                      | *string*                                                                            | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `MarkAllMessageAsRequestDto`                                                        | [MarkAllMessageAsRequestDto](../../Models/Components/MarkAllMessageAsRequestDto.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `IdempotencyKey`                                                                    | *string*                                                                            | :heavy_minus_sign:                                                                  | A header for idempotency purposes                                                   |