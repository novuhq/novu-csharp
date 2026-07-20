# UpdateAgentBridgeRequestDto


## Fields

| Field                                        | Type                                         | Required                                     | Description                                  |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| `BridgeUrl`                                  | *string*                                     | :heavy_minus_sign:                           | Production bridge URL for this agent         |
| `DevBridgeUrl`                               | *string*                                     | :heavy_minus_sign:                           | Development bridge URL (set by npx novu dev) |
| `DevBridgeActive`                            | *bool*                                       | :heavy_minus_sign:                           | Whether the dev bridge override is active    |