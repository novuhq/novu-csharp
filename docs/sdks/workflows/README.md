# Workflows
(*Workflows*)

## Overview

All notifications are sent via a workflow. Each workflow acts as a container for the logic and blueprint that are associated with a type of notification in your system.
<https://docs.novu.co/workflows>

### Available Operations

* [Create](#create) - Create a workflow
* [List](#list) - List all workflows
* [Update](#update) - Update a workflow
* [Get](#get) - Retrieve a workflow
* [Delete](#delete) - Delete a workflow
* [Patch](#patch) - Update a workflow
* [Sync](#sync) - Sync a workflow

## Create

Creates a new workflow in the Novu Cloud environment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="WorkflowController_create" method="post" path="/v2/workflows" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Workflows.CreateAsync(createWorkflowDto: new CreateWorkflowDto() {
    Name = "<value>",
    WorkflowId = "<id>",
    Steps = new List<Novu.Models.Components.Steps>() {},
    Preferences = new PreferencesRequestDto() {
        User = User.CreateUserWorkflowPreferencesDto(
            new UserWorkflowPreferencesDto() {
                All = UserAll.CreateWorkflowPreferenceDto(
                    new WorkflowPreferenceDto() {}
                ),
                Channels = new Dictionary<string, ChannelPreferenceDto>() {
                    { "email", new ChannelPreferenceDto() {} },
                    { "sms", new ChannelPreferenceDto() {
                        Enabled = false,
                    } },
                },
            }
        ),
        Workflow = new PreferencesRequestDtoWorkflow() {
            All = PreferencesRequestDtoAll.CreateWorkflowPreferenceDto(
                new WorkflowPreferenceDto() {}
            ),
            Channels = new Dictionary<string, ChannelPreferenceDto>() {
                { "email", new ChannelPreferenceDto() {} },
                { "sms", new ChannelPreferenceDto() {
                    Enabled = false,
                } },
            },
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `CreateWorkflowDto`                                               | [CreateWorkflowDto](../../Models/Components/CreateWorkflowDto.md) | :heavy_check_mark:                                                | Workflow creation details                                         |
| `IdempotencyKey`                                                  | *string*                                                          | :heavy_minus_sign:                                                | A header for idempotency purposes                                 |

### Response

**[WorkflowControllerCreateResponse](../../Models/Requests/WorkflowControllerCreateResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## List

Retrieves a list of workflows with optional filtering and pagination

### Example Usage

<!-- UsageSnippet language="csharp" operationID="WorkflowController_searchWorkflows" method="get" path="/v2/workflows" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

WorkflowControllerSearchWorkflowsRequest? req = null;

var res = await sdk.Workflows.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [WorkflowControllerSearchWorkflowsRequest](../../Models/Requests/WorkflowControllerSearchWorkflowsRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |

### Response

**[WorkflowControllerSearchWorkflowsResponse](../../Models/Requests/WorkflowControllerSearchWorkflowsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Update

Updates the details of an existing workflow, here **workflowId** is the identifier of the workflow

### Example Usage

<!-- UsageSnippet language="csharp" operationID="WorkflowController_update" method="put" path="/v2/workflows/{workflowId}" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Workflows.UpdateAsync(
    workflowId: "<id>",
    updateWorkflowDto: new UpdateWorkflowDto() {
        Name = "<value>",
        Steps = new List<UpdateWorkflowDtoSteps>() {},
        Preferences = new PreferencesRequestDto() {
            User = User.CreateUserWorkflowPreferencesDto(
                new UserWorkflowPreferencesDto() {
                    All = UserAll.CreateWorkflowPreferenceDto(
                        new WorkflowPreferenceDto() {}
                    ),
                    Channels = new Dictionary<string, ChannelPreferenceDto>() {
                        { "email", new ChannelPreferenceDto() {} },
                        { "sms", new ChannelPreferenceDto() {
                            Enabled = false,
                        } },
                    },
                }
            ),
            Workflow = new PreferencesRequestDtoWorkflow() {
                All = PreferencesRequestDtoAll.CreateWorkflowPreferenceDto(
                    new WorkflowPreferenceDto() {}
                ),
                Channels = new Dictionary<string, ChannelPreferenceDto>() {
                    { "email", new ChannelPreferenceDto() {} },
                    { "sms", new ChannelPreferenceDto() {
                        Enabled = false,
                    } },
                },
            },
        },
        Origin = ResourceOriginEnum.External,
    }
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `WorkflowId`                                                      | *string*                                                          | :heavy_check_mark:                                                | N/A                                                               |
| `UpdateWorkflowDto`                                               | [UpdateWorkflowDto](../../Models/Components/UpdateWorkflowDto.md) | :heavy_check_mark:                                                | Workflow update details                                           |
| `IdempotencyKey`                                                  | *string*                                                          | :heavy_minus_sign:                                                | A header for idempotency purposes                                 |

### Response

**[WorkflowControllerUpdateResponse](../../Models/Requests/WorkflowControllerUpdateResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Get

Fetches details of a specific workflow by its unique identifier **workflowId**

### Example Usage

<!-- UsageSnippet language="csharp" operationID="WorkflowController_getWorkflow" method="get" path="/v2/workflows/{workflowId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Workflows.GetAsync(workflowId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `WorkflowId`                      | *string*                          | :heavy_check_mark:                | N/A                               |
| `EnvironmentId`                   | *string*                          | :heavy_minus_sign:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[WorkflowControllerGetWorkflowResponse](../../Models/Requests/WorkflowControllerGetWorkflowResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Removes a specific workflow by its unique identifier **workflowId**

### Example Usage

<!-- UsageSnippet language="csharp" operationID="WorkflowController_removeWorkflow" method="delete" path="/v2/workflows/{workflowId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Workflows.DeleteAsync(workflowId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `WorkflowId`                      | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[WorkflowControllerRemoveWorkflowResponse](../../Models/Requests/WorkflowControllerRemoveWorkflowResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Patch

Partially updates a workflow by its unique identifier **workflowId**

### Example Usage

<!-- UsageSnippet language="csharp" operationID="WorkflowController_patchWorkflow" method="patch" path="/v2/workflows/{workflowId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Workflows.PatchAsync(
    workflowId: "<id>",
    patchWorkflowDto: new PatchWorkflowDto() {}
);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `WorkflowId`                                                    | *string*                                                        | :heavy_check_mark:                                              | N/A                                                             |
| `PatchWorkflowDto`                                              | [PatchWorkflowDto](../../Models/Components/PatchWorkflowDto.md) | :heavy_check_mark:                                              | Workflow patch details                                          |
| `IdempotencyKey`                                                | *string*                                                        | :heavy_minus_sign:                                              | A header for idempotency purposes                               |

### Response

**[WorkflowControllerPatchWorkflowResponse](../../Models/Requests/WorkflowControllerPatchWorkflowResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Sync

Synchronizes a workflow to the target environment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="WorkflowController_sync" method="put" path="/v2/workflows/{workflowId}/sync" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Workflows.SyncAsync(
    workflowId: "<id>",
    syncWorkflowDto: new SyncWorkflowDto() {
        TargetEnvironmentId = "<id>",
    }
);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `WorkflowId`                                                  | *string*                                                      | :heavy_check_mark:                                            | N/A                                                           |
| `SyncWorkflowDto`                                             | [SyncWorkflowDto](../../Models/Components/SyncWorkflowDto.md) | :heavy_check_mark:                                            | Sync workflow details                                         |
| `IdempotencyKey`                                              | *string*                                                      | :heavy_minus_sign:                                            | A header for idempotency purposes                             |

### Response

**[WorkflowControllerSyncResponse](../../Models/Requests/WorkflowControllerSyncResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |