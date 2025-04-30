# TriggerEventResponseDto


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Acknowledged`                                                    | *bool*                                                            | :heavy_check_mark:                                                | Indicates whether the trigger was acknowledged or not             |
| `Status`                                                          | [Status](../../Models/Components/Status.md)                       | :heavy_check_mark:                                                | Status of the trigger                                             |
| `Error`                                                           | List<*string*>                                                    | :heavy_minus_sign:                                                | In case of an error, this field will contain the error message(s) |
| `TransactionId`                                                   | *string*                                                          | :heavy_minus_sign:                                                | The returned transaction ID of the trigger                        |