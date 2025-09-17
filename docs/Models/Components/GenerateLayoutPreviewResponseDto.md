# GenerateLayoutPreviewResponseDto


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `PreviewPayloadExample`                                                       | [LayoutPreviewPayloadDto](../../Models/Components/LayoutPreviewPayloadDto.md) | :heavy_check_mark:                                                            | Preview payload example                                                       |
| `Schema`                                                                      | Dictionary<String, *object*>                                                  | :heavy_minus_sign:                                                            | The payload schema that was used to generate the preview payload example      |
| `Result`                                                                      | [Result](../../Models/Components/Result.md)                                   | :heavy_check_mark:                                                            | Preview result                                                                |