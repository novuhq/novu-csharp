# LayoutsControllerUpdateRequest


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `LayoutId`                                                    | *string*                                                      | :heavy_check_mark:                                            | N/A                                                           |
| `IdempotencyKey`                                              | *string*                                                      | :heavy_minus_sign:                                            | A header for idempotency purposes                             |
| `UpdateLayoutDto`                                             | [UpdateLayoutDto](../../Models/Components/UpdateLayoutDto.md) | :heavy_check_mark:                                            | Layout update details                                         |