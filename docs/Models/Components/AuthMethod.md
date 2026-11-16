# AuthMethod

Twilio: `apiKey` authenticates with `apiKey` (API Key SID) and `secretKey` (API Key Secret) on behalf of `accountSid`. When omitted, `token` (Auth Token) is used.

## Example Usage

```csharp
using Novu.Models.Components;

var value = AuthMethod.ApiKey;
```


## Values

| Name     | Value    |
| -------- | -------- |
| `ApiKey` | apiKey   |