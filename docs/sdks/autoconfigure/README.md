# Domains.AutoConfigure

## Overview

### Available Operations

* [Retrieve](#retrieve) - Retrieve auto-configuration availability
* [Start](#start) - Start DNS auto-configuration

## Retrieve

Returns whether DNS auto-configuration (Domain Connect) is available for this domain. When `available` is `false`, `manualRecords` lists the DNS records the customer must add manually.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_getDomainAutoConfigure" method="get" path="/v1/domains/{domain}/auto-configure" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Domains.AutoConfigure.RetrieveAsync(domain: "hidden-subsidy.info");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Domain`                          | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[DomainsControllerGetDomainAutoConfigureResponse](../../Models/Requests/DomainsControllerGetDomainAutoConfigureResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Start

Generates a signed redirect URL the customer can follow to apply Novu DNS records at their DNS provider. After the provider completes the flow, it redirects back to `redirectUri`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_startDomainAutoConfigure" method="post" path="/v1/domains/{domain}/auto-configure/start" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Domains.AutoConfigure.StartAsync(
    domain: "criminal-other.name",
    createDomainConnectApplyUrlDto: new CreateDomainConnectApplyUrlDto() {}
);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `Domain`                                                                                    | *string*                                                                                    | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `CreateDomainConnectApplyUrlDto`                                                            | [CreateDomainConnectApplyUrlDto](../../Models/Components/CreateDomainConnectApplyUrlDto.md) | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `IdempotencyKey`                                                                            | *string*                                                                                    | :heavy_minus_sign:                                                                          | A header for idempotency purposes                                                           |

### Response

**[DomainsControllerStartDomainAutoConfigureResponse](../../Models/Requests/DomainsControllerStartDomainAutoConfigureResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |