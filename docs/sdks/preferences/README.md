# Subscribers.Preferences

## Overview

### Available Operations

* [BulkUpdate](#bulkupdate) - Bulk update subscriber preferences

## BulkUpdate

Bulk update subscriber preferences by its unique key identifier **subscriberId**. 
    This API allows updating multiple workflow preferences in a single request.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_bulkUpdateSubscriberPreferences" method="patch" path="/v2/subscribers/{subscriberId}/preferences/bulk" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Preferences.BulkUpdateAsync(
    subscriberId: "<id>",
    bulkUpdateSubscriberPreferencesDto: new BulkUpdateSubscriberPreferencesDto() {
        Preferences = new List<BulkUpdateSubscriberPreferenceItemDto>() {},
        Context = new Dictionary<string, BulkUpdateSubscriberPreferencesDtoContext>() {
            { "key", BulkUpdateSubscriberPreferencesDtoContext.CreateStr(
                "org-acme"
            ) },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `SubscriberId`                                                                                      | *string*                                                                                            | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `BulkUpdateSubscriberPreferencesDto`                                                                | [BulkUpdateSubscriberPreferencesDto](../../Models/Components/BulkUpdateSubscriberPreferencesDto.md) | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `IdempotencyKey`                                                                                    | *string*                                                                                            | :heavy_minus_sign:                                                                                  | A header for idempotency purposes                                                                   |

### Response

**[SubscribersControllerBulkUpdateSubscriberPreferencesResponse](../../Models/Requests/SubscribersControllerBulkUpdateSubscriberPreferencesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |