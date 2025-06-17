# SubscribersPreferences
(*SubscribersPreferences*)

## Overview

### Available Operations

* [List](#list) - Retrieve subscriber preferences
* [Update](#update) - Update subscriber preferences

## List

Retrieve subscriber channel preferences by its unique key identifier **subscriberId**. 
    This API returns all five channels preferences for all workflows and global preferences.

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.SubscribersPreferences.ListAsync(subscriberId: "<id>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `SubscriberId`                    | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

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

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.SubscribersPreferences.UpdateAsync(
    subscriberId: "<id>",
    patchSubscriberPreferencesDto: new PatchSubscriberPreferencesDto() {
        Channels = new PatchPreferenceChannelsDto() {},
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