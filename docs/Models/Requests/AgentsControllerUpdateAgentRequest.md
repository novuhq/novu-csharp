# AgentsControllerUpdateAgentRequest


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `Identifier`                                                              | *string*                                                                  | :heavy_check_mark:                                                        | N/A                                                                       |
| `IdempotencyKey`                                                          | *string*                                                                  | :heavy_minus_sign:                                                        | A header for idempotency purposes                                         |
| `UpdateAgentRequestDto`                                                   | [UpdateAgentRequestDto](../../Models/Components/UpdateAgentRequestDto.md) | :heavy_check_mark:                                                        | N/A                                                                       |