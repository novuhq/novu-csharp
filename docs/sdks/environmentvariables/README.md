# EnvironmentVariables

## Overview

### Available Operations

* [List](#list) - List environment variables
* [Create](#create) - Create environment variable
* [Retrieve](#retrieve) - Get environment variable
* [Update](#update) - Update environment variable
* [Delete](#delete) - Delete environment variable
* [Usage](#usage) - Get environment variable usage

## List

Returns all environment variables for the current organization. Secret values are masked.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="EnvironmentVariablesController_listEnvironmentVariables" method="get" path="/v1/environment-variables" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.EnvironmentVariables.ListAsync();

// handle response
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `Search`                                                 | *string*                                                 | :heavy_minus_sign:                                       | Filter variables by key (case-insensitive partial match) |
| `IdempotencyKey`                                         | *string*                                                 | :heavy_minus_sign:                                       | A header for idempotency purposes                        |

### Response

**[EnvironmentVariablesControllerListEnvironmentVariablesResponse](../../Models/Requests/EnvironmentVariablesControllerListEnvironmentVariablesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Create

Creates a new environment variable. Keys must be uppercase with underscores only (e.g. BASE_URL). Secret variables are encrypted at rest and masked in API responses.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="EnvironmentVariablesController_createEnvironmentVariable" method="post" path="/v1/environment-variables" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.EnvironmentVariables.CreateAsync(createEnvironmentVariableRequestDto: new CreateEnvironmentVariableRequestDto() {
    Key = "<key>",
});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `CreateEnvironmentVariableRequestDto`                                                                 | [CreateEnvironmentVariableRequestDto](../../Models/Components/CreateEnvironmentVariableRequestDto.md) | :heavy_check_mark:                                                                                    | N/A                                                                                                   |
| `IdempotencyKey`                                                                                      | *string*                                                                                              | :heavy_minus_sign:                                                                                    | A header for idempotency purposes                                                                     |

### Response

**[EnvironmentVariablesControllerCreateEnvironmentVariableResponse](../../Models/Requests/EnvironmentVariablesControllerCreateEnvironmentVariableResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 404, 405, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |

## Retrieve

Returns a single environment variable by id. Secret values are masked.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="EnvironmentVariablesController_getEnvironmentVariable" method="get" path="/v1/environment-variables/{variableId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.EnvironmentVariables.RetrieveAsync(variableId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `VariableId`                      | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[EnvironmentVariablesControllerGetEnvironmentVariableResponse](../../Models/Requests/EnvironmentVariablesControllerGetEnvironmentVariableResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 405, 409, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |

## Update

Updates an existing environment variable. Providing values replaces all existing per-environment values.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="EnvironmentVariablesController_updateEnvironmentVariable" method="patch" path="/v1/environment-variables/{variableId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.EnvironmentVariables.UpdateAsync(
    variableId: "<id>",
    updateEnvironmentVariableRequestDto: new UpdateEnvironmentVariableRequestDto() {}
);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `VariableId`                                                                                          | *string*                                                                                              | :heavy_check_mark:                                                                                    | N/A                                                                                                   |
| `UpdateEnvironmentVariableRequestDto`                                                                 | [UpdateEnvironmentVariableRequestDto](../../Models/Components/UpdateEnvironmentVariableRequestDto.md) | :heavy_check_mark:                                                                                    | N/A                                                                                                   |
| `IdempotencyKey`                                                                                      | *string*                                                                                              | :heavy_minus_sign:                                                                                    | A header for idempotency purposes                                                                     |

### Response

**[EnvironmentVariablesControllerUpdateEnvironmentVariableResponse](../../Models/Requests/EnvironmentVariablesControllerUpdateEnvironmentVariableResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 405, 409, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |

## Delete

Deletes an environment variable by id.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="EnvironmentVariablesController_deleteEnvironmentVariable" method="delete" path="/v1/environment-variables/{variableId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.EnvironmentVariables.DeleteAsync(variableId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `VariableId`                      | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[EnvironmentVariablesControllerDeleteEnvironmentVariableResponse](../../Models/Requests/EnvironmentVariablesControllerDeleteEnvironmentVariableResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 405, 409, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |

## Usage

Returns the workflows that reference this environment variable via {{env.KEY}} in their step controls.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="EnvironmentVariablesController_getEnvironmentVariableUsage" method="get" path="/v1/environment-variables/{variableId}/usage" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.EnvironmentVariables.UsageAsync(variableId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `VariableId`                      | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[EnvironmentVariablesControllerGetEnvironmentVariableUsageResponse](../../Models/Requests/EnvironmentVariablesControllerGetEnvironmentVariableUsageResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 405, 409, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |