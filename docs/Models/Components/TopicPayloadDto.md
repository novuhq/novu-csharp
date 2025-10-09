# TopicPayloadDto


## Fields

| Field                                                                             | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `TopicKey`                                                                        | *string*                                                                          | :heavy_check_mark:                                                                | N/A                                                                               |
| `Type`                                                                            | [TriggerRecipientsTypeEnum](../../Models/Components/TriggerRecipientsTypeEnum.md) | :heavy_check_mark:                                                                | N/A                                                                               |
| `Exclude`                                                                         | List<*string*>                                                                    | :heavy_minus_sign:                                                                | Optional array of subscriber IDs to exclude from the topic trigger                |