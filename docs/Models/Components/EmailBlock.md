# EmailBlock


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Type`                                                              | [EmailBlockTypeEnum](../../Models/Components/EmailBlockTypeEnum.md) | :heavy_check_mark:                                                  | Type of the email block                                             |
| `Content`                                                           | *string*                                                            | :heavy_check_mark:                                                  | Content of the email block                                          |
| `Url`                                                               | *string*                                                            | :heavy_minus_sign:                                                  | URL associated with the email block, if any                         |
| `Styles`                                                            | [EmailBlockStyles](../../Models/Components/EmailBlockStyles.md)     | :heavy_minus_sign:                                                  | Styles applied to the email block                                   |