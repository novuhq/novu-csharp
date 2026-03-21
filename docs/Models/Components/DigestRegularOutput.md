# DigestRegularOutput


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `Amount`                                                    | *double*                                                    | :heavy_check_mark:                                          | Amount of time units                                        |
| `Unit`                                                      | [TimeUnitEnum](../../Models/Components/TimeUnitEnum.md)     | :heavy_check_mark:                                          | Time unit                                                   |
| `DigestKey`                                                 | *string*                                                    | :heavy_minus_sign:                                          | Optional digest key                                         |
| `LookBackWindow`                                            | [LookBackWindow](../../Models/Components/LookBackWindow.md) | :heavy_minus_sign:                                          | Look back window configuration                              |