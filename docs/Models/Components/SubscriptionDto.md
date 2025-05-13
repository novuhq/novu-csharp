# SubscriptionDto


## Fields

| Field                                               | Type                                                | Required                                            | Description                                         | Example                                             |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `Id`                                                | *string*                                            | :heavy_check_mark:                                  | The unique identifier of the subscription           | 64f5e95d3d7946d80d0cb679                            |
| `Topic`                                             | [TopicDto](../../Models/Components/TopicDto.md)     | :heavy_check_mark:                                  | The topic information                               |                                                     |
| `Subscriber`                                        | [Subscriber](../../Models/Components/Subscriber.md) | :heavy_check_mark:                                  | The subscriber information                          |                                                     |
| `CreatedAt`                                         | *string*                                            | :heavy_check_mark:                                  | The creation date of the subscription               | 2025-04-24T05:40:21Z                                |
| `UpdatedAt`                                         | *string*                                            | :heavy_check_mark:                                  | The last update date of the subscription            | 2025-04-24T05:40:21Z                                |