# SyncResultDto


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `ResourceType`                                                            | [ResourceTypeEnum](../../Models/Components/ResourceTypeEnum.md)           | :heavy_check_mark:                                                        | Type of the layout                                                        |
| `Successful`                                                              | List<[SyncedWorkflowDto](../../Models/Components/SyncedWorkflowDto.md)>   | :heavy_check_mark:                                                        | Successfully synced resources                                             |
| `Failed`                                                                  | List<[FailedWorkflowDto](../../Models/Components/FailedWorkflowDto.md)>   | :heavy_check_mark:                                                        | Failed resource syncs                                                     |
| `Skipped`                                                                 | List<[SkippedWorkflowDto](../../Models/Components/SkippedWorkflowDto.md)> | :heavy_check_mark:                                                        | Skipped resources                                                         |
| `TotalProcessed`                                                          | *double*                                                                  | :heavy_check_mark:                                                        | Total number of resources processed                                       |