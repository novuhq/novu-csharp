# StepListResponseDto


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `Slug`                                                    | *string*                                                  | :heavy_check_mark:                                        | Slug of the step                                          |
| `Type`                                                    | [StepTypeEnum](../../Models/Components/StepTypeEnum.md)   | :heavy_check_mark:                                        | Channels of the notification                              |
| `Issues`                                                  | [StepIssuesDto](../../Models/Components/StepIssuesDto.md) | :heavy_minus_sign:                                        | Issues associated with the step                           |