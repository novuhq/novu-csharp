# ChannelConnections

## Overview

### Available Operations

* [List](#list) - List all channel connections
* [Create](#create) - Create a channel connection
* [Retrieve](#retrieve) - Retrieve a channel connection
* [Update](#update) - Update a channel connection
* [Delete](#delete) - Delete a channel connection

## List

List all channel connections for a resource.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ChannelConnectionsController_listChannelConnections" method="get" path="/v1/channel-connections" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

ChannelConnectionsControllerListChannelConnectionsRequest req = new ChannelConnectionsControllerListChannelConnectionsRequest() {
    Limit = 10D,
    SubscriberId = "subscriber-123",
    Channel = Novu.Models.Requests.Channel.Chat,
    ProviderId = ProvidersIdEnum.Slack,
    IntegrationIdentifier = "slack-prod",
    ContextKeys = new List<string>() {
        "tenant:org-123",
        "region:us-east-1",
    },
};

var res = await sdk.ChannelConnections.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                                       | Type                                                                                                                                            | Required                                                                                                                                        | Description                                                                                                                                     |
| ----------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                                       | [ChannelConnectionsControllerListChannelConnectionsRequest](../../Models/Requests/ChannelConnectionsControllerListChannelConnectionsRequest.md) | :heavy_check_mark:                                                                                                                              | The request object to use for the request.                                                                                                      |

### Response

**[ChannelConnectionsControllerListChannelConnectionsResponse](../../Models/Requests/ChannelConnectionsControllerListChannelConnectionsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Create

Create a new channel connection for a resource for given integration. Only one channel connection is allowed per resource and integration.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ChannelConnectionsController_createChannelConnection" method="post" path="/v1/channel-connections" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.ChannelConnections.CreateAsync(createChannelConnectionRequestDto: new CreateChannelConnectionRequestDto() {
    Identifier = "slack-prod-user123-abc4",
    SubscriberId = "subscriber-123",
    Context = new Dictionary<string, CreateChannelConnectionRequestDtoContext>() {
        { "key", CreateChannelConnectionRequestDtoContext.CreateStr(
            "org-acme"
        ) },
    },
    IntegrationIdentifier = "slack-prod",
    Workspace = new WorkspaceDto() {
        Id = "T123456",
        Name = "Acme HQ",
    },
    Auth = new AuthDto() {
        AccessToken = "Workspace access token",
    },
});

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `CreateChannelConnectionRequestDto`                                                               | [CreateChannelConnectionRequestDto](../../Models/Components/CreateChannelConnectionRequestDto.md) | :heavy_check_mark:                                                                                | N/A                                                                                               |
| `IdempotencyKey`                                                                                  | *string*                                                                                          | :heavy_minus_sign:                                                                                | A header for idempotency purposes                                                                 |

### Response

**[ChannelConnectionsControllerCreateChannelConnectionResponse](../../Models/Requests/ChannelConnectionsControllerCreateChannelConnectionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Retrieve

Retrieve a specific channel connection by its unique identifier.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ChannelConnectionsController_getChannelConnectionByIdentifier" method="get" path="/v1/channel-connections/{identifier}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.ChannelConnections.RetrieveAsync(identifier: "<value>");

// handle response
```

### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `Identifier`                                    | *string*                                        | :heavy_check_mark:                              | The unique identifier of the channel connection |
| `IdempotencyKey`                                | *string*                                        | :heavy_minus_sign:                              | A header for idempotency purposes               |

### Response

**[ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse](../../Models/Requests/ChannelConnectionsControllerGetChannelConnectionByIdentifierResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Update

Update an existing channel connection by its unique identifier.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ChannelConnectionsController_updateChannelConnection" method="patch" path="/v1/channel-connections/{identifier}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.ChannelConnections.UpdateAsync(
    identifier: "<value>",
    updateChannelConnectionRequestDto: new UpdateChannelConnectionRequestDto() {
        Workspace = new WorkspaceDto() {
            Id = "T123456",
            Name = "Acme HQ",
        },
        Auth = new AuthDto() {
            AccessToken = "Workspace access token",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `Identifier`                                                                                      | *string*                                                                                          | :heavy_check_mark:                                                                                | The unique identifier of the channel connection                                                   |
| `UpdateChannelConnectionRequestDto`                                                               | [UpdateChannelConnectionRequestDto](../../Models/Components/UpdateChannelConnectionRequestDto.md) | :heavy_check_mark:                                                                                | N/A                                                                                               |
| `IdempotencyKey`                                                                                  | *string*                                                                                          | :heavy_minus_sign:                                                                                | A header for idempotency purposes                                                                 |

### Response

**[ChannelConnectionsControllerUpdateChannelConnectionResponse](../../Models/Requests/ChannelConnectionsControllerUpdateChannelConnectionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Delete a specific channel connection by its unique identifier.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ChannelConnectionsController_deleteChannelConnection" method="delete" path="/v1/channel-connections/{identifier}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.ChannelConnections.DeleteAsync(identifier: "<value>");

// handle response
```

### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `Identifier`                                    | *string*                                        | :heavy_check_mark:                              | The unique identifier of the channel connection |
| `IdempotencyKey`                                | *string*                                        | :heavy_minus_sign:                              | A header for idempotency purposes               |

### Response

**[ChannelConnectionsControllerDeleteChannelConnectionResponse](../../Models/Requests/ChannelConnectionsControllerDeleteChannelConnectionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |