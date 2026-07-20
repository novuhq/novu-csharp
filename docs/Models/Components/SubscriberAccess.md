# SubscriberAccess

Controls whether the agent accepts inbound messages from senders not yet linked to a subscriber, across all channels. "open" on managed agents auto-creates a lightweight subscriber so the agent can reply; on custom-code / self-hosted agents, the turn is forwarded to the bridge with a null subscriber. "restricted" rejects unknown senders with a managed denial reply (any runtime). Unset resolves as "restricted". Managed agent create defaults to "open"; self-hosted create defaults to "restricted".

## Example Usage

```csharp
using Novu.Models.Components;

var value = SubscriberAccess.Open;
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Open`       | open         |
| `Restricted` | restricted   |