# Contexts
(*Contexts*)

## Overview

### Available Operations

* [Create](#create) - Create a context
* [List](#list) - List all contexts
* [Update](#update) - Update a context
* [Retrieve](#retrieve) - Retrieve a context
* [Delete](#delete) - Delete a context

## Create

Create a new context with the specified type, id, and data. Returns 409 if context already exists.


      **type** and **id** are required fields, **data** is optional, if the context already exists, it returns the 409 response

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ContextsController_createContext" method="post" path="/v2/contexts" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Contexts.CreateAsync(createContextRequestDto: new CreateContextRequestDto() {
    Type = "tenant",
    Id = "org-acme",
    Data = new Data() {},
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `CreateContextRequestDto`                                                     | [CreateContextRequestDto](../../Models/Components/CreateContextRequestDto.md) | :heavy_check_mark:                                                            | N/A                                                                           |
| `IdempotencyKey`                                                              | *string*                                                                      | :heavy_minus_sign:                                                            | A header for idempotency purposes                                             |

### Response

**[ContextsControllerCreateContextResponse](../../Models/Requests/ContextsControllerCreateContextResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## List

Retrieve a paginated list of all contexts, optionally filtered by type and key pattern.


      **type** and **id** are optional fields, if provided, only contexts with the matching type and id will be returned.
      **search** is an optional field, if provided, only contexts with the matching key pattern will be returned.
      Checkout all possible parameters in the query section below for more details

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ContextsController_listContexts" method="get" path="/v2/contexts" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

ContextsControllerListContextsRequest req = new ContextsControllerListContextsRequest() {
    Id = "tenant-prod-123",
    Search = "tenant",
};

var res = await sdk.Contexts.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [ContextsControllerListContextsRequest](../../Models/Requests/ContextsControllerListContextsRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[ContextsControllerListContextsResponse](../../Models/Requests/ContextsControllerListContextsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Update

Update the data of an existing context.
      **type** and **id** are required fields, **data** is required. Only the data field is updated, the rest of the context is not affected.
      If the context does not exist, it returns the 404 response

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ContextsController_updateContext" method="patch" path="/v2/contexts/{type}/{id}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Contexts.UpdateAsync(
    id: "<id>",
    type: "<value>",
    updateContextRequestDto: new UpdateContextRequestDto() {
        Data = new UpdateContextRequestDtoData() {},
    }
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Id`                                                                          | *string*                                                                      | :heavy_check_mark:                                                            | Context ID                                                                    |
| `Type`                                                                        | *string*                                                                      | :heavy_check_mark:                                                            | Context type                                                                  |
| `UpdateContextRequestDto`                                                     | [UpdateContextRequestDto](../../Models/Components/UpdateContextRequestDto.md) | :heavy_check_mark:                                                            | N/A                                                                           |
| `IdempotencyKey`                                                              | *string*                                                                      | :heavy_minus_sign:                                                            | A header for idempotency purposes                                             |

### Response

**[ContextsControllerUpdateContextResponse](../../Models/Requests/ContextsControllerUpdateContextResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Retrieve

Retrieve a specific context by its type and id.
      **type** and **id** are required fields, if the context does not exist, it returns the 404 response

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ContextsController_getContext" method="get" path="/v2/contexts/{type}/{id}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Contexts.RetrieveAsync(
    id: "<id>",
    type: "<value>"
);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Id`                              | *string*                          | :heavy_check_mark:                | Context ID                        |
| `Type`                            | *string*                          | :heavy_check_mark:                | Context type                      |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[ContextsControllerGetContextResponse](../../Models/Requests/ContextsControllerGetContextResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Delete a context by its type and id.
      **type** and **id** are required fields, if the context does not exist, it returns the 404 response

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ContextsController_deleteContext" method="delete" path="/v2/contexts/{type}/{id}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Contexts.DeleteAsync(
    id: "<id>",
    type: "<value>"
);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Id`                              | *string*                          | :heavy_check_mark:                | Context ID                        |
| `Type`                            | *string*                          | :heavy_check_mark:                | Context type                      |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[ContextsControllerDeleteContextResponse](../../Models/Requests/ContextsControllerDeleteContextResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |