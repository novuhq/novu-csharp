# Workflows.Steps

## Overview

### Available Operations

* [Retrieve](#retrieve) - Retrieve workflow step

## Retrieve

Retrieves data for a specific step in a workflow

### Example Usage

<!-- UsageSnippet language="csharp" operationID="WorkflowController_getWorkflowStepData" method="get" path="/v2/workflows/{workflowId}/steps/{stepId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Workflows.Steps.RetrieveAsync(
    workflowId: "<id>",
    stepId: "<id>"
);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `WorkflowId`                      | *string*                          | :heavy_check_mark:                | N/A                               |
| `StepId`                          | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[WorkflowControllerGetWorkflowStepDataResponse](../../Models/Requests/WorkflowControllerGetWorkflowStepDataResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |