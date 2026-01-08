# Translations.Groups

## Overview

### Available Operations

* [Delete](#delete) - Delete a translation group
* [Retrieve](#retrieve) - Retrieve a translation group

## Delete

Delete an entire translation group and all its translations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TranslationController_deleteTranslationGroupEndpoint" method="delete" path="/v2/translations/{resourceType}/{resourceId}" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Translations.Groups.DeleteAsync(
    resourceType: TranslationControllerDeleteTranslationGroupEndpointPathParamResourceType.Workflow,
    resourceId: "welcome-email"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                     | Type                                                                                                                                                                          | Required                                                                                                                                                                      | Description                                                                                                                                                                   | Example                                                                                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ResourceType`                                                                                                                                                                | [TranslationControllerDeleteTranslationGroupEndpointPathParamResourceType](../../Models/Requests/TranslationControllerDeleteTranslationGroupEndpointPathParamResourceType.md) | :heavy_check_mark:                                                                                                                                                            | Resource type                                                                                                                                                                 | workflow                                                                                                                                                                      |
| `ResourceId`                                                                                                                                                                  | *string*                                                                                                                                                                      | :heavy_check_mark:                                                                                                                                                            | Resource ID                                                                                                                                                                   | welcome-email                                                                                                                                                                 |
| `IdempotencyKey`                                                                                                                                                              | *string*                                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                                            | A header for idempotency purposes                                                                                                                                             |                                                                                                                                                                               |

### Response

**[TranslationControllerDeleteTranslationGroupEndpointResponse](../../Models/Requests/TranslationControllerDeleteTranslationGroupEndpointResponse.md)**

### Errors

| Error Type                      | Status Code                     | Content Type                    |
| ------------------------------- | ------------------------------- | ------------------------------- |
| Novu.Models.Errors.APIException | 4XX, 5XX                        | \*/\*                           |

## Retrieve

Retrieves a single translation group by resource type (workflow, layout) and resource ID (workflowId, layoutId)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TranslationController_getTranslationGroupEndpoint" method="get" path="/v2/translations/group/{resourceType}/{resourceId}" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Translations.Groups.RetrieveAsync(
    resourceType: TranslationControllerGetTranslationGroupEndpointPathParamResourceType.Workflow,
    resourceId: "welcome-email"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                               | Type                                                                                                                                                                    | Required                                                                                                                                                                | Description                                                                                                                                                             | Example                                                                                                                                                                 |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ResourceType`                                                                                                                                                          | [TranslationControllerGetTranslationGroupEndpointPathParamResourceType](../../Models/Requests/TranslationControllerGetTranslationGroupEndpointPathParamResourceType.md) | :heavy_check_mark:                                                                                                                                                      | Resource type                                                                                                                                                           | workflow                                                                                                                                                                |
| `ResourceId`                                                                                                                                                            | *string*                                                                                                                                                                | :heavy_check_mark:                                                                                                                                                      | Resource ID                                                                                                                                                             | welcome-email                                                                                                                                                           |
| `IdempotencyKey`                                                                                                                                                        | *string*                                                                                                                                                                | :heavy_minus_sign:                                                                                                                                                      | A header for idempotency purposes                                                                                                                                       |                                                                                                                                                                         |

### Response

**[TranslationControllerGetTranslationGroupEndpointResponse](../../Models/Requests/TranslationControllerGetTranslationGroupEndpointResponse.md)**

### Errors

| Error Type                      | Status Code                     | Content Type                    |
| ------------------------------- | ------------------------------- | ------------------------------- |
| Novu.Models.Errors.APIException | 4XX, 5XX                        | \*/\*                           |