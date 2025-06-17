# WorkflowControllerUpdateRequest


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `WorkflowId`                                                      | *string*                                                          | :heavy_check_mark:                                                | N/A                                                               |
| `IdempotencyKey`                                                  | *string*                                                          | :heavy_minus_sign:                                                | A header for idempotency purposes                                 |
| `UpdateWorkflowDto`                                               | [UpdateWorkflowDto](../../Models/Components/UpdateWorkflowDto.md) | :heavy_check_mark:                                                | Workflow update details                                           |