# Topics
(*Topics*)

## Overview

Topics are a way to group subscribers together so that they can be notified of events at once. A topic is identified by a custom key. This can be helpful for things like sending out marketing emails or notifying users of new features. Topics can also be used to send notifications to the subscribers who have been grouped together based on their interests, location, activities and much more.
<https://docs.novu.co/subscribers/topics>

### Available Operations

* [List](#list) - List all topics
* [Create](#create) - Create a topic
* [Get](#get) - Retrieve a topic
* [Update](#update) - Update a topic
* [Delete](#delete) - Delete a topic

## List

This api returns a paginated list of topics.
    Topics can be filtered by **key**, **name**, or **includeCursor** to paginate through the list. 
    Checkout all available filters in the query section.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TopicsController_listTopics" method="get" path="/v2/topics" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

TopicsControllerListTopicsRequest? req = null;

var res = await sdk.Topics.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [TopicsControllerListTopicsRequest](../../Models/Requests/TopicsControllerListTopicsRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[TopicsControllerListTopicsResponse](../../Models/Requests/TopicsControllerListTopicsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Create

Creates a new topic if it does not exist, or updates an existing topic if it already exists. Use ?failIfExists=true to prevent updates.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TopicsController_upsertTopic" method="post" path="/v2/topics" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.CreateAsync(
    failIfExists: true,
    createUpdateTopicRequestDto: new CreateUpdateTopicRequestDto() {
        Key = "task:12345",
        Name = "Task Title",
    }
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `FailIfExists`                                                                        | *bool*                                                                                | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `CreateUpdateTopicRequestDto`                                                         | [CreateUpdateTopicRequestDto](../../Models/Components/CreateUpdateTopicRequestDto.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `IdempotencyKey`                                                                      | *string*                                                                              | :heavy_minus_sign:                                                                    | A header for idempotency purposes                                                     |

### Response

**[TopicsControllerUpsertTopicResponse](../../Models/Requests/TopicsControllerUpsertTopicResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.TopicResponseDto   | 409                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 404, 405, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |

## Get

Retrieve a topic by its unique key identifier **topicKey**

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TopicsController_getTopic" method="get" path="/v2/topics/{topicKey}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.GetAsync(topicKey: "<value>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `TopicKey`                        | *string*                          | :heavy_check_mark:                | The key identifier of the topic   |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[TopicsControllerGetTopicResponse](../../Models/Requests/TopicsControllerGetTopicResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Update

Update a topic name by its unique key identifier **topicKey**

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TopicsController_updateTopic" method="patch" path="/v2/topics/{topicKey}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.UpdateAsync(
    topicKey: "<value>",
    updateTopicRequestDto: new UpdateTopicRequestDto() {
        Name = "Updated Topic Name",
    }
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `TopicKey`                                                                | *string*                                                                  | :heavy_check_mark:                                                        | The key identifier of the topic                                           |
| `UpdateTopicRequestDto`                                                   | [UpdateTopicRequestDto](../../Models/Components/UpdateTopicRequestDto.md) | :heavy_check_mark:                                                        | N/A                                                                       |
| `IdempotencyKey`                                                          | *string*                                                                  | :heavy_minus_sign:                                                        | A header for idempotency purposes                                         |

### Response

**[TopicsControllerUpdateTopicResponse](../../Models/Requests/TopicsControllerUpdateTopicResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Delete a topic by its unique key identifier **topicKey**. 
    This action is irreversible and will remove all subscriptions to the topic.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="TopicsController_deleteTopic" method="delete" path="/v2/topics/{topicKey}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.DeleteAsync(topicKey: "<value>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `TopicKey`                        | *string*                          | :heavy_check_mark:                | The key identifier of the topic   |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[TopicsControllerDeleteTopicResponse](../../Models/Requests/TopicsControllerDeleteTopicResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |