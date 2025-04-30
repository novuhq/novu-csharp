# MessagesControllerGetMessagesRequest


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `Channel`                                                     | [ChannelTypeEnum](../../Models/Components/ChannelTypeEnum.md) | :heavy_minus_sign:                                            | Channel type through which the message is sent                |
| `SubscriberId`                                                | *string*                                                      | :heavy_minus_sign:                                            | N/A                                                           |
| `TransactionId`                                               | List<*string*>                                                | :heavy_minus_sign:                                            | N/A                                                           |
| `Page`                                                        | *double*                                                      | :heavy_minus_sign:                                            | N/A                                                           |
| `Limit`                                                       | *double*                                                      | :heavy_minus_sign:                                            | N/A                                                           |
| `IdempotencyKey`                                              | *string*                                                      | :heavy_minus_sign:                                            | A header for idempotency purposes                             |