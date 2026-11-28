# DeliveryLifecycleDetail

Why the run reached its delivery lifecycle status, e.g. preference or missing_email. Absent when no reason was recorded.

## Example Usage

```csharp
using Novu.Models.Components;

var value = DeliveryLifecycleDetail.StepCondition;
```


## Values

| Name                              | Value                             |
| --------------------------------- | --------------------------------- |
| `StepCondition`                   | step_condition                    |
| `Preference`                      | preference                        |
| `MissingPhone`                    | missing_phone                     |
| `MissingEmail`                    | missing_email                     |
| `MissingPushToken`                | missing_push_token                |
| `MissingWebhookUrl`               | missing_webhook_url               |
| `SomeChannelsMissingCredentials`  | some_channels_missing_credentials |
| `WorkflowMissingChannelStep`      | workflow_missing_channel_step     |
| `UnknownError`                    | unknown_error                     |
| `ExecutionStopped`                | execution_stopped                 |
| `ExecutionCanceledByUser`         | execution_canceled_by_user        |