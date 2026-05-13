# Domains.Routes

## Overview

### Available Operations

* [List](#list) - List routes for a domain
* [Create](#create) - Create a route
* [Retrieve](#retrieve) - Retrieve a route by address
* [Update](#update) - Update a route
* [Delete](#delete) - Delete a route
* [Test](#test) - Test an inbound route

## List

Returns a paginated list of routes attached to the domain. Optionally filter by an agent identifier to find routes pointing to a specific agent.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_listDomainRoutes" method="get" path="/v1/domains/{domain}/routes" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

DomainsControllerListDomainRoutesRequest req = new DomainsControllerListDomainRoutesRequest() {
    Domain = "fearless-fishery.com",
    Limit = 10D,
};

var res = await sdk.Domains.Routes.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [DomainsControllerListDomainRoutesRequest](../../Models/Requests/DomainsControllerListDomainRoutesRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |

### Response

**[DomainsControllerListDomainRoutesResponse](../../Models/Requests/DomainsControllerListDomainRoutesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Create

Creates a route on the domain that forwards inbound mail addressed to `<address>@<domain>` to either a webhook or an agent. Each address on a domain may only have a single route.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_createDomainRoute" method="post" path="/v1/domains/{domain}/routes" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Domains.Routes.CreateAsync(
    domain: "radiant-solvency.net",
    domainRouteDto: new DomainRouteDto() {
        Address = "6581 Birch Road",
        Type = DomainRouteDtoType.Webhook,
    }
);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `Domain`                                                    | *string*                                                    | :heavy_check_mark:                                          | N/A                                                         |
| `DomainRouteDto`                                            | [DomainRouteDto](../../Models/Components/DomainRouteDto.md) | :heavy_check_mark:                                          | N/A                                                         |
| `IdempotencyKey`                                            | *string*                                                    | :heavy_minus_sign:                                          | A header for idempotency purposes                           |

### Response

**[DomainsControllerCreateDomainRouteResponse](../../Models/Requests/DomainsControllerCreateDomainRouteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Retrieve

Returns the route bound to `<address>@<domain>`. Use `*` as the address to retrieve the wildcard route for the domain.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_getDomainRoute" method="get" path="/v1/domains/{domain}/routes/{address}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Domains.Routes.RetrieveAsync(
    domain: "adolescent-petal.net",
    address: "42531 Green Lane"
);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Domain`                          | *string*                          | :heavy_check_mark:                | N/A                               |
| `Address`                         | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[DomainsControllerGetDomainRouteResponse](../../Models/Requests/DomainsControllerGetDomainRouteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Update

Updates the destination of the route bound to `<address>@<domain>`. The address itself is the resource identity and cannot be changed; delete and recreate the route to rename it.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_updateDomainRoute" method="patch" path="/v1/domains/{domain}/routes/{address}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Domains.Routes.UpdateAsync(
    domain: "cavernous-cycle.com",
    address: "70213 Gerlach Rue",
    updateDomainRouteDto: new UpdateDomainRouteDto() {}
);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Domain`                                                                | *string*                                                                | :heavy_check_mark:                                                      | N/A                                                                     |
| `Address`                                                               | *string*                                                                | :heavy_check_mark:                                                      | N/A                                                                     |
| `UpdateDomainRouteDto`                                                  | [UpdateDomainRouteDto](../../Models/Components/UpdateDomainRouteDto.md) | :heavy_check_mark:                                                      | N/A                                                                     |
| `IdempotencyKey`                                                        | *string*                                                                | :heavy_minus_sign:                                                      | A header for idempotency purposes                                       |

### Response

**[DomainsControllerUpdateDomainRouteResponse](../../Models/Requests/DomainsControllerUpdateDomainRouteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Removes the route bound to `<address>@<domain>`. Inbound mail for that address will no longer be processed.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_deleteDomainRoute" method="delete" path="/v1/domains/{domain}/routes/{address}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Domains.Routes.DeleteAsync(
    domain: "corrupt-avalanche.biz",
    address: "753 W 4th Avenue"
);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Domain`                          | *string*                          | :heavy_check_mark:                | N/A                               |
| `Address`                         | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[DomainsControllerDeleteDomainRouteResponse](../../Models/Requests/DomainsControllerDeleteDomainRouteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Test

Sends a synthetic inbound email through the same delivery path as production (outbound webhooks for webhook routes, signed HTTP to the agent for agent routes). Use `dryRun: true` to preview the payload without delivering.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="DomainsController_testDomainRoute" method="post" path="/v1/domains/{domain}/routes/{address}/test" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Domains.Routes.TestAsync(
    domain: "exalted-bonfire.com",
    address: "90499 Rowan Close",
    testDomainRouteDto: new TestDomainRouteDto() {
        From = new TestDomainRouteFromDto() {
            Address = "58851 Konopelski Overpass",
        },
        Subject = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Domain`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Address`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `TestDomainRouteDto`                                                | [TestDomainRouteDto](../../Models/Components/TestDomainRouteDto.md) | :heavy_check_mark:                                                  | N/A                                                                 |
| `IdempotencyKey`                                                    | *string*                                                            | :heavy_minus_sign:                                                  | A header for idempotency purposes                                   |

### Response

**[DomainsControllerTestDomainRouteResponse](../../Models/Requests/DomainsControllerTestDomainRouteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |