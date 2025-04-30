# AssignSubscriberToTopicDto


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Succeeded`                                                             | List<*string*>                                                          | :heavy_check_mark:                                                      | List of successfully assigned subscriber IDs                            |
| `Failed`                                                                | [FailedAssignmentsDto](../../Models/Components/FailedAssignmentsDto.md) | :heavy_minus_sign:                                                      | Details about failed assignments                                        |