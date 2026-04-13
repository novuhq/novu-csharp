# Translations

## Overview

Used to localize your notifications to different languages.
<https://docs.novu.co/platform/workflow/advanced-features/translations>

### Available Operations

* [Create](#create) - Create a translation
* [Retrieve](#retrieve) - Retrieve a translation
* [Delete](#delete) - Delete a translation
* [Upload](#upload) - Upload translation files

## Create

Create a translation for a specific workflow and locale, if the translation already exists, it will be updated

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TranslationController_createTranslationEndpoint" method="post" path="/v2/translations" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Translations.CreateAsync(createTranslationRequestDto: new CreateTranslationRequestDto() {
    ResourceId = "welcome-email",
    ResourceType = Novu.Models.Components.ResourceType.Workflow,
    Locale = "en_US",
    Content = new Dictionary<string, object>() {
        { "welcome.title", "Welcome" },
        { "welcome.message", "Hello there!" },
    },
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `CreateTranslationRequestDto`                                                         | [CreateTranslationRequestDto](../../Models/Components/CreateTranslationRequestDto.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `IdempotencyKey`                                                                      | *string*                                                                              | :heavy_minus_sign:                                                                    | A header for idempotency purposes                                                     |

### Response

**[TranslationControllerCreateTranslationEndpointResponse](../../Models/Requests/TranslationControllerCreateTranslationEndpointResponse.md)**

### Errors

| Error Type                      | Status Code                     | Content Type                    |
| ------------------------------- | ------------------------------- | ------------------------------- |
| Novu.Models.Errors.APIException | 4XX, 5XX                        | \*/\*                           |

## Retrieve

Retrieve a specific translation by resource type, resource ID and locale

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TranslationController_getSingleTranslation" method="get" path="/v2/translations/{resourceType}/{resourceId}/{locale}" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Translations.RetrieveAsync(
    resourceType: PathParamResourceType.Workflow,
    resourceId: "welcome-email",
    locale: "en_US"
);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             | Example                                                                 |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `ResourceType`                                                          | [PathParamResourceType](../../Models/Requests/PathParamResourceType.md) | :heavy_check_mark:                                                      | Resource type                                                           |                                                                         |
| `ResourceId`                                                            | *string*                                                                | :heavy_check_mark:                                                      | Resource ID                                                             | welcome-email                                                           |
| `Locale`                                                                | *string*                                                                | :heavy_check_mark:                                                      | Locale code                                                             | en_US                                                                   |
| `IdempotencyKey`                                                        | *string*                                                                | :heavy_minus_sign:                                                      | A header for idempotency purposes                                       |                                                                         |

### Response

**[TranslationControllerGetSingleTranslationResponse](../../Models/Requests/TranslationControllerGetSingleTranslationResponse.md)**

### Errors

| Error Type                      | Status Code                     | Content Type                    |
| ------------------------------- | ------------------------------- | ------------------------------- |
| Novu.Models.Errors.APIException | 4XX, 5XX                        | \*/\*                           |

## Delete

Delete a specific translation by resource type, resource ID and locale

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TranslationController_deleteTranslationEndpoint" method="delete" path="/v2/translations/{resourceType}/{resourceId}/{locale}" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Translations.DeleteAsync(
    resourceType: TranslationControllerDeleteTranslationEndpointPathParamResourceType.Workflow,
    resourceId: "<id>",
    locale: "el"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                           | Type                                                                                                                                                                | Required                                                                                                                                                            | Description                                                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ResourceType`                                                                                                                                                      | [TranslationControllerDeleteTranslationEndpointPathParamResourceType](../../Models/Requests/TranslationControllerDeleteTranslationEndpointPathParamResourceType.md) | :heavy_check_mark:                                                                                                                                                  | Resource type                                                                                                                                                       |
| `ResourceId`                                                                                                                                                        | *string*                                                                                                                                                            | :heavy_check_mark:                                                                                                                                                  | Resource ID                                                                                                                                                         |
| `Locale`                                                                                                                                                            | *string*                                                                                                                                                            | :heavy_check_mark:                                                                                                                                                  | Locale code                                                                                                                                                         |
| `IdempotencyKey`                                                                                                                                                    | *string*                                                                                                                                                            | :heavy_minus_sign:                                                                                                                                                  | A header for idempotency purposes                                                                                                                                   |

### Response

**[TranslationControllerDeleteTranslationEndpointResponse](../../Models/Requests/TranslationControllerDeleteTranslationEndpointResponse.md)**

### Errors

| Error Type                      | Status Code                     | Content Type                    |
| ------------------------------- | ------------------------------- | ------------------------------- |
| Novu.Models.Errors.APIException | 4XX, 5XX                        | \*/\*                           |

## Upload

Upload one or more JSON translation files for a specific workflow. Files name must match the locale, e.g. en_US.json. Supports both "files" and "files[]" field names for backwards compatibility.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TranslationController_uploadTranslationFiles" method="post" path="/v2/translations/upload" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Translations.UploadAsync(requestBody: new TranslationControllerUploadTranslationFilesRequestBody() {
    ResourceId = "welcome-email",
    ResourceType = Novu.Models.Requests.ResourceType.Workflow,
    Files = new List<Files>() {},
});

// handle response
```

### Parameters

| Parameter                                                                                                                                 | Type                                                                                                                                      | Required                                                                                                                                  | Description                                                                                                                               |
| ----------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- |
| `RequestBody`                                                                                                                             | [TranslationControllerUploadTranslationFilesRequestBody](../../Models/Requests/TranslationControllerUploadTranslationFilesRequestBody.md) | :heavy_check_mark:                                                                                                                        | N/A                                                                                                                                       |
| `IdempotencyKey`                                                                                                                          | *string*                                                                                                                                  | :heavy_minus_sign:                                                                                                                        | A header for idempotency purposes                                                                                                         |

### Response

**[TranslationControllerUploadTranslationFilesResponse](../../Models/Requests/TranslationControllerUploadTranslationFilesResponse.md)**

### Errors

| Error Type                      | Status Code                     | Content Type                    |
| ------------------------------- | ------------------------------- | ------------------------------- |
| Novu.Models.Errors.APIException | 4XX, 5XX                        | \*/\*                           |