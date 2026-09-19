# HmacSecretKeyEncoding

Email webhook: how `secretKey` is interpreted when signing webhook calls. `text` signs with the raw UTF-8 bytes; `base64`/`hex` decode it to binary first (e.g. for AWS KMS).

## Example Usage

```csharp
using Novu.Models.Components;

var value = HmacSecretKeyEncoding.Text;
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Text`   | text     |
| `Base64` | base64   |
| `Hex`    | hex      |