# InboundWebhooksControllerHandleWebhookRequest


## Fields

| Field                                                | Type                                                 | Required                                             | Description                                          |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `EnvironmentId`                                      | *string*                                             | :heavy_check_mark:                                   | The environment identifier                           |
| `IntegrationId`                                      | *string*                                             | :heavy_check_mark:                                   | The integration identifier for the delivery provider |
| `IdempotencyKey`                                     | *string*                                             | :heavy_minus_sign:                                   | A header for idempotency purposes                    |
| `RequestBody`                                        | Dictionary<String, *object*>                         | :heavy_check_mark:                                   | Webhook event payload from the delivery provider     |