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
  * [Pagination](#pagination)
  * [Retries](#retries)
  * [Error Handling](#error-handling)
  * [Server Selection](#server-selection)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

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
        Overrides = new Dictionary<string, Dictionary<string, object>>() {
            { "fcm", new Dictionary<string, object>() {
                { "data", new Dictionary<string, object>() {
                    { "key", "value" },
                } },
            } },
        },
        To = To.CreateSubscriberPayloadDto(
            new SubscriberPayloadDto() {
                SubscriberId = "<id>",
            }
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
        Overrides = new Overrides() {},
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
                Overrides = new Dictionary<string, Dictionary<string, object>>() {
                    { "fcm", new Dictionary<string, object>() {
                        { "data", new Dictionary<string, object>() {
                            { "key", "value" },
                        } },
                    } },
                },
                To = To.CreateTopicPayloadDto(
                    new TopicPayloadDto() {
                        TopicKey = "<value>",
                        Type = TriggerRecipientsTypeEnum.Topic,
                    }
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
        Overrides = new Dictionary<string, Dictionary<string, object>>() {
            { "fcm", new Dictionary<string, object>() {
                { "data", new Dictionary<string, object>() {
                    { "key", "value" },
                } },
            } },
        },
        To = To.CreateSubscriberPayloadDto(
            new SubscriberPayloadDto() {
                SubscriberId = "<id>",
            }
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

* [GetAll](docs/sdks/integrations/README.md#getall) - Get integrations
* [Create](docs/sdks/integrations/README.md#create) - Create integration
* [Update](docs/sdks/integrations/README.md#update) - Update integration
* [Delete](docs/sdks/integrations/README.md#delete) - Delete integration
* [SetPrimary](docs/sdks/integrations/README.md#setprimary) - Set integration as primary
* [ListActive](docs/sdks/integrations/README.md#listactive) - Get active integrations

### [IntegrationsWebhooks](docs/sdks/integrationswebhooks/README.md)

* [GetStatus](docs/sdks/integrationswebhooks/README.md#getstatus) - Get webhook support status for provider

### [Messages](docs/sdks/messages/README.md)

* [Get](docs/sdks/messages/README.md#get) - Get messages
* [Delete](docs/sdks/messages/README.md#delete) - Delete message
* [DeleteByTransactionId](docs/sdks/messages/README.md#deletebytransactionid) - Delete messages by transactionId

### [Notifications](docs/sdks/notifications/README.md)

* [Get](docs/sdks/notifications/README.md#get) - Get notifications
* [Retrieve](docs/sdks/notifications/README.md#retrieve) - Get notification
* [GetGraphStats](docs/sdks/notifications/README.md#getgraphstats) - Get notification graph statistics
* [GetStats](docs/sdks/notifications/README.md#getstats) - Get notification statistics

### [Novu SDK](docs/sdks/novu/README.md)

* [Trigger](docs/sdks/novu/README.md#trigger) - Trigger event
* [Cancel](docs/sdks/novu/README.md#cancel) - Cancel triggered event
* [Broadcast](docs/sdks/novu/README.md#broadcast) - Broadcast event to all
* [TriggerBulk](docs/sdks/novu/README.md#triggerbulk) - Bulk trigger event

### [Subscribers](docs/sdks/subscribers/README.md)

* [Search](docs/sdks/subscribers/README.md#search) - Search for subscribers
* [Create](docs/sdks/subscribers/README.md#create) - Create subscriber
* [Retrieve](docs/sdks/subscribers/README.md#retrieve) - Get subscriber
* [Patch](docs/sdks/subscribers/README.md#patch) - Patch subscriber
* [Delete](docs/sdks/subscribers/README.md#delete) - Delete subscriber
* [GetAll](docs/sdks/subscribers/README.md#getall) - Get subscribers
* [Upsert](docs/sdks/subscribers/README.md#upsert) - Upsert subscriber
* [CreateBulk](docs/sdks/subscribers/README.md#createbulk) - Bulk create subscribers
* [UpdateCredentials](docs/sdks/subscribers/README.md#updatecredentials) - Update subscriber credentials
* [AppendCredentials](docs/sdks/subscribers/README.md#appendcredentials) - Modify subscriber credentials
* [DeleteCredentials](docs/sdks/subscribers/README.md#deletecredentials) - Delete subscriber credentials by providerId
* [GetChatAccessOauth](docs/sdks/subscribers/README.md#getchataccessoauth) - Handle chat oauth
* [UpdateOnlineStatus](docs/sdks/subscribers/README.md#updateonlinestatus) - Update subscriber online status

### [SubscribersAuthentication](docs/sdks/subscribersauthentication/README.md)

* [OauthCallback](docs/sdks/subscribersauthentication/README.md#oauthcallback) - Handle providers oauth redirect

### [SubscribersMessages](docs/sdks/subscribersmessages/README.md)

* [UpdateAction](docs/sdks/subscribersmessages/README.md#updateaction) - Mark message action as seen
* [MarkAll](docs/sdks/subscribersmessages/README.md#markall) - Marks all the subscriber messages as read, unread, seen or unseen. Optionally you can pass feed id (or array) to mark messages of a particular feed.
* [MarkAllAs](docs/sdks/subscribersmessages/README.md#markallas) - Mark a subscriber messages as seen, read, unseen or unread

### [SubscribersNotifications](docs/sdks/subscribersnotifications/README.md)

* [Feed](docs/sdks/subscribersnotifications/README.md#feed) - Get in-app notification feed for a particular subscriber
* [UnseenCount](docs/sdks/subscribersnotifications/README.md#unseencount) - Get the unseen in-app notifications count for subscribers feed

### [SubscribersPreferences](docs/sdks/subscriberspreferences/README.md)

* [List](docs/sdks/subscriberspreferences/README.md#list) - Get subscriber preferences
* [Update](docs/sdks/subscriberspreferences/README.md#update) - Update subscriber global or workflow specific preferences

### [Topics](docs/sdks/topics/README.md)

* [Create](docs/sdks/topics/README.md#create) - Topic creation
* [List](docs/sdks/topics/README.md#list) - Get topic list filtered 
* [Delete](docs/sdks/topics/README.md#delete) - Delete topic
* [Get](docs/sdks/topics/README.md#get) - Get topic
* [Rename](docs/sdks/topics/README.md#rename) - Rename a topic

### [TopicsSubscribers](docs/sdks/topicssubscribers/README.md)

* [Add](docs/sdks/topicssubscribers/README.md#add) - Subscribers addition
* [Get](docs/sdks/topicssubscribers/README.md#get) - Check topic subscriber
* [Remove](docs/sdks/topicssubscribers/README.md#remove) - Subscribers removal

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Pagination [pagination] -->
## Pagination

Some of the endpoints in this SDK support pagination. To use pagination, you make your SDK calls as usual, but the
returned response object will have a `Next` method that can be called to pull down the next group of results. If the
return value of `Next` is `null`, then there are no more pages to be fetched.

Here's an example of one such pagination call:
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

SubscribersV1ControllerListSubscribersResponse? res = await sdk.Subscribers.GetAllAsync(
    page: 4610.08D,
    limit: 10D,
    idempotencyKey: "<value>"
);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```
<!-- End Pagination [pagination] -->

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
        Overrides = new Dictionary<string, Dictionary<string, object>>() {
            { "fcm", new Dictionary<string, object>() {
                { "data", new Dictionary<string, object>() {
                    { "key", "value" },
                } },
            } },
        },
        To = To.CreateSubscriberPayloadDto(
            new SubscriberPayloadDto() {
                SubscriberId = "<id>",
            }
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
        Overrides = new Dictionary<string, Dictionary<string, object>>() {
            { "fcm", new Dictionary<string, object>() {
                { "data", new Dictionary<string, object>() {
                    { "key", "value" },
                } },
            } },
        },
        To = To.CreateSubscriberPayloadDto(
            new SubscriberPayloadDto() {
                SubscriberId = "<id>",
            }
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
            Overrides = new Dictionary<string, Dictionary<string, object>>() {
                { "fcm", new Dictionary<string, object>() {
                    { "data", new Dictionary<string, object>() {
                        { "key", "value" },
                    } },
                } },
            },
            To = To.CreateSubscriberPayloadDto(
                new SubscriberPayloadDto() {
                    SubscriberId = "<id>",
                }
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
        Overrides = new Dictionary<string, Dictionary<string, object>>() {
            { "fcm", new Dictionary<string, object>() {
                { "data", new Dictionary<string, object>() {
                    { "key", "value" },
                } },
            } },
        },
        To = To.CreateSubscriberPayloadDto(
            new SubscriberPayloadDto() {
                SubscriberId = "<id>",
            }
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
    serverUrl: "https://api.novu.co",
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
        Overrides = new Dictionary<string, Dictionary<string, object>>() {
            { "fcm", new Dictionary<string, object>() {
                { "data", new Dictionary<string, object>() {
                    { "key", "value" },
                } },
            } },
        },
        To = To.CreateSubscriberPayloadDto(
            new SubscriberPayloadDto() {
                SubscriberId = "<id>",
            }
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
