# SubscriberChannelDto


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `ProviderId`                                                              | [ProviderId](../../Models/Components/ProviderId.md)                       | :heavy_check_mark:                                                        | The ID of the chat or push provider.                                      |
| `IntegrationIdentifier`                                                   | *string*                                                                  | :heavy_minus_sign:                                                        | An optional identifier for the integration.                               |
| `Credentials`                                                             | [ChannelCredentialsDto](../../Models/Components/ChannelCredentialsDto.md) | :heavy_check_mark:                                                        | Credentials for the channel.                                              |