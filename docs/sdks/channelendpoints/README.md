# ChannelEndpoints

## Overview

### Available Operations

* [List](#list) - List all channel endpoints
* [Create](#create) - Create a channel endpoint
* [Retrieve](#retrieve) - Retrieve a channel endpoint
* [Update](#update) - Update a channel endpoint
* [Delete](#delete) - Delete a channel endpoint

## List

List all channel endpoints for a resource based on query filters.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ChannelEndpointsController_listChannelEndpoints" method="get" path="/v1/channel-endpoints" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

ChannelEndpointsControllerListChannelEndpointsRequest req = new ChannelEndpointsControllerListChannelEndpointsRequest() {
    Limit = 10D,
    SubscriberId = "subscriber-123",
    ContextKeys = new List<string>() {
        "tenant:org-123",
        "region:us-east-1",
    },
    ProviderId = ProvidersIdEnum.Slack,
    IntegrationIdentifier = "slack-prod",
    ConnectionIdentifier = "slack-connection-abc123",
};

var res = await sdk.ChannelEndpoints.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                               | Type                                                                                                                                    | Required                                                                                                                                | Description                                                                                                                             |
| --------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                               | [ChannelEndpointsControllerListChannelEndpointsRequest](../../Models/Requests/ChannelEndpointsControllerListChannelEndpointsRequest.md) | :heavy_check_mark:                                                                                                                      | The request object to use for the request.                                                                                              |

### Response

**[ChannelEndpointsControllerListChannelEndpointsResponse](../../Models/Requests/ChannelEndpointsControllerListChannelEndpointsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Create

Create a new channel endpoint for a resource.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ChannelEndpointsController_createChannelEndpoint" method="post" path="/v1/channel-endpoints" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.ChannelEndpoints.CreateAsync(requestBody: ChannelEndpointsControllerCreateChannelEndpointRequestBody.CreateSlackChannel(
    new CreateSlackChannelEndpointDto() {
        SubscriberId = "subscriber-123",
        IntegrationIdentifier = "slack-prod",
        Type = CreateSlackChannelEndpointDtoType.SlackChannel,
        Endpoint = new SlackChannelEndpointDto() {
            ChannelId = "C123456789",
        },
    }
));

// handle response
```

### Parameters

| Parameter                                                                                                                                         | Type                                                                                                                                              | Required                                                                                                                                          | Description                                                                                                                                       |
| ------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------- |
| `RequestBody`                                                                                                                                     | [ChannelEndpointsControllerCreateChannelEndpointRequestBody](../../Models/Requests/ChannelEndpointsControllerCreateChannelEndpointRequestBody.md) | :heavy_check_mark:                                                                                                                                | Channel endpoint creation request. The structure varies based on the type field.                                                                  |
| `IdempotencyKey`                                                                                                                                  | *string*                                                                                                                                          | :heavy_minus_sign:                                                                                                                                | A header for idempotency purposes                                                                                                                 |

### Response

**[ChannelEndpointsControllerCreateChannelEndpointResponse](../../Models/Requests/ChannelEndpointsControllerCreateChannelEndpointResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Retrieve

Retrieve a specific channel endpoint by its unique identifier.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ChannelEndpointsController_getChannelEndpoint" method="get" path="/v1/channel-endpoints/{identifier}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.ChannelEndpoints.RetrieveAsync(identifier: "<value>");

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `Identifier`                                  | *string*                                      | :heavy_check_mark:                            | The unique identifier of the channel endpoint |
| `IdempotencyKey`                              | *string*                                      | :heavy_minus_sign:                            | A header for idempotency purposes             |

### Response

**[ChannelEndpointsControllerGetChannelEndpointResponse](../../Models/Requests/ChannelEndpointsControllerGetChannelEndpointResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Update

Update an existing channel endpoint by its unique identifier.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ChannelEndpointsController_updateChannelEndpoint" method="patch" path="/v1/channel-endpoints/{identifier}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.ChannelEndpoints.UpdateAsync(
    identifier: "<value>",
    updateChannelEndpointRequestDto: new UpdateChannelEndpointRequestDto() {
        Endpoint = UpdateChannelEndpointRequestDtoEndpoint.CreateSlackUserEndpointDto(
            new SlackUserEndpointDto() {
                UserId = "U123456789",
            }
        ),
    }
);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `Identifier`                                                                                  | *string*                                                                                      | :heavy_check_mark:                                                                            | The unique identifier of the channel endpoint                                                 |
| `UpdateChannelEndpointRequestDto`                                                             | [UpdateChannelEndpointRequestDto](../../Models/Components/UpdateChannelEndpointRequestDto.md) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `IdempotencyKey`                                                                              | *string*                                                                                      | :heavy_minus_sign:                                                                            | A header for idempotency purposes                                                             |

### Response

**[ChannelEndpointsControllerUpdateChannelEndpointResponse](../../Models/Requests/ChannelEndpointsControllerUpdateChannelEndpointResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Delete a specific channel endpoint by its unique identifier.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ChannelEndpointsController_deleteChannelEndpoint" method="delete" path="/v1/channel-endpoints/{identifier}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.ChannelEndpoints.DeleteAsync(identifier: "<value>");

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `Identifier`                                  | *string*                                      | :heavy_check_mark:                            | The unique identifier of the channel endpoint |
| `IdempotencyKey`                              | *string*                                      | :heavy_minus_sign:                            | A header for idempotency purposes             |

### Response

**[ChannelEndpointsControllerDeleteChannelEndpointResponse](../../Models/Requests/ChannelEndpointsControllerDeleteChannelEndpointResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |