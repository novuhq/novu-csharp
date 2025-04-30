# TopicsControllerAssignRequest


## Fields

| Field                                                                           | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `TopicKey`                                                                      | *string*                                                                        | :heavy_check_mark:                                                              | The topic key                                                                   |
| `AddSubscribersRequestDto`                                                      | [AddSubscribersRequestDto](../../Models/Components/AddSubscribersRequestDto.md) | :heavy_check_mark:                                                              | N/A                                                                             |
| `IdempotencyKey`                                                                | *string*                                                                        | :heavy_minus_sign:                                                              | A header for idempotency purposes                                               |