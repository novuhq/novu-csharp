# SubscribersPreferences

## Overview

### Available Operations

* [List](#list) - Retrieve subscriber preferences
* [Update](#update) - Update subscriber preferences

## List

Retrieve subscriber channel preferences by its unique key identifier **subscriberId**. 
    This API returns all five channels preferences for all workflows and global preferences.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_getSubscriberPreferences" method="get" path="/v2/subscribers/{subscriberId}/preferences" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.SubscribersPreferences.ListAsync(
    subscriberId: "<id>",
    criticality: Criticality.NonCritical,
    contextKeys: new List<string>() {
        "tenant:acme",
    }
);

// handle response
```

### Parameters

| Parameter                                                      | Type                                                           | Required                                                       | Description                                                    | Example                                                        |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `SubscriberId`                                                 | *string*                                                       | :heavy_check_mark:                                             | N/A                                                            |                                                                |
| `Criticality`                                                  | [Criticality](../../Models/Requests/Criticality.md)            | :heavy_minus_sign:                                             | N/A                                                            |                                                                |
| `ContextKeys`                                                  | List<*string*>                                                 | :heavy_minus_sign:                                             | Context keys for filtering preferences (e.g., ["tenant:acme"]) | [<br/>"tenant:acme"<br/>]                                      |
| `IdempotencyKey`                                               | *string*                                                       | :heavy_minus_sign:                                             | A header for idempotency purposes                              |                                                                |

### Response

**[SubscribersControllerGetSubscriberPreferencesResponse](../../Models/Requests/SubscribersControllerGetSubscriberPreferencesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Update

Update subscriber preferences by its unique key identifier **subscriberId**. 
    **workflowId** is optional field, if provided, this API will update that workflow preference, 
    otherwise it will update global preferences

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_updateSubscriberPreferences" method="patch" path="/v2/subscribers/{subscriberId}/preferences" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.SubscribersPreferences.UpdateAsync(
    subscriberId: "<id>",
    patchSubscriberPreferencesDto: new PatchSubscriberPreferencesDto() {
        Schedule = new ScheduleDto() {
            IsEnabled = true,
            WeeklySchedule = new WeeklySchedule() {
                Monday = new Monday() {
                    IsEnabled = true,
                    Hours = new List<TimeRangeDto>() {
                        new TimeRangeDto() {
                            Start = "09:00 AM",
                            End = "05:00 PM",
                        },
                    },
                },
                Tuesday = new Tuesday() {
                    IsEnabled = true,
                    Hours = new List<TimeRangeDto>() {
                        new TimeRangeDto() {
                            Start = "09:00 AM",
                            End = "05:00 PM",
                        },
                    },
                },
                Wednesday = new Wednesday() {
                    IsEnabled = true,
                    Hours = new List<TimeRangeDto>() {
                        new TimeRangeDto() {
                            Start = "09:00 AM",
                            End = "05:00 PM",
                        },
                    },
                },
                Thursday = new Thursday() {
                    IsEnabled = true,
                    Hours = new List<TimeRangeDto>() {
                        new TimeRangeDto() {
                            Start = "09:00 AM",
                            End = "05:00 PM",
                        },
                    },
                },
                Friday = new Friday() {
                    IsEnabled = true,
                    Hours = new List<TimeRangeDto>() {
                        new TimeRangeDto() {
                            Start = "09:00 AM",
                            End = "05:00 PM",
                        },
                    },
                },
                Saturday = new Saturday() {
                    IsEnabled = true,
                    Hours = new List<TimeRangeDto>() {
                        new TimeRangeDto() {
                            Start = "09:00 AM",
                            End = "05:00 PM",
                        },
                    },
                },
                Sunday = new Sunday() {
                    IsEnabled = true,
                    Hours = new List<TimeRangeDto>() {
                        new TimeRangeDto() {
                            Start = "09:00 AM",
                            End = "05:00 PM",
                        },
                    },
                },
            },
        },
        Context = new Dictionary<string, Context>() {
            { "key", Context.CreateStr(
                "org-acme"
            ) },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `SubscriberId`                                                                            | *string*                                                                                  | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `PatchSubscriberPreferencesDto`                                                           | [PatchSubscriberPreferencesDto](../../Models/Components/PatchSubscriberPreferencesDto.md) | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `IdempotencyKey`                                                                          | *string*                                                                                  | :heavy_minus_sign:                                                                        | A header for idempotency purposes                                                         |

### Response

**[SubscribersControllerUpdateSubscriberPreferencesResponse](../../Models/Requests/SubscribersControllerUpdateSubscriberPreferencesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |