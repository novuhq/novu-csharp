# LayoutsControllerCreateRequest


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `IdempotencyKey`                                              | *string*                                                      | :heavy_minus_sign:                                            | A header for idempotency purposes                             |
| `CreateLayoutDto`                                             | [CreateLayoutDto](../../Models/Components/CreateLayoutDto.md) | :heavy_check_mark:                                            | Layout creation details                                       |