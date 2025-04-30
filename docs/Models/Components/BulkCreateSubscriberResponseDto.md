# BulkCreateSubscriberResponseDto


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `Updated`                                                                      | List<[UpdatedSubscriberDto](../../Models/Components/UpdatedSubscriberDto.md)>  | :heavy_check_mark:                                                             | An array of subscribers that were successfully updated.                        |
| `Created`                                                                      | List<[CreatedSubscriberDto](../../Models/Components/CreatedSubscriberDto.md)>  | :heavy_check_mark:                                                             | An array of subscribers that were successfully created.                        |
| `Failed`                                                                       | List<[FailedOperationDto](../../Models/Components/FailedOperationDto.md)>      | :heavy_check_mark:                                                             | An array of failed operations with error messages and optional subscriber IDs. |