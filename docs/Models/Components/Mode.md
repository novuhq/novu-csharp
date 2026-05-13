# Mode

OAuth flow mode. Use "connect" (default) to create a workspace channel connection, or "link_user" to identify the subscriber's Slack user ID without creating a connection.

## Example Usage

```csharp
using Novu.Models.Components;

var value = Mode.Connect;
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Connect`  | connect    |
| `LinkUser` | link_user  |