# ToolControlsMetadataResponseDto


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `DataSchema`                                                | Dictionary<String, *object*>                                | :heavy_minus_sign:                                          | JSON Schema for data                                        |
| `UiSchema`                                                  | [UiSchema](../../Models/Components/UiSchema.md)             | :heavy_minus_sign:                                          | UI Schema for rendering                                     |
| `Values`                                                    | [ToolControlDto](../../Models/Components/ToolControlDto.md) | :heavy_check_mark:                                          | Control values specific to Tool                             |