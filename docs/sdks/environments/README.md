# Environments

## Overview

Environments allow you to manage different stages of your application development lifecycle. Each environment has its own set of API keys and configurations, enabling you to separate development, staging, and production workflows.
<https://docs.novu.co/platform/environments>

### Available Operations

* [GetTags](#gettags) - Get environment tags
* [Create](#create) - Create an environment
* [List](#list) - List all environments
* [Update](#update) - Update an environment
* [Delete](#delete) - Delete an environment

## GetTags

Retrieve all unique tags used in workflows within the specified environment. These tags can be used for filtering workflows.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="EnvironmentsController_getEnvironmentTags" method="get" path="/v2/environments/{environmentId}/tags" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Environments.GetTagsAsync(environmentId: "6615943e7ace93b0540ae377");

// handle response
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `EnvironmentId`                                          | *string*                                                 | :heavy_check_mark:                                       | Environment internal ID (MongoDB ObjectId) or identifier | 6615943e7ace93b0540ae377                                 |
| `IdempotencyKey`                                         | *string*                                                 | :heavy_minus_sign:                                       | A header for idempotency purposes                        |                                                          |

### Response

**[EnvironmentsControllerGetEnvironmentTagsResponse](../../Models/Requests/EnvironmentsControllerGetEnvironmentTagsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Create

Creates a new environment within the current organization. 
    Environments allow you to manage different stages of your application development lifecycle.
    Each environment has its own set of API keys and configurations.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="EnvironmentsControllerV1_createEnvironment" method="post" path="/v1/environments" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Environments.CreateAsync(createEnvironmentRequestDto: new CreateEnvironmentRequestDto() {
    Name = "Production Environment",
    ParentId = "60d5ecb8b3b3a30015f3e1a1",
    Color = "#3498db",
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `CreateEnvironmentRequestDto`                                                         | [CreateEnvironmentRequestDto](../../Models/Components/CreateEnvironmentRequestDto.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `IdempotencyKey`                                                                      | *string*                                                                              | :heavy_minus_sign:                                                                    | A header for idempotency purposes                                                     |

### Response

**[EnvironmentsControllerV1CreateEnvironmentResponse](../../Models/Requests/EnvironmentsControllerV1CreateEnvironmentResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 402, 414                               | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## List

This API returns a list of environments for the current organization. 
    Each environment contains its configuration, API keys (if user has access), and metadata.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="EnvironmentsControllerV1_listMyEnvironments" method="get" path="/v1/environments" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Environments.ListAsync();

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[EnvironmentsControllerV1ListMyEnvironmentsResponse](../../Models/Requests/EnvironmentsControllerV1ListMyEnvironmentsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Update

Update an environment by its unique identifier **environmentId**. 
    You can modify the environment name, identifier, color, and other configuration settings.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="EnvironmentsControllerV1_updateMyEnvironment" method="put" path="/v1/environments/{environmentId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Environments.UpdateAsync(
    environmentId: "<id>",
    updateEnvironmentRequestDto: new UpdateEnvironmentRequestDto() {}
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `EnvironmentId`                                                                       | *string*                                                                              | :heavy_check_mark:                                                                    | The unique identifier of the environment                                              |
| `UpdateEnvironmentRequestDto`                                                         | [UpdateEnvironmentRequestDto](../../Models/Components/UpdateEnvironmentRequestDto.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `IdempotencyKey`                                                                      | *string*                                                                              | :heavy_minus_sign:                                                                    | A header for idempotency purposes                                                     |

### Response

**[EnvironmentsControllerV1UpdateMyEnvironmentResponse](../../Models/Requests/EnvironmentsControllerV1UpdateMyEnvironmentResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Delete an environment by its unique identifier **environmentId**. 
    This action is irreversible and will remove the environment and all its associated data.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="EnvironmentsControllerV1_deleteEnvironment" method="delete" path="/v1/environments/{environmentId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Environments.DeleteAsync(environmentId: "<id>");

// handle response
```

### Parameters

| Parameter                                | Type                                     | Required                                 | Description                              |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| `EnvironmentId`                          | *string*                                 | :heavy_check_mark:                       | The unique identifier of the environment |
| `IdempotencyKey`                         | *string*                                 | :heavy_minus_sign:                       | A header for idempotency purposes        |

### Response

**[EnvironmentsControllerV1DeleteEnvironmentResponse](../../Models/Requests/EnvironmentsControllerV1DeleteEnvironmentResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |