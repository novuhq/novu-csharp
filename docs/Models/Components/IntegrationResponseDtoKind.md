# IntegrationResponseDtoKind

Distinguishes delivery integrations from agent-runtime integrations. Defaults to "delivery". Agent integrations do not have a channel.

## Example Usage

```csharp
using Novu.Models.Components;

var value = IntegrationResponseDtoKind.Delivery;
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Delivery` | delivery   |
| `Agent`    | agent      |