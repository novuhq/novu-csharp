# NotificationWorkflowDto


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | Unique identifier of the workflow                                 |
| `Identifier`                                                      | *string*                                                          | :heavy_check_mark:                                                | Workflow identifier used for triggering                           |
| `Name`                                                            | *string*                                                          | :heavy_check_mark:                                                | Human-readable name of the workflow                               |
| `Critical`                                                        | *bool*                                                            | :heavy_check_mark:                                                | Whether this workflow is marked as critical                       |
| `Tags`                                                            | List<*string*>                                                    | :heavy_minus_sign:                                                | Tags associated with the workflow                                 |
| `Data`                                                            | Dictionary<String, *object*>                                      | :heavy_minus_sign:                                                | Custom data associated with the workflow                          |
| `Severity`                                                        | [SeverityLevelEnum](../../Models/Components/SeverityLevelEnum.md) | :heavy_check_mark:                                                | Severity of the workflow                                          |