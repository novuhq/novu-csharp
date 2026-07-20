# EditPayloadDto


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              | Example                                                                  |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `MessageId`                                                              | *string*                                                                 | :heavy_check_mark:                                                       | Platform message id of the message to edit.                              | 1712345678.123456                                                        |
| `Content`                                                                | [Content](../../Models/Components/Content.md)                            | :heavy_check_mark:                                                       | Replacement content. Exactly one of markdown, card, or toolApprovalCard. |                                                                          |