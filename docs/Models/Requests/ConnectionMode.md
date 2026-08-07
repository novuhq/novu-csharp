# ConnectionMode

Scope results relative to the subscriber. `subscriber` returns only the subscriber-owned connections, `shared` returns only shared (workspace-level) connections. Omit to return both.

## Example Usage

```csharp
using Novu.Models.Requests;

var value = ConnectionMode.Subscriber;
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Subscriber` | subscriber   |
| `Shared`     | shared       |