# IntegrationResponseDtoChannel

The channel type for the integration, which defines how it communicates (e.g., email, SMS). Not set for agent-kind integrations.

## Example Usage

```csharp
using Novu.Models.Components;

var value = IntegrationResponseDtoChannel.InApp;
```


## Values

| Name    | Value   |
| ------- | ------- |
| `InApp` | in_app  |
| `Email` | email   |
| `Sms`   | sms     |
| `Chat`  | chat    |
| `Push`  | push    |