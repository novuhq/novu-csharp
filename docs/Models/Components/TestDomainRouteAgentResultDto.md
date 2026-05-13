# TestDomainRouteAgentResultDto


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `AgentId`                                                   | *string*                                                    | :heavy_check_mark:                                          | N/A                                                         |
| `HttpStatus`                                                | *double*                                                    | :heavy_check_mark:                                          | N/A                                                         |
| `AgentReply`                                                | [AgentReply](../../Models/Components/AgentReply.md)         | :heavy_minus_sign:                                          | Parsed JSON body from the agent webhook response when JSON. |
| `LatencyMs`                                                 | *double*                                                    | :heavy_check_mark:                                          | N/A                                                         |