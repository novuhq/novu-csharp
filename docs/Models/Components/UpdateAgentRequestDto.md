# UpdateAgentRequestDto


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `Name`                                                          | *string*                                                        | :heavy_minus_sign:                                              | N/A                                                             |
| `Description`                                                   | *string*                                                        | :heavy_minus_sign:                                              | N/A                                                             |
| `Active`                                                        | *bool*                                                          | :heavy_minus_sign:                                              | N/A                                                             |
| `Behavior`                                                      | [AgentBehaviorDto](../../Models/Components/AgentBehaviorDto.md) | :heavy_minus_sign:                                              | N/A                                                             |
| `BridgeUrl`                                                     | *string*                                                        | :heavy_minus_sign:                                              | Production bridge URL for this agent                            |
| `DevBridgeUrl`                                                  | *string*                                                        | :heavy_minus_sign:                                              | Development bridge URL (set by npx novu dev)                    |
| `DevBridgeActive`                                               | *bool*                                                          | :heavy_minus_sign:                                              | Whether the dev bridge override is active                       |