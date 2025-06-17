# ChatControlsMetadataResponseDto


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `DataSchema`                                                | Dictionary<String, *object*>                                | :heavy_minus_sign:                                          | JSON Schema for data                                        |
| `UiSchema`                                                  | [UiSchema](../../Models/Components/UiSchema.md)             | :heavy_minus_sign:                                          | UI Schema for rendering                                     |
| `Values`                                                    | [ChatControlDto](../../Models/Components/ChatControlDto.md) | :heavy_check_mark:                                          | Control values specific to Chat                             |