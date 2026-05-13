# Domains

## Overview

Used to manage your inbound email domains.
<https://docs.novu.co/platform/domains>

### Available Operations

* [List](#list) - List domains for an environment
* [Create](#create) - Create a domain
* [Retrieve](#retrieve) - Retrieve a domain by name
* [Update](#update) - Update a domain
* [Delete](#delete) - Delete a domain
* [Diagnose](#diagnose) - Diagnose inbound DNS for a domain
* [Verify](#verify) - Verify a domain

## List

Returns a paginated list of inbound-email domains in the current environment. Supports cursor pagination and a name contains filter.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_listDomains" method="get" path="/v1/domains" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

DomainsControllerListDomainsRequest req = new DomainsControllerListDomainsRequest() {
    Limit = 10D,
};

var res = await sdk.Domains.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [DomainsControllerListDomainsRequest](../../Models/Requests/DomainsControllerListDomainsRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[DomainsControllerListDomainsResponse](../../Models/Requests/DomainsControllerListDomainsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Create

Registers a new inbound-email domain. The response includes the DNS records customers must add at their DNS provider before the domain can receive mail.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_createDomain" method="post" path="/v1/domains" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Domains.CreateAsync(createDomainDto: new CreateDomainDto() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `CreateDomainDto`                                             | [CreateDomainDto](../../Models/Components/CreateDomainDto.md) | :heavy_check_mark:                                            | N/A                                                           |
| `IdempotencyKey`                                              | *string*                                                      | :heavy_minus_sign:                                            | A header for idempotency purposes                             |

### Response

**[DomainsControllerCreateDomainResponse](../../Models/Requests/DomainsControllerCreateDomainResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Retrieve

Returns the domain configuration and the DNS records that must be in place. This is a pure read; call `domains.verify` to refresh verification status from DNS.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_getDomain" method="get" path="/v1/domains/{domain}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Domains.RetrieveAsync(domain: "foolish-requirement.org");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Domain`                          | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[DomainsControllerGetDomainResponse](../../Models/Requests/DomainsControllerGetDomainResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Update

Updates optional domain fields. When `data` is provided, it replaces the entire metadata object; omit `data` to leave it unchanged.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_updateDomain" method="patch" path="/v1/domains/{domain}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Domains.UpdateAsync(
    domain: "ordinary-eternity.org",
    updateDomainDto: new UpdateDomainDto() {}
);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `Domain`                                                      | *string*                                                      | :heavy_check_mark:                                            | N/A                                                           |
| `UpdateDomainDto`                                             | [UpdateDomainDto](../../Models/Components/UpdateDomainDto.md) | :heavy_check_mark:                                            | N/A                                                           |
| `IdempotencyKey`                                              | *string*                                                      | :heavy_minus_sign:                                            | A header for idempotency purposes                             |

### Response

**[DomainsControllerUpdateDomainResponse](../../Models/Requests/DomainsControllerUpdateDomainResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Removes the domain and cascades the deletion to all of its routes. Inbound mail for that domain stops being processed immediately.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_deleteDomain" method="delete" path="/v1/domains/{domain}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Domains.DeleteAsync(domain: "complicated-finer.org");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Domain`                          | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[DomainsControllerDeleteDomainResponse](../../Models/Requests/DomainsControllerDeleteDomainResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Diagnose

Runs live DNS checks for inbound email readiness (MX correctness, apex CNAME collision, and common DNS blocklists for the Novu mail host). Returns structured issues with plain-language fixes.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_diagnoseDomain" method="post" path="/v1/domains/{domain}/diagnose" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Domains.DiagnoseAsync(domain: "alive-publication.biz");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Domain`                          | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[DomainsControllerDiagnoseDomainResponse](../../Models/Requests/DomainsControllerDiagnoseDomainResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Verify

Performs a live DNS lookup to refresh the MX record status of the domain and updates the verification status accordingly. Returns the latest domain configuration.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_verifyDomain" method="post" path="/v1/domains/{domain}/verify" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Domains.VerifyAsync(domain: "formal-fork.com");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Domain`                          | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[DomainsControllerVerifyDomainResponse](../../Models/Requests/DomainsControllerVerifyDomainResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |