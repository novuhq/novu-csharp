# Topics.Subscriptions

## Overview

### Available Operations

* [List](#list) - List topic subscriptions
* [Create](#create) - Create topic subscriptions
* [Delete](#delete) - Delete topic subscriptions
* [GetSubscription](#getsubscription) - Retrieve a topic subscription
* [Update](#update) - Update a topic subscription

## List

List all subscriptions of subscribers for a topic.
    Checkout all available filters in the query section.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TopicsController_listTopicSubscriptions" method="get" path="/v2/topics/{topicKey}/subscriptions" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

TopicsControllerListTopicSubscriptionsRequest req = new TopicsControllerListTopicSubscriptionsRequest() {
    TopicKey = "<value>",
    Limit = 10D,
    ContextKeys = new List<string>() {
        "tenant:org-123",
        "region:us-east-1",
    },
};

var res = await sdk.Topics.Subscriptions.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                               | [TopicsControllerListTopicSubscriptionsRequest](../../Models/Requests/TopicsControllerListTopicSubscriptionsRequest.md) | :heavy_check_mark:                                                                                                      | The request object to use for the request.                                                                              |

### Response

**[TopicsControllerListTopicSubscriptionsResponse](../../Models/Requests/TopicsControllerListTopicSubscriptionsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Create

This api will create subscription for subscriberIds for a topic. 
      Its like subscribing to a common interest group. if topic does not exist, it will be created.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TopicsController_createTopicSubscriptions" method="post" path="/v2/topics/{topicKey}/subscriptions" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.Subscriptions.CreateAsync(
    topicKey: "<value>",
    createTopicSubscriptionsRequestDto: new CreateTopicSubscriptionsRequestDto() {
        Subscriptions = new List<Novu.Models.Components.Subscriptions>() {
            Novu.Models.Components.Subscriptions.CreateTopicSubscriberIdentifierDto(
                new TopicSubscriberIdentifierDto() {
                    Identifier = "subscriber-123-subscription-a",
                    SubscriberId = "subscriber-123",
                }
            ),
            Novu.Models.Components.Subscriptions.CreateTopicSubscriberIdentifierDto(
                new TopicSubscriberIdentifierDto() {
                    Identifier = "subscriber-456-subscription-b",
                    SubscriberId = "subscriber-456",
                }
            ),
        },
        Name = "My Topic",
        Context = new Dictionary<string, CreateTopicSubscriptionsRequestDtoContext>() {
            { "key", CreateTopicSubscriptionsRequestDtoContext.CreateStr(
                "org-acme"
            ) },
        },
        Preferences = new List<Novu.Models.Components.Preferences>() {
            Novu.Models.Components.Preferences.CreateWorkflowPreferenceRequestDto(
                new WorkflowPreferenceRequestDto() {
                    Condition = new Dictionary<string, object>() {
                        { "===", new List<object>() {
                            new Dictionary<string, object>() {
                                { "var", "tier" },
                            },
                            "premium",
                        } },
                    },
                    WorkflowId = "workflow-123",
                }
            ),
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `TopicKey`                                                                                          | *string*                                                                                            | :heavy_check_mark:                                                                                  | The key identifier of the topic                                                                     |
| `CreateTopicSubscriptionsRequestDto`                                                                | [CreateTopicSubscriptionsRequestDto](../../Models/Components/CreateTopicSubscriptionsRequestDto.md) | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `IdempotencyKey`                                                                                    | *string*                                                                                            | :heavy_minus_sign:                                                                                  | A header for idempotency purposes                                                                   |

### Response

**[TopicsControllerCreateTopicSubscriptionsResponse](../../Models/Requests/TopicsControllerCreateTopicSubscriptionsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Delete subscriptions for subscriberIds for a topic.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TopicsController_deleteTopicSubscriptions" method="delete" path="/v2/topics/{topicKey}/subscriptions" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.Subscriptions.DeleteAsync(
    topicKey: "<value>",
    deleteTopicSubscriptionsRequestDto: new DeleteTopicSubscriptionsRequestDto() {
        Subscriptions = new List<DeleteTopicSubscriptionsRequestDtoSubscriptions>() {
            DeleteTopicSubscriptionsRequestDtoSubscriptions.CreateDeleteTopicSubscriberIdentifierDto(
                new DeleteTopicSubscriberIdentifierDto() {
                    Identifier = "subscriber-123-subscription-a",
                    SubscriberId = "subscriber-123",
                }
            ),
            DeleteTopicSubscriptionsRequestDtoSubscriptions.CreateDeleteTopicSubscriberIdentifierDto(
                new DeleteTopicSubscriberIdentifierDto() {
                    SubscriberId = "subscriber-456",
                }
            ),
            DeleteTopicSubscriptionsRequestDtoSubscriptions.CreateDeleteTopicSubscriberIdentifierDto(
                new DeleteTopicSubscriberIdentifierDto() {
                    Identifier = "subscriber-789-subscription-b",
                }
            ),
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `TopicKey`                                                                                          | *string*                                                                                            | :heavy_check_mark:                                                                                  | The key identifier of the topic                                                                     |
| `DeleteTopicSubscriptionsRequestDto`                                                                | [DeleteTopicSubscriptionsRequestDto](../../Models/Components/DeleteTopicSubscriptionsRequestDto.md) | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `IdempotencyKey`                                                                                    | *string*                                                                                            | :heavy_minus_sign:                                                                                  | A header for idempotency purposes                                                                   |

### Response

**[TopicsControllerDeleteTopicSubscriptionsResponse](../../Models/Requests/TopicsControllerDeleteTopicSubscriptionsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## GetSubscription

Retrieve a subscription by its unique identifier for a topic.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TopicsController_getTopicSubscription" method="get" path="/v2/topics/{topicKey}/subscriptions/{identifier}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.Subscriptions.GetSubscriptionAsync(
    topicKey: "<value>",
    identifier: "<value>"
);

// handle response
```

### Parameters

| Parameter                                 | Type                                      | Required                                  | Description                               |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| `TopicKey`                                | *string*                                  | :heavy_check_mark:                        | The key identifier of the topic           |
| `Identifier`                              | *string*                                  | :heavy_check_mark:                        | The unique identifier of the subscription |
| `IdempotencyKey`                          | *string*                                  | :heavy_minus_sign:                        | A header for idempotency purposes         |

### Response

**[TopicsControllerGetTopicSubscriptionResponse](../../Models/Requests/TopicsControllerGetTopicSubscriptionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Update

Update a subscription by its unique identifier for a topic. You can update the preferences and name associated with the subscription.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TopicsController_updateTopicSubscription" method="patch" path="/v2/topics/{topicKey}/subscriptions/{identifier}" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.Subscriptions.UpdateAsync(
    topicKey: "<value>",
    identifier: "<value>",
    updateTopicSubscriptionRequestDto: new UpdateTopicSubscriptionRequestDto() {
        Name = "My Subscription",
        Preferences = new List<UpdateTopicSubscriptionRequestDtoPreferences>() {
            UpdateTopicSubscriptionRequestDtoPreferences.CreateWorkflowPreferenceRequestDto(
                new WorkflowPreferenceRequestDto() {
                    Condition = new Dictionary<string, object>() {
                        { "===", new List<object>() {
                            new Dictionary<string, object>() {
                                { "var", "tier" },
                            },
                            "premium",
                        } },
                    },
                    WorkflowId = "workflow-123",
                }
            ),
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `TopicKey`                                                                                        | *string*                                                                                          | :heavy_check_mark:                                                                                | The key identifier of the topic                                                                   |
| `Identifier`                                                                                      | *string*                                                                                          | :heavy_check_mark:                                                                                | The unique identifier of the subscription                                                         |
| `UpdateTopicSubscriptionRequestDto`                                                               | [UpdateTopicSubscriptionRequestDto](../../Models/Components/UpdateTopicSubscriptionRequestDto.md) | :heavy_check_mark:                                                                                | N/A                                                                                               |
| `IdempotencyKey`                                                                                  | *string*                                                                                          | :heavy_minus_sign:                                                                                | A header for idempotency purposes                                                                 |

### Response

**[TopicsControllerUpdateTopicSubscriptionResponse](../../Models/Requests/TopicsControllerUpdateTopicSubscriptionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |