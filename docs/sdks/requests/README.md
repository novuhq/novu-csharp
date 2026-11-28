# Activity.Requests

## Overview

### Available Operations

* [List](#list) - List activity requests
* [Retrieve](#retrieve) - Retrieve activity request

## List

Retrieve a list of activity requests with optional filtering and pagination.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ActivityController_getLogs" method="get" path="/v1/activity/requests" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

ActivityControllerGetLogsRequest req = new ActivityControllerGetLogsRequest() {
    StatusCodes = new List<double>() {
        200D,
        404D,
        500D,
    },
    CreatedGte = 1640995200D,
};

var res = await sdk.Activity.Requests.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [ActivityControllerGetLogsRequest](../../Models/Requests/ActivityControllerGetLogsRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[ActivityControllerGetLogsResponse](../../Models/Requests/ActivityControllerGetLogsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Retrieve

Retrieve detailed traces and information for a specific activity request by ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ActivityController_getRequestTraces" method="get" path="/v1/activity/requests/{requestId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Activity.Requests.RetrieveAsync(requestId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `RequestId`                       | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[ActivityControllerGetRequestTracesResponse](../../Models/Requests/ActivityControllerGetRequestTracesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |