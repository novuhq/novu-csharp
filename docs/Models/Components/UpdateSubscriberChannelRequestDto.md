# UpdateSubscriberChannelRequestDto


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `ProviderId`                                                                | [ChatOrPushProviderEnum](../../Models/Components/ChatOrPushProviderEnum.md) | :heavy_check_mark:                                                          | The provider identifier for the credentials                                 |
| `IntegrationIdentifier`                                                     | *string*                                                                    | :heavy_minus_sign:                                                          | The integration identifier                                                  |
| `Credentials`                                                               | [ChannelCredentials](../../Models/Components/ChannelCredentials.md)         | :heavy_check_mark:                                                          | Credentials payload for the specified provider                              |