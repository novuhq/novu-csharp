# LayoutsControllerGeneratePreviewRequest


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `LayoutId`                                                                    | *string*                                                                      | :heavy_check_mark:                                                            | N/A                                                                           |
| `IdempotencyKey`                                                              | *string*                                                                      | :heavy_minus_sign:                                                            | A header for idempotency purposes                                             |
| `LayoutPreviewRequestDto`                                                     | [LayoutPreviewRequestDto](../../Models/Components/LayoutPreviewRequestDto.md) | :heavy_check_mark:                                                            | Layout preview generation details                                             |