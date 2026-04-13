# GetSubscriberNotificationsResponseDto


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Data`                                                                        | List<[InboxNotificationDto](../../Models/Components/InboxNotificationDto.md)> | :heavy_check_mark:                                                            | Array of notifications                                                        |
| `HasMore`                                                                     | *bool*                                                                        | :heavy_check_mark:                                                            | Indicates if there are more notifications available                           |
| `Filter`                                                                      | [Filter](../../Models/Components/Filter.md)                                   | :heavy_check_mark:                                                            | The filter applied to the notifications                                       |