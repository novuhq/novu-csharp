# InAppStepUpsertDto


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `Id`                                                      | *string*                                                  | :heavy_minus_sign:                                        | Unique identifier of the step                             |
| `Name`                                                    | *string*                                                  | :heavy_check_mark:                                        | Name of the step                                          |
| `Type`                                                    | [StepTypeEnum](../../Models/Components/StepTypeEnum.md)   | :heavy_check_mark:                                        | Type of the step                                          |
| `ControlValues`                                           | [ControlValues](../../Models/Components/ControlValues.md) | :heavy_minus_sign:                                        | Control values for the In-App step                        |