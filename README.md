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

var res = await sdk.TriggerAsync(triggerEventRequestDto: new TriggerEventRequestDto() {
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
});

// handle response
```

### Cancel Triggered Event

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.CancelAsync(transactionId: "<id>");

// handle response
```

### Broadcast Event to All

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.BroadcastAsync(triggerEventToAllRequestDto: new TriggerEventToAllRequestDto() {
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
});

// handle response
```

### Trigger Notification Events in Bulk

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.TriggerBulkAsync(bulkTriggerEventDto: new BulkTriggerEventDto() {
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
});

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

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.InboundWebhooksControllerHandleWebhookAsync(
    environmentId: "<id>",
    integrationId: "<id>"
);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [Environments](docs/sdks/environments/README.md)

* [GetTags](docs/sdks/environments/README.md#gettags) - Get environment tags
* [Create](docs/sdks/environments/README.md#create) - Create an environment
* [List](docs/sdks/environments/README.md#list) - List all environments
* [Update](docs/sdks/environments/README.md#update) - Update an environment
* [Delete](docs/sdks/environments/README.md#delete) - Delete an environment

### [Integrations](docs/sdks/integrations/README.md)

* [GetAll](docs/sdks/integrations/README.md#getall) - List all integrations
* [Create](docs/sdks/integrations/README.md#create) - Create an integration
* [Update](docs/sdks/integrations/README.md#update) - Update an integration
* [Delete](docs/sdks/integrations/README.md#delete) - Delete an integration
* [IntegrationsControllerAutoConfigureIntegration](docs/sdks/integrations/README.md#integrationscontrollerautoconfigureintegration) - Auto-configure an integration for inbound webhooks
* [SetPrimary](docs/sdks/integrations/README.md#setprimary) - Update integration as primary
* [ListActive](docs/sdks/integrations/README.md#listactive) - List active integrations

### [Layouts](docs/sdks/layouts/README.md)

* [Create](docs/sdks/layouts/README.md#create) - Create a layout
* [List](docs/sdks/layouts/README.md#list) - List all layouts
* [Update](docs/sdks/layouts/README.md#update) - Update a layout
* [Retrieve](docs/sdks/layouts/README.md#retrieve) - Retrieve a layout
* [Delete](docs/sdks/layouts/README.md#delete) - Delete a layout
* [Duplicate](docs/sdks/layouts/README.md#duplicate) - Duplicate a layout
* [GeneratePreview](docs/sdks/layouts/README.md#generatepreview) - Generate layout preview
* [Usage](docs/sdks/layouts/README.md#usage) - Get layout usage

### [Messages](docs/sdks/messages/README.md)

* [Get](docs/sdks/messages/README.md#get) - List all messages
* [Delete](docs/sdks/messages/README.md#delete) - Delete a message
* [DeleteByTransactionId](docs/sdks/messages/README.md#deletebytransactionid) - Delete messages by transactionId

### [Notifications](docs/sdks/notifications/README.md)

* [Get](docs/sdks/notifications/README.md#get) - List all events
* [Retrieve](docs/sdks/notifications/README.md#retrieve) - Retrieve an event

### [Novu SDK](docs/sdks/novu/README.md)

* [InboundWebhooksControllerHandleWebhook](docs/sdks/novu/README.md#inboundwebhookscontrollerhandlewebhook)
* [Trigger](docs/sdks/novu/README.md#trigger) - Trigger event
* [Cancel](docs/sdks/novu/README.md#cancel) - Cancel triggered event
* [Broadcast](docs/sdks/novu/README.md#broadcast) - Broadcast event to all
* [TriggerBulk](docs/sdks/novu/README.md#triggerbulk) - Bulk trigger event

### [Subscribers](docs/sdks/subscribers/README.md)

* [Search](docs/sdks/subscribers/README.md#search) - Search subscribers
* [Create](docs/sdks/subscribers/README.md#create) - Create a subscriber
* [Retrieve](docs/sdks/subscribers/README.md#retrieve) - Retrieve a subscriber
* [Patch](docs/sdks/subscribers/README.md#patch) - Update a subscriber
* [Delete](docs/sdks/subscribers/README.md#delete) - Delete a subscriber
* [CreateBulk](docs/sdks/subscribers/README.md#createbulk) - Bulk create subscribers
* [UpdateCredentials](docs/sdks/subscribers/README.md#updatecredentials) - Upsert provider credentials
* [AppendCredentials](docs/sdks/subscribers/README.md#appendcredentials) - Update provider credentials
* [DeleteCredentials](docs/sdks/subscribers/README.md#deletecredentials) - Delete provider credentials
* [UpdateOnlineStatus](docs/sdks/subscribers/README.md#updateonlinestatus) - Update subscriber online status

#### [Subscribers.Preferences](docs/sdks/preferences/README.md)

* [BulkUpdate](docs/sdks/preferences/README.md#bulkupdate) - Bulk update subscriber preferences

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

### [Translations](docs/sdks/translations/README.md)

* [Create](docs/sdks/translations/README.md#create) - Create a translation
* [Retrieve](docs/sdks/translations/README.md#retrieve) - Retrieve a translation
* [Delete](docs/sdks/translations/README.md#delete) - Delete a translation
* [Upload](docs/sdks/translations/README.md#upload) - Upload translation files

#### [Translations.Groups](docs/sdks/groups/README.md)

* [Delete](docs/sdks/groups/README.md#delete) - Delete a translation group
* [Retrieve](docs/sdks/groups/README.md#retrieve) - Retrieve a translation group

#### [Translations.Master](docs/sdks/master/README.md)

* [Retrieve](docs/sdks/master/README.md#retrieve) - Retrieve master translations JSON
* [Import](docs/sdks/master/README.md#import) - Import master translations JSON
* [Upload](docs/sdks/master/README.md#upload) - Upload master translations JSON file

### [Workflows](docs/sdks/workflows/README.md)

* [Create](docs/sdks/workflows/README.md#create) - Create a workflow
* [List](docs/sdks/workflows/README.md#list) - List all workflows
* [Update](docs/sdks/workflows/README.md#update) - Update a workflow
* [Get](docs/sdks/workflows/README.md#get) - Retrieve a workflow
* [Delete](docs/sdks/workflows/README.md#delete) - Delete a workflow
* [Patch](docs/sdks/workflows/README.md#patch) - Update a workflow
* [Sync](docs/sdks/workflows/README.md#sync) - Sync a workflow

#### [Workflows.Steps](docs/sdks/steps/README.md)

* [Retrieve](docs/sdks/steps/README.md#retrieve) - Retrieve workflow step

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries. If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API. However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.InboundWebhooksControllerHandleWebhookAsync(
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
    environmentId: "<id>",
    integrationId: "<id>"
);

// handle response
```

If you'd like to override the default retry strategy for all operations that support retries, you can use the `RetryConfig` optional parameter when intitializing the SDK:
```csharp
using Novu;
using Novu.Models.Components;

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

var res = await sdk.InboundWebhooksControllerHandleWebhookAsync(
    environmentId: "<id>",
    integrationId: "<id>"
);

// handle response
```
<!-- End Retries [retries] -->

<!-- Start Error Handling [errors] -->
## Error Handling

[`NovuError`](./src/Novu/Models/Errors/NovuError.cs) is the base exception class for all HTTP error responses. It has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | Error message         |
| `Request`     | *HttpRequestMessage*  | HTTP request object   |
| `Response`    | *HttpResponseMessage* | HTTP response object  |

Some exceptions in this SDK include an additional `Payload` field, which will contain deserialized custom error data when present. Possible exceptions are listed in the [Error Classes](#error-classes) section.

### Example

```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Errors;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

try
{
    var res = await sdk.TriggerAsync(triggerEventRequestDto: new TriggerEventRequestDto() {
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
    });

    // handle response
}
catch (NovuError ex)  // all SDK exceptions inherit from NovuError
{
    // ex.ToString() provides a detailed error message
    System.Console.WriteLine(ex);

    // Base exception fields
    HttpRequestMessage request = ex.Request;
    HttpResponseMessage response = ex.Response;
    var statusCode = (int)response.StatusCode;
    var responseBody = ex.Body;

    if (ex is PayloadValidationExceptionDto) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        PayloadValidationExceptionDtoPayload payload = ex.Payload;
        double StatusCode = payload.StatusCode;
        string Timestamp = payload.Timestamp;
        // ...
    }

    // An underlying cause may be provided
    if (ex.InnerException != null)
    {
        Exception cause = ex.InnerException;
    }
}
catch (System.Net.Http.HttpRequestException ex)
{
    // Check ex.InnerException for Network connectivity errors
}
```

### Error Classes

**Primary exceptions:**
* [`NovuError`](./src/Novu/Models/Errors/NovuError.cs): The base class for HTTP error responses.
  * [`ErrorDto`](./src/Novu/Models/Errors/ErrorDto.cs): *
  * [`ValidationErrorDto`](./src/Novu/Models/Errors/ValidationErrorDto.cs): Unprocessable Entity. Status code `422`. *

<details><summary>Less common exceptions (5)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`NovuError`](./src/Novu/Models/Errors/NovuError.cs):
  * [`PayloadValidationExceptionDto`](./src/Novu/Models/Errors/PayloadValidationExceptionDto.cs): Status code `400`. Applicable to 3 of 75 methods.*
  * [`SubscriberResponseDto`](./src/Novu/Models/Errors/SubscriberResponseDto.cs): Created. Status code `409`. Applicable to 1 of 75 methods.*
  * [`TopicResponseDto`](./src/Novu/Models/Errors/TopicResponseDto.cs): OK. Status code `409`. Applicable to 1 of 75 methods.*
  * [`ResponseValidationError`](./src/Novu/Models/Errors/ResponseValidationError.cs): Thrown when the response data could not be deserialized into the expected type.
</details>

\* Refer to the [relevant documentation](#available-resources-and-operations) to determine whether an exception applies to a specific operation.
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

var sdk = new NovuSDK(
    serverIndex: 1,
    secretKey: "YOUR_SECRET_KEY_HERE"
);

var res = await sdk.InboundWebhooksControllerHandleWebhookAsync(
    environmentId: "<id>",
    integrationId: "<id>"
);

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(
    serverUrl: "https://eu.api.novu.co",
    secretKey: "YOUR_SECRET_KEY_HERE"
);

var res = await sdk.InboundWebhooksControllerHandleWebhookAsync(
    environmentId: "<id>",
    integrationId: "<id>"
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
