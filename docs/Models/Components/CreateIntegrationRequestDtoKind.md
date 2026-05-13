# CreateIntegrationRequestDtoKind

Distinguishes delivery integrations from agent-runtime integrations. Defaults to "delivery". Agent integrations do not require a channel.

## Example Usage

```csharp
using Novu.Models.Components;

var value = CreateIntegrationRequestDtoKind.Delivery;
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Delivery` | delivery   |
| `Agent`    | agent      |