# UiComponentEnum

Component type for the UI Schema Property

## Example Usage

```csharp
using Novu.Models.Components;

var value = UiComponentEnum.EmailEditorSelect;

// Open enum: use .Of() to create instances from custom string values
var custom = UiComponentEnum.Of("custom_value");
```


## Values

| Name                                  | Value                                 |
| ------------------------------------- | ------------------------------------- |
| `EmailEditorSelect`                   | EMAIL_EDITOR_SELECT                   |
| `LayoutSelect`                        | LAYOUT_SELECT                         |
| `BlockEditor`                         | BLOCK_EDITOR                          |
| `EmailBody`                           | EMAIL_BODY                            |
| `TextFullLine`                        | TEXT_FULL_LINE                        |
| `TextInlineLabel`                     | TEXT_INLINE_LABEL                     |
| `InAppBody`                           | IN_APP_BODY                           |
| `InAppAvatar`                         | IN_APP_AVATAR                         |
| `InAppPrimarySubject`                 | IN_APP_PRIMARY_SUBJECT                |
| `InAppButtonDropdown`                 | IN_APP_BUTTON_DROPDOWN                |
| `InAppDisableSanitizationSwitch`      | IN_APP_DISABLE_SANITIZATION_SWITCH    |
| `DisableSanitizationSwitch`           | DISABLE_SANITIZATION_SWITCH           |
| `UrlTextBox`                          | URL_TEXT_BOX                          |
| `DigestAmount`                        | DIGEST_AMOUNT                         |
| `DigestUnit`                          | DIGEST_UNIT                           |
| `DigestType`                          | DIGEST_TYPE                           |
| `DigestKey`                           | DIGEST_KEY                            |
| `DigestCron`                          | DIGEST_CRON                           |
| `DelayAmount`                         | DELAY_AMOUNT                          |
| `DelayUnit`                           | DELAY_UNIT                            |
| `DelayType`                           | DELAY_TYPE                            |
| `DelayCron`                           | DELAY_CRON                            |
| `DelayDynamicKey`                     | DELAY_DYNAMIC_KEY                     |
| `ThrottleType`                        | THROTTLE_TYPE                         |
| `ThrottleWindow`                      | THROTTLE_WINDOW                       |
| `ThrottleUnit`                        | THROTTLE_UNIT                         |
| `ThrottleDynamicKey`                  | THROTTLE_DYNAMIC_KEY                  |
| `ThrottleThreshold`                   | THROTTLE_THRESHOLD                    |
| `ThrottleKey`                         | THROTTLE_KEY                          |
| `ExtendToSchedule`                    | EXTEND_TO_SCHEDULE                    |
| `SmsBody`                             | SMS_BODY                              |
| `ChatBody`                            | CHAT_BODY                             |
| `PushBody`                            | PUSH_BODY                             |
| `PushSubject`                         | PUSH_SUBJECT                          |
| `QueryEditor`                         | QUERY_EDITOR                          |
| `Data`                                | DATA                                  |
| `LayoutEmail`                         | LAYOUT_EMAIL                          |
| `DestinationMethod`                   | DESTINATION_METHOD                    |
| `DestinationUrl`                      | DESTINATION_URL                       |
| `DestinationHeaders`                  | DESTINATION_HEADERS                   |
| `DestinationBody`                     | DESTINATION_BODY                      |
| `DestinationResponseBodySchema`       | DESTINATION_RESPONSE_BODY_SCHEMA      |
| `DestinationEnforceSchemaValidation`  | DESTINATION_ENFORCE_SCHEMA_VALIDATION |
| `DestinationContinueOnFailure`        | DESTINATION_CONTINUE_ON_FAILURE       |
| `DestinationTimeout`                  | DESTINATION_TIMEOUT                   |