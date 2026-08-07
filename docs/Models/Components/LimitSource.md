# LimitSource

Which constraint produced the limits. `plan` limits are lifted by upgrading; `system` limits (platform cap or per-organization override) require contacting the Novu team.

## Example Usage

```csharp
using Novu.Models.Components;

var value = LimitSource.Plan;
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Plan`   | plan     |
| `System` | system   |