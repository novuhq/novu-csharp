# Novu

Developer-friendly & type-safe Csharp SDK specifically catered to leverage *Novu* API.

<div align="left">
    <a href="https://www.speakeasy.com/?utm_source=novu&utm_campaign=csharp"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" style="width: 100px; height: 28px;" />
    </a>
</div>


<br /><br />
> [!IMPORTANT]
> This SDK is not yet ready for production use. To complete setup please follow the steps outlined in your [workspace](https://app.speakeasy.com/org/novu/novu). Delete this section before > publishing to a package manager.

<!-- Start Summary [summary] -->
## Summary

Novu API: Novu REST API. Please see https://docs.novu.co/api-reference for more details.

For more information about the API: [Novu Documentation](https://docs.novu.co)
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [Novu](#novu)
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [Authentication](#authentication)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Retries](#retries)
  * [Error Handling](#error-handling)
  * [Server Selection](#server-selection)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### NuGet

To add the [NuGet](https://www.nuget.org/) package to a .NET project:
```bash
dotnet add package Novu
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference src/Novu/Novu.csproj
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Trigger Notification Event

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.TriggerAsync(
    triggerEventRequestDto: new TriggerEventRequestDto() {
        WorkflowId = "workflow_identifier",
        Payload = new Dictionary<string, object>() {
            { "comment_id", "string" },
            { "post", new Dictionary<string, object>() {
                { "text", "string" },
            } },
        },
        Overrides = new Overrides() {},
        To = To.CreateStr(
            "SUBSCRIBER_ID"
        ),
    },
    idempotencyKey: "<value>"
);

// handle response
```

### Cancel Triggered Event

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.CancelAsync(
    transactionId: "<id>",
    idempotencyKey: "<value>"
);

// handle response
```

### Broadcast Event to All

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.BroadcastAsync(
    triggerEventToAllRequestDto: new TriggerEventToAllRequestDto() {
        Name = "<value>",
        Payload = new Dictionary<string, object>() {
            { "comment_id", "string" },
            { "post", new Dictionary<string, object>() {
                { "text", "string" },
            } },
        },
        Overrides = new TriggerEventToAllRequestDtoOverrides() {
            AdditionalProperties = new Dictionary<string, Dictionary<string, object>>() {
                { "fcm", new Dictionary<string, object>() {
                    { "data", new Dictionary<string, object>() {
                        { "key", "value" },
                    } },
                } },
            },
        },
    },
    idempotencyKey: "<value>"
);

// handle response
```

### Trigger Notification Events in Bulk

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.TriggerBulkAsync(
    bulkTriggerEventDto: new BulkTriggerEventDto() {
        Events = new List<TriggerEventRequestDto>() {
            new TriggerEventRequestDto() {
                WorkflowId = "workflow_identifier",
                Payload = new Dictionary<string, object>() {
                    { "comment_id", "string" },
                    { "post", new Dictionary<string, object>() {
                        { "text", "string" },
                    } },
                },
                Overrides = new Overrides() {},
                To = To.CreateStr(
                    "SUBSCRIBER_ID"
                ),
            },
        },
    },
    idempotencyKey: "<value>"
);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name        | Type   | Scheme  |
| ----------- | ------ | ------- |
| `SecretKey` | apiKey | API key |

To authenticate with the API the `SecretKey` parameter must be set when initializing the SDK client instance. For example:
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.TriggerAsync(
    triggerEventRequestDto: new TriggerEventRequestDto() {
        WorkflowId = "workflow_identifier",
        Payload = new Dictionary<string, object>() {
            { "comment_id", "string" },
            { "post", new Dictionary<string, object>() {
                { "text", "string" },
            } },
        },
        Overrides = new Overrides() {},
        To = To.CreateStr(
            "SUBSCRIBER_ID"
        ),
    },
    idempotencyKey: "<value>"
);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [Integrations](docs/sdks/integrations/README.md)

* [GetAll](docs/sdks/integrations/README.md#getall) - List all integrations
* [Create](docs/sdks/integrations/README.md#create) - Create an integration
* [Update](docs/sdks/integrations/README.md#update) - Update an integration
* [Delete](docs/sdks/integrations/README.md#delete) - Delete an integration
* [SetPrimary](docs/sdks/integrations/README.md#setprimary) - Update integration as primary
* [ListActive](docs/sdks/integrations/README.md#listactive) - List active integrations

### [Messages](docs/sdks/messages/README.md)

* [Get](docs/sdks/messages/README.md#get) - List all messages
* [Delete](docs/sdks/messages/README.md#delete) - Delete a message
* [DeleteByTransactionId](docs/sdks/messages/README.md#deletebytransactionid) - Delete messages by transactionId

### [Notifications](docs/sdks/notifications/README.md)

* [Get](docs/sdks/notifications/README.md#get) - List all events
* [Retrieve](docs/sdks/notifications/README.md#retrieve) - Retrieve an event

### [Novu SDK](docs/sdks/novu/README.md)

* [Trigger](docs/sdks/novu/README.md#trigger) - Trigger event
* [Cancel](docs/sdks/novu/README.md#cancel) - Cancel triggered event
* [Broadcast](docs/sdks/novu/README.md#broadcast) - Broadcast event to all
* [TriggerBulk](docs/sdks/novu/README.md#triggerbulk) - Bulk trigger event

### [Subscribers](docs/sdks/subscribers/README.md)

* [Search](docs/sdks/subscribers/README.md#search) - Search subscribers
* [Create](docs/sdks/subscribers/README.md#create) - Create a subscriber
* [Retrieve](docs/sdks/subscribers/README.md#retrieve) - Retrieve a subscriber
* [Patch](docs/sdks/subscribers/README.md#patch) - Update a subscriber
* [Delete](docs/sdks/subscribers/README.md#delete) - Delete subscriber
* [CreateBulk](docs/sdks/subscribers/README.md#createbulk) - Bulk create subscribers
* [UpdateCredentials](docs/sdks/subscribers/README.md#updatecredentials) - Update provider credentials
* [AppendCredentials](docs/sdks/subscribers/README.md#appendcredentials) - Upsert provider credentials
* [DeleteCredentials](docs/sdks/subscribers/README.md#deletecredentials) - Delete provider credentials
* [UpdateOnlineStatus](docs/sdks/subscribers/README.md#updateonlinestatus) - Update subscriber online status

#### [Subscribers.Topics](docs/sdks/novutopics/README.md)

* [List](docs/sdks/novutopics/README.md#list) - Retrieve subscriber subscriptions

### [SubscribersMessages](docs/sdks/subscribersmessages/README.md)

* [UpdateAction](docs/sdks/subscribersmessages/README.md#updateaction) - Update notification action status
* [MarkAll](docs/sdks/subscribersmessages/README.md#markall) - Update all notifications state
* [MarkAllAs](docs/sdks/subscribersmessages/README.md#markallas) - Update notifications state

### [SubscribersNotifications](docs/sdks/subscribersnotifications/README.md)

* [Feed](docs/sdks/subscribersnotifications/README.md#feed) - Retrieve subscriber notifications
* [UnseenCount](docs/sdks/subscribersnotifications/README.md#unseencount) - Retrieve unseen notifications count

### [SubscribersPreferences](docs/sdks/subscriberspreferences/README.md)

* [List](docs/sdks/subscriberspreferences/README.md#list) - Retrieve subscriber preferences
* [Update](docs/sdks/subscriberspreferences/README.md#update) - Update subscriber preferences

### [Topics](docs/sdks/topics/README.md)

* [List](docs/sdks/topics/README.md#list) - List all topics
* [Create](docs/sdks/topics/README.md#create) - Create a topic
* [Get](docs/sdks/topics/README.md#get) - Retrieve a topic
* [Update](docs/sdks/topics/README.md#update) - Update a topic
* [Delete](docs/sdks/topics/README.md#delete) - Delete a topic

#### [Topics.Subscriptions](docs/sdks/subscriptions/README.md)

* [List](docs/sdks/subscriptions/README.md#list) - List topic subscriptions
* [Create](docs/sdks/subscriptions/README.md#create) - Create topic subscriptions
* [Delete](docs/sdks/subscriptions/README.md#delete) - Delete topic subscriptions

### [TopicsSubscribers](docs/sdks/topicssubscribers/README.md)

* [Get](docs/sdks/topicssubscribers/README.md#get) - Check topic subscriber

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries. If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API. However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.TriggerAsync(
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
    ),
    triggerEventRequestDto: new TriggerEventRequestDto() {
        WorkflowId = "workflow_identifier",
        Payload = new Dictionary<string, object>() {
            { "comment_id", "string" },
            { "post", new Dictionary<string, object>() {
                { "text", "string" },
            } },
        },
        Overrides = new Overrides() {},
        To = To.CreateStr(
            "SUBSCRIBER_ID"
        ),
    },
    idempotencyKey: "<value>"
);

// handle response
```

If you'd like to override the default retry strategy for all operations that support retries, you can use the `RetryConfig` optional parameter when intitializing the SDK:
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
    ),
    secretKey: "YOUR_SECRET_KEY_HERE"
);

var res = await sdk.TriggerAsync(
    triggerEventRequestDto: new TriggerEventRequestDto() {
        WorkflowId = "workflow_identifier",
        Payload = new Dictionary<string, object>() {
            { "comment_id", "string" },
            { "post", new Dictionary<string, object>() {
                { "text", "string" },
            } },
        },
        Overrides = new Overrides() {},
        To = To.CreateStr(
            "SUBSCRIBER_ID"
        ),
    },
    idempotencyKey: "<value>"
);

// handle response
```
<!-- End Retries [retries] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `Novu.Models.Errors.APIException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `Request`     | *HttpRequestMessage*  | The HTTP request      |
| `Response`    | *HttpResponseMessage* | The HTTP response     |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `TriggerAsync` method throws the following exceptions:

| Error Type                            | Status Code                            | Content Type     |
| ------------------------------------- | -------------------------------------- | ---------------- |
| Novu.Models.Errors.ErrorDto           | 414                                    | application/json |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 404, 405, 409, 413, 415 | application/json |
| Novu.Models.Errors.ValidationErrorDto | 422                                    | application/json |
| Novu.Models.Errors.ErrorDto           | 500                                    | application/json |
| Novu.Models.Errors.APIException       | 4XX, 5XX                               | \*/\*            |

### Example

```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Errors;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

try
{
    var res = await sdk.TriggerAsync(
        triggerEventRequestDto: new TriggerEventRequestDto() {
            WorkflowId = "workflow_identifier",
            Payload = new Dictionary<string, object>() {
                { "comment_id", "string" },
                { "post", new Dictionary<string, object>() {
                    { "text", "string" },
                } },
            },
            Overrides = new Overrides() {},
            To = To.CreateStr(
                "SUBSCRIBER_ID"
            ),
        },
        idempotencyKey: "<value>"
    );

    // handle response
}
catch (Exception ex)
{
    if (ex is ErrorDto)
    {
        // Handle exception data
        throw;
    }
    else if (ex is ErrorDto)
    {
        // Handle exception data
        throw;
    }
    else if (ex is ValidationErrorDto)
    {
        // Handle exception data
        throw;
    }
    else if (ex is ErrorDto)
    {
        // Handle exception data
        throw;
    }
    else if (ex is Novu.Models.Errors.APIException)
    {
        // Handle default exception
        throw;
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: int` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| #   | Server                   | Description |
| --- | ------------------------ | ----------- |
| 0   | `https://api.novu.co`    |             |
| 1   | `https://eu.api.novu.co` |             |

#### Example

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(
    serverIndex: 1,
    secretKey: "YOUR_SECRET_KEY_HERE"
);

var res = await sdk.TriggerAsync(
    triggerEventRequestDto: new TriggerEventRequestDto() {
        WorkflowId = "workflow_identifier",
        Payload = new Dictionary<string, object>() {
            { "comment_id", "string" },
            { "post", new Dictionary<string, object>() {
                { "text", "string" },
            } },
        },
        Overrides = new Overrides() {},
        To = To.CreateStr(
            "SUBSCRIBER_ID"
        ),
    },
    idempotencyKey: "<value>"
);

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(
    serverUrl: "https://eu.api.novu.co",
    secretKey: "YOUR_SECRET_KEY_HERE"
);

var res = await sdk.TriggerAsync(
    triggerEventRequestDto: new TriggerEventRequestDto() {
        WorkflowId = "workflow_identifier",
        Payload = new Dictionary<string, object>() {
            { "comment_id", "string" },
            { "post", new Dictionary<string, object>() {
                { "text", "string" },
            } },
        },
        Overrides = new Overrides() {},
        To = To.CreateStr(
            "SUBSCRIBER_ID"
        ),
    },
    idempotencyKey: "<value>"
);

// handle response
```
<!-- End Server Selection [server] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically. Any manual changes added to internal files will be overwritten on the next generation. 
We look forward to hearing your feedback. Feel free to open a PR or an issue with a proof of concept and we'll do our best to include it in a future release. 

### SDK Created by [Speakeasy](https://www.speakeasy.com/?utm_source=novu&utm_campaign=csharp)
