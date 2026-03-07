# ResourceDependencyDto


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `ResourceType`                                                          | [ResourceTypeEnum](../../Models/Components/ResourceTypeEnum.md)         | :heavy_check_mark:                                                      | Type of the layout                                                      |
| `ResourceId`                                                            | *string*                                                                | :heavy_check_mark:                                                      | ID of the dependent resource                                            |
| `ResourceName`                                                          | *string*                                                                | :heavy_check_mark:                                                      | Name of the dependent resource                                          |
| `IsBlocking`                                                            | *bool*                                                                  | :heavy_check_mark:                                                      | Whether this dependency blocks the operation                            |
| `Reason`                                                                | [DependencyReasonEnum](../../Models/Components/DependencyReasonEnum.md) | :heavy_check_mark:                                                      | Reason for the dependency                                               |