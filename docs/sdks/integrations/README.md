# Integrations

## Overview

With the help of the Integration Store, you can easily integrate your favorite delivery provider. During the runtime of the API, the Integrations Store is responsible for storing the configurations of all the providers.
<https://docs.novu.co/platform/integrations/overview>

### Available Operations

* [GetAll](#getall) - List all integrations
* [Create](#create) - Create an integration
* [Update](#update) - Update an integration
* [Delete](#delete) - Delete an integration
* [IntegrationsControllerAutoConfigureIntegration](#integrationscontrollerautoconfigureintegration) - Auto-configure an integration for inbound webhooks
* [SetPrimary](#setprimary) - Update integration as primary
* [CreateMobileLink](#createmobilelink) - Issue a short-lived mobile setup link for an existing integration
* [IntegrationsControllerConfigureIntegrationWebhook](#integrationscontrollerconfigureintegrationwebhook) - Configure a chat integration webhook
* [ListActive](#listactive) - List active integrations
* [GenerateConnectOAuthUrl](#generateconnectoauthurl) - Generate OAuth URL for a workspace/tenant connection
* [LinkChannelEndpoint](#linkchannelendpoint) - Issue a URL to link a subscriber chat identity
* [GenerateLinkUserOAuthUrl](#generatelinkuseroauthurl) - Generate OAuth URL to link a subscriber user identity
* [~~GenerateChatOAuthUrl~~](#generatechatoauthurl) - Generate chat OAuth URL :warning: **Deprecated**

## GetAll

List all the channels integrations created in the organization. Only integration metadata is returned, credentials field is returned as an empty object.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="IntegrationsController_listIntegrations" method="get" path="/v1/integrations" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Integrations.GetAllAsync();

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[IntegrationsControllerListIntegrationsResponse](../../Models/Requests/IntegrationsControllerListIntegrationsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Create

Create an integration for the current environment the user is based on the API key provided. 
    Each provider supports different credentials, check the provider documentation for more details. Only integration metadata is returned, credentials field is returned as an empty object.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="IntegrationsController_createIntegration" method="post" path="/v1/integrations" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Integrations.CreateAsync(createIntegrationRequestDto: new CreateIntegrationRequestDto() {});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `CreateIntegrationRequestDto`                                                         | [CreateIntegrationRequestDto](../../Models/Components/CreateIntegrationRequestDto.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `IdempotencyKey`                                                                      | *string*                                                                              | :heavy_minus_sign:                                                                    | A header for idempotency purposes                                                     |

### Response

**[IntegrationsControllerCreateIntegrationResponse](../../Models/Requests/IntegrationsControllerCreateIntegrationResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Update

Update an integration by its unique key identifier **integrationId**. 
    Each provider supports different credentials, check the provider documentation for more details. Only integration metadata is returned, credentials field is returned as an empty object.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="IntegrationsController_updateIntegrationById" method="put" path="/v1/integrations/{integrationId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Integrations.UpdateAsync(
    integrationId: "<id>",
    updateIntegrationRequestDto: new UpdateIntegrationRequestDto() {}
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `IntegrationId`                                                                       | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `UpdateIntegrationRequestDto`                                                         | [UpdateIntegrationRequestDto](../../Models/Components/UpdateIntegrationRequestDto.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `IdempotencyKey`                                                                      | *string*                                                                              | :heavy_minus_sign:                                                                    | A header for idempotency purposes                                                     |

### Response

**[IntegrationsControllerUpdateIntegrationByIdResponse](../../Models/Requests/IntegrationsControllerUpdateIntegrationByIdResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 405, 409, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |

## Delete

Delete an integration by its unique key identifier **integrationId**. 
    This action is irreversible. Only integration metadata is returned, credentials field is returned as empty object.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="IntegrationsController_removeIntegration" method="delete" path="/v1/integrations/{integrationId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Integrations.DeleteAsync(integrationId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `IntegrationId`                   | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[IntegrationsControllerRemoveIntegrationResponse](../../Models/Requests/IntegrationsControllerRemoveIntegrationResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## IntegrationsControllerAutoConfigureIntegration

Auto-configure an integration by its unique key identifier **integrationId** for inbound webhook support. 
    This will automatically generate required webhook signing keys and configure webhook endpoints. Only integration metadata is returned, credentials field is returned as an empty object.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="IntegrationsController_autoConfigureIntegration" method="post" path="/v1/integrations/{integrationId}/auto-configure" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Integrations.IntegrationsControllerAutoConfigureIntegrationAsync(integrationId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `IntegrationId`                   | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[IntegrationsControllerAutoConfigureIntegrationResponse](../../Models/Requests/IntegrationsControllerAutoConfigureIntegrationResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 405, 409, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |

## SetPrimary

Update an integration as **primary** by its unique key identifier **integrationId**. 
    This API will set the integration as primary for that channel in the current environment. 
    Primary integration is used to deliver notification for sms and email channels in the workflow. 
    Only integration metadata is returned, credentials field is returned as an empty object.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="IntegrationsController_setIntegrationAsPrimary" method="post" path="/v1/integrations/{integrationId}/set-primary" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Integrations.SetPrimaryAsync(integrationId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `IntegrationId`                   | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[IntegrationsControllerSetIntegrationAsPrimaryResponse](../../Models/Requests/IntegrationsControllerSetIntegrationAsPrimaryResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 405, 409, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |

## CreateMobileLink

Returns an opaque, single-use setup token plus a mobile URL for configuring an existing chat integration. Telegram is the only supported provider initially.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="IntegrationsController_createIntegrationMobileLink" method="post" path="/v1/integrations/{integrationIdentifier}/mobile-link" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Integrations.CreateMobileLinkAsync(
    integrationIdentifier: "<value>",
    issueIntegrationMobileLinkRequestDto: new IssueIntegrationMobileLinkRequestDto() {
        SubscriberId = "subscriber-123",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `IntegrationIdentifier`                                                                                 | *string*                                                                                                | :heavy_check_mark:                                                                                      | N/A                                                                                                     |
| `IssueIntegrationMobileLinkRequestDto`                                                                  | [IssueIntegrationMobileLinkRequestDto](../../Models/Components/IssueIntegrationMobileLinkRequestDto.md) | :heavy_check_mark:                                                                                      | N/A                                                                                                     |
| `IdempotencyKey`                                                                                        | *string*                                                                                                | :heavy_minus_sign:                                                                                      | A header for idempotency purposes                                                                       |

### Response

**[IntegrationsControllerCreateIntegrationMobileLinkResponse](../../Models/Requests/IntegrationsControllerCreateIntegrationMobileLinkResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## IntegrationsControllerConfigureIntegrationWebhook

Registers the Novu webhook URL with the chat provider for the specified integration. Telegram is the only supported provider initially.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="IntegrationsController_configureIntegrationWebhook" method="post" path="/v1/integrations/{integrationIdentifier}/webhook/configure" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Integrations.IntegrationsControllerConfigureIntegrationWebhookAsync(integrationIdentifier: "<value>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `IntegrationIdentifier`           | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[IntegrationsControllerConfigureIntegrationWebhookResponse](../../Models/Requests/IntegrationsControllerConfigureIntegrationWebhookResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## ListActive

List all the active integrations created in the organization. Only integration metadata is returned, credentials field is returned as an empty object.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="IntegrationsController_getActiveIntegrations" method="get" path="/v1/integrations/active" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Integrations.ListActiveAsync();

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[IntegrationsControllerGetActiveIntegrationsResponse](../../Models/Requests/IntegrationsControllerGetActiveIntegrationsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## GenerateConnectOAuthUrl

Generate an OAuth URL that creates a workspace or tenant-level channel connection (Slack workspace install or MS Teams admin consent). 
    The generated URL expires after 5 minutes.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="IntegrationsController_generateConnectOAuthUrl" method="post" path="/v1/integrations/channel-connections/oauth" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Integrations.GenerateConnectOAuthUrlAsync(generateConnectOauthUrlRequestDto: new GenerateConnectOauthUrlRequestDto() {
    SubscriberId = "subscriber-123",
    IntegrationIdentifier = "<value>",
    ConnectionIdentifier = "slack-connection-abc123",
    Context = new Dictionary<string, GenerateConnectOauthUrlRequestDtoContext>() {
        { "key", GenerateConnectOauthUrlRequestDtoContext.CreateStr(
            "org-acme"
        ) },
    },
    Scope = new List<string>() {
        "chat:write",
        "chat:write.public",
        "channels:read",
    },
    ConnectionMode = GenerateConnectOauthUrlRequestDtoConnectionMode.Shared,
    AutoLinkUser = true,
});

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `GenerateConnectOauthUrlRequestDto`                                                               | [GenerateConnectOauthUrlRequestDto](../../Models/Components/GenerateConnectOauthUrlRequestDto.md) | :heavy_check_mark:                                                                                | N/A                                                                                               |
| `IdempotencyKey`                                                                                  | *string*                                                                                          | :heavy_minus_sign:                                                                                | A header for idempotency purposes                                                                 |

### Response

**[IntegrationsControllerGenerateConnectOAuthUrlResponse](../../Models/Requests/IntegrationsControllerGenerateConnectOAuthUrlResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## LinkChannelEndpoint

Returns a provider-specific URL the subscriber opens to link their chat identity. The integration provider is resolved from integrationIdentifier; Telegram returns a deep link.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="IntegrationsController_linkChannelEndpoint" method="post" path="/v1/integrations/channel-endpoints/link" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Integrations.LinkChannelEndpointAsync(linkChannelEndpointRequestDto: new LinkChannelEndpointRequestDto() {
    IntegrationIdentifier = "telegram-bot",
    SubscriberId = "subscriber-123",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `LinkChannelEndpointRequestDto`                                                           | [LinkChannelEndpointRequestDto](../../Models/Components/LinkChannelEndpointRequestDto.md) | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `IdempotencyKey`                                                                          | *string*                                                                                  | :heavy_minus_sign:                                                                        | A header for idempotency purposes                                                         |

### Response

**[IntegrationsControllerLinkChannelEndpointResponse](../../Models/Requests/IntegrationsControllerLinkChannelEndpointResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## GenerateLinkUserOAuthUrl

Generate an OAuth URL that links a specific subscriber to their chat identity (Slack user ID or MS Teams user OID). 
    The generated URL expires after 5 minutes.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="IntegrationsController_generateLinkUserOAuthUrl" method="post" path="/v1/integrations/channel-endpoints/oauth" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Integrations.GenerateLinkUserOAuthUrlAsync(generateLinkUserOauthUrlRequestDto: new GenerateLinkUserOauthUrlRequestDto() {
    SubscriberId = "subscriber-123",
    IntegrationIdentifier = "<value>",
    ConnectionIdentifier = "slack-connection-abc123",
    Context = new Dictionary<string, GenerateLinkUserOauthUrlRequestDtoContext>() {
        { "key", GenerateLinkUserOauthUrlRequestDtoContext.CreateStr(
            "org-acme"
        ) },
    },
    UserScope = new List<string>() {
        "identity.basic",
    },
});

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `GenerateLinkUserOauthUrlRequestDto`                                                                | [GenerateLinkUserOauthUrlRequestDto](../../Models/Components/GenerateLinkUserOauthUrlRequestDto.md) | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `IdempotencyKey`                                                                                    | *string*                                                                                            | :heavy_minus_sign:                                                                                  | A header for idempotency purposes                                                                   |

### Response

**[IntegrationsControllerGenerateLinkUserOAuthUrlResponse](../../Models/Requests/IntegrationsControllerGenerateLinkUserOAuthUrlResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## ~~GenerateChatOAuthUrl~~

**Deprecated** — use `POST /integrations/channel-connections/oauth` (connect) or `POST /integrations/channel-endpoints/oauth` (link_user) instead.
    Generate an OAuth URL for chat integrations like Slack and MS Teams. 
    This URL allows subscribers to authorize the integration, enabling the system to send messages 
    through their chat workspace. The generated URL expires after 5 minutes.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="IntegrationsController_getChatOAuthUrl" method="post" path="/v1/integrations/chat/oauth" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Integrations.GenerateChatOAuthUrlAsync(generateChatOauthUrlRequestDto: new GenerateChatOauthUrlRequestDto() {
    SubscriberId = "subscriber-123",
    IntegrationIdentifier = "<value>",
    ConnectionIdentifier = "slack-connection-abc123",
    Context = new Dictionary<string, GenerateChatOauthUrlRequestDtoContext>() {
        { "key", GenerateChatOauthUrlRequestDtoContext.CreateStr(
            "org-acme"
        ) },
    },
    Scope = new List<string>() {
        "chat:write",
        "chat:write.public",
        "channels:read",
        "groups:read",
        "users:read",
        "users:read.email",
        "incoming-webhook",
    },
    UserScope = new List<string>() {
        "identity.basic",
    },
    Mode = Mode.LinkUser,
    ConnectionMode = GenerateChatOauthUrlRequestDtoConnectionMode.Shared,
    AutoLinkUser = true,
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `GenerateChatOauthUrlRequestDto`                                                            | [GenerateChatOauthUrlRequestDto](../../Models/Components/GenerateChatOauthUrlRequestDto.md) | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `IdempotencyKey`                                                                            | *string*                                                                                    | :heavy_minus_sign:                                                                          | A header for idempotency purposes                                                           |

### Response

**[IntegrationsControllerGetChatOAuthUrlResponse](../../Models/Requests/IntegrationsControllerGetChatOAuthUrlResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |