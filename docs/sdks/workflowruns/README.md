# Activity.WorkflowRuns

## Overview

### Available Operations

* [List](#list) - List workflow runs
* [Retrieve](#retrieve) - Retrieve workflow run

## List

Retrieve a list of workflow runs with optional filtering and pagination.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ActivityController_getWorkflowRuns" method="get" path="/v1/activity/workflow-runs" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

ActivityControllerGetWorkflowRunsRequest req = new ActivityControllerGetWorkflowRunsRequest() {};

var res = await sdk.Activity.WorkflowRuns.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [ActivityControllerGetWorkflowRunsRequest](../../Models/Requests/ActivityControllerGetWorkflowRunsRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |

### Response

**[ActivityControllerGetWorkflowRunsResponse](../../Models/Requests/ActivityControllerGetWorkflowRunsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Retrieve

Retrieve detailed information for a specific workflow run by ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ActivityController_getWorkflowRun" method="get" path="/v1/activity/workflow-runs/{workflowRunId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Activity.WorkflowRuns.RetrieveAsync(workflowRunId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `WorkflowRunId`                   | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[ActivityControllerGetWorkflowRunResponse](../../Models/Requests/ActivityControllerGetWorkflowRunResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |