# FilterTopicsResponseDto


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           | Example                                               |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `Data`                                                | List<[TopicDto](../../Models/Components/TopicDto.md)> | :heavy_check_mark:                                    | The list of topics                                    | []                                                    |
| `Page`                                                | *double*                                              | :heavy_check_mark:                                    | The current page number                               | 1                                                     |
| `PageSize`                                            | *double*                                              | :heavy_check_mark:                                    | The number of items per page                          | 10                                                    |
| `TotalCount`                                          | *double*                                              | :heavy_check_mark:                                    | The total number of items                             | 10                                                    |