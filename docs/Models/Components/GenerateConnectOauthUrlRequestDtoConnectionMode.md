# GenerateConnectOauthUrlRequestDtoConnectionMode

Connection mode that determines how the channel connection is scoped. "subscriber" (default) associates the connection with a specific subscriber. "shared" associates the connection with a context instead of a subscriber.

## Example Usage

```csharp
using Novu.Models.Components;

var value = GenerateConnectOauthUrlRequestDtoConnectionMode.Subscriber;
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Subscriber` | subscriber   |
| `Shared`     | shared       |