# ListSubscribersResponseDto


## Fields

| Field                                                                           | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `Data`                                                                          | List<[SubscriberResponseDto](../../Models/Components/SubscriberResponseDto.md)> | :heavy_check_mark:                                                              | List of returned Subscribers                                                    |
| `Next`                                                                          | *string*                                                                        | :heavy_check_mark:                                                              | The cursor for the next page of results, or null if there are no more pages.    |
| `Previous`                                                                      | *string*                                                                        | :heavy_check_mark:                                                              | The cursor for the previous page of results, or null if this is the first page. |