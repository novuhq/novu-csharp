# ContextsControllerUpdateContextRequest


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Id`                                                                          | *string*                                                                      | :heavy_check_mark:                                                            | Context ID                                                                    |
| `Type`                                                                        | *string*                                                                      | :heavy_check_mark:                                                            | Context type                                                                  |
| `IdempotencyKey`                                                              | *string*                                                                      | :heavy_minus_sign:                                                            | A header for idempotency purposes                                             |
| `UpdateContextRequestDto`                                                     | [UpdateContextRequestDto](../../Models/Components/UpdateContextRequestDto.md) | :heavy_check_mark:                                                            | N/A                                                                           |