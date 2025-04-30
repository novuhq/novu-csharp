# MessagesControllerDeleteMessagesByTransactionIdRequest


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `TransactionId`                                             | *string*                                                    | :heavy_check_mark:                                          | N/A                                                         |
| `Channel`                                                   | [Models.Requests.Channel](../../Models/Requests/Channel.md) | :heavy_minus_sign:                                          | The channel of the message to be deleted                    |
| `IdempotencyKey`                                            | *string*                                                    | :heavy_minus_sign:                                          | A header for idempotency purposes                           |