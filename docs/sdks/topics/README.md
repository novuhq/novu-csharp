# Topics
(*Topics*)

## Overview

Topics are a way to group subscribers together so that they can be notified of events at once. A topic is identified by a custom key. This can be helpful for things like sending out marketing emails or notifying users of new features. Topics can also be used to send notifications to the subscribers who have been grouped together based on their interests, location, activities and much more.
<https://docs.novu.co/subscribers/topics>

### Available Operations

* [Create](#create) - Topic creation
* [List](#list) - Get topic list filtered 
* [Delete](#delete) - Delete topic
* [Get](#get) - Get topic
* [Rename](#rename) - Rename a topic

## Create

Create a topic

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.CreateAsync(
    createTopicRequestDto: new CreateTopicRequestDto() {
        Key = "<key>",
        Name = "<value>",
    },
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `CreateTopicRequestDto`                                                   | [CreateTopicRequestDto](../../Models/Components/CreateTopicRequestDto.md) | :heavy_check_mark:                                                        | N/A                                                                       |
| `IdempotencyKey`                                                          | *string*                                                                  | :heavy_minus_sign:                                                        | A header for idempotency purposes                                         |

### Response

**[TopicsControllerCreateTopicResponse](../../Models/Requests/TopicsControllerCreateTopicResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## List

Returns a list of topics that can be paginated using the `page` query parameter and filtered by the topic key with the `key` query parameter

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.ListAsync(
    page: 0,
    pageSize: 10,
    key: "exampleKey",
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `Page`                                               | *long*                                               | :heavy_minus_sign:                                   | The page number to retrieve (starts from 0)          | 0                                                    |
| `PageSize`                                           | *long*                                               | :heavy_minus_sign:                                   | The number of items to return per page (default: 10) | 10                                                   |
| `Key`                                                | *string*                                             | :heavy_minus_sign:                                   | A filter key to apply to the results                 | exampleKey                                           |
| `IdempotencyKey`                                     | *string*                                             | :heavy_minus_sign:                                   | A header for idempotency purposes                    |                                                      |

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

## Delete

Delete a topic by its topic key if it has no subscribers

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.DeleteAsync(
    topicKey: "<value>",
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `TopicKey`                        | *string*                          | :heavy_check_mark:                | The topic key                     |
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

## Get

Get a topic by its topic key

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.GetAsync(
    topicKey: "<value>",
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `TopicKey`                        | *string*                          | :heavy_check_mark:                | The topic key                     |
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

## Rename

Rename a topic by providing a new name

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.RenameAsync(
    topicKey: "<value>",
    renameTopicRequestDto: new RenameTopicRequestDto() {
        Name = "<value>",
    },
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `TopicKey`                                                                | *string*                                                                  | :heavy_check_mark:                                                        | The topic key                                                             |
| `RenameTopicRequestDto`                                                   | [RenameTopicRequestDto](../../Models/Components/RenameTopicRequestDto.md) | :heavy_check_mark:                                                        | N/A                                                                       |
| `IdempotencyKey`                                                          | *string*                                                                  | :heavy_minus_sign:                                                        | A header for idempotency purposes                                         |

### Response

**[TopicsControllerRenameTopicResponse](../../Models/Requests/TopicsControllerRenameTopicResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |