# SubscribersV1ControllerChatAccessOauthRequest


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `SubscriberId`                                        | *string*                                              | :heavy_check_mark:                                    | N/A                                                   |
| `ProviderId`                                          | *object*                                              | :heavy_check_mark:                                    | N/A                                                   |
| `HmacHash`                                            | *string*                                              | :heavy_check_mark:                                    | HMAC hash for the request                             |
| `EnvironmentId`                                       | *string*                                              | :heavy_check_mark:                                    | The ID of the environment, must be a valid MongoDB ID |
| `IntegrationIdentifier`                               | *string*                                              | :heavy_minus_sign:                                    | Optional integration identifier                       |
| `IdempotencyKey`                                      | *string*                                              | :heavy_minus_sign:                                    | A header for idempotency purposes                     |