# MessagesControllerDeleteMessagesByTransactionIdRequest


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `Channel`                                                   | [Models.Requests.Channel](../../Models/Requests/Channel.md) | :heavy_minus_sign:                                          | The channel of the message to be deleted                    |
| `TransactionId`                                             | *string*                                                    | :heavy_check_mark:                                          | N/A                                                         |
| `IdempotencyKey`                                            | *string*                                                    | :heavy_minus_sign:                                          | A header for idempotency purposes                           |