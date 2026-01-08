# CreateSubscriptionsResponseDto


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `Data`                                                                              | List<[SubscriptionResponseDto](../../Models/Components/SubscriptionResponseDto.md)> | :heavy_check_mark:                                                                  | The list of successfully created subscriptions                                      |
| `Meta`                                                                              | [MetaDto](../../Models/Components/MetaDto.md)                                       | :heavy_check_mark:                                                                  | Metadata about the operation                                                        |
| `Errors`                                                                            | List<[SubscriptionErrorDto](../../Models/Components/SubscriptionErrorDto.md)>       | :heavy_minus_sign:                                                                  | The list of errors for failed subscription attempts                                 |