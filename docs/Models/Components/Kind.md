# Kind

Distinguishes delivery integrations from agent-runtime integrations. Defaults to "delivery". Agent integrations do not have a channel.

## Example Usage

```csharp
using Novu.Models.Components;

var value = Kind.Delivery;
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Delivery` | delivery   |
| `Agent`    | agent      |