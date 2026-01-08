# Translations.Master

## Overview

### Available Operations

* [Retrieve](#retrieve) - Retrieve master translations JSON
* [Import](#import) - Import master translations JSON
* [Upload](#upload) - Upload master translations JSON file

## Retrieve

Retrieve all translations for a locale in master JSON format organized by resourceId (workflowId)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TranslationController_getMasterJsonEndpoint" method="get" path="/v2/translations/master-json" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Translations.Master.RetrieveAsync(locale: "en_US");

// handle response
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            | Example                                                                |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `Locale`                                                               | *string*                                                               | :heavy_minus_sign:                                                     | Locale to export. If not provided, exports organization default locale | en_US                                                                  |
| `IdempotencyKey`                                                       | *string*                                                               | :heavy_minus_sign:                                                     | A header for idempotency purposes                                      |                                                                        |

### Response

**[TranslationControllerGetMasterJsonEndpointResponse](../../Models/Requests/TranslationControllerGetMasterJsonEndpointResponse.md)**

### Errors

| Error Type                      | Status Code                     | Content Type                    |
| ------------------------------- | ------------------------------- | ------------------------------- |
| Novu.Models.Errors.APIException | 4XX, 5XX                        | \*/\*                           |

## Import

Import translations for multiple workflows from master JSON format for a specific locale

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TranslationController_importMasterJsonEndpoint" method="post" path="/v2/translations/master-json" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Translations.Master.ImportAsync(importMasterJsonRequestDto: new ImportMasterJsonRequestDto() {
    Locale = "en_US",
    MasterJson = new Dictionary<string, object>() {
        { "workflows", new Dictionary<string, object>() {
            { "welcome-email", new Dictionary<string, object>() {
                { "welcome.title", "Welcome to our platform" },
                { "welcome.message", "Hello there!" },
            } },
            { "password-reset", new Dictionary<string, object>() {
                { "reset.title", "Reset your password" },
                { "reset.message", "Click the link to reset" },
            } },
        } },
    },
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `ImportMasterJsonRequestDto`                                                        | [ImportMasterJsonRequestDto](../../Models/Components/ImportMasterJsonRequestDto.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `IdempotencyKey`                                                                    | *string*                                                                            | :heavy_minus_sign:                                                                  | A header for idempotency purposes                                                   |

### Response

**[TranslationControllerImportMasterJsonEndpointResponse](../../Models/Requests/TranslationControllerImportMasterJsonEndpointResponse.md)**

### Errors

| Error Type                      | Status Code                     | Content Type                    |
| ------------------------------- | ------------------------------- | ------------------------------- |
| Novu.Models.Errors.APIException | 4XX, 5XX                        | \*/\*                           |

## Upload

Upload a master JSON file containing translations for multiple workflows. Locale is automatically detected from filename (e.g., en_US.json)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TranslationController_uploadMasterJsonEndpoint" method="post" path="/v2/translations/master-json/upload" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Translations.Master.UploadAsync(requestBody: new TranslationControllerUploadMasterJsonEndpointRequestBody() {
    File = new Novu.Models.Requests.File() {
        FileName = "example.file",
        Content = System.IO.File.ReadAllBytes("example.file"),
    },
});

// handle response
```

### Parameters

| Parameter                                                                                                                                     | Type                                                                                                                                          | Required                                                                                                                                      | Description                                                                                                                                   |
| --------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- |
| `RequestBody`                                                                                                                                 | [TranslationControllerUploadMasterJsonEndpointRequestBody](../../Models/Requests/TranslationControllerUploadMasterJsonEndpointRequestBody.md) | :heavy_check_mark:                                                                                                                            | N/A                                                                                                                                           |
| `IdempotencyKey`                                                                                                                              | *string*                                                                                                                                      | :heavy_minus_sign:                                                                                                                            | A header for idempotency purposes                                                                                                             |

### Response

**[TranslationControllerUploadMasterJsonEndpointResponse](../../Models/Requests/TranslationControllerUploadMasterJsonEndpointResponse.md)**

### Errors

| Error Type                      | Status Code                     | Content Type                    |
| ------------------------------- | ------------------------------- | ------------------------------- |
| Novu.Models.Errors.APIException | 4XX, 5XX                        | \*/\*                           |