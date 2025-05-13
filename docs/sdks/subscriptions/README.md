# Subscriptions
(*Topics.Subscriptions*)

## Overview

### Available Operations

* [List](#list) - List topic subscriptions
* [Create](#create) - Create topic subscriptions, if the topic does not exist, it will be created.
* [Delete](#delete) - Delete topic subscriptions

## List

List topic subscriptions

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

TopicsControllerListTopicSubscriptionsRequest req = new TopicsControllerListTopicSubscriptionsRequest() {
    TopicKey = "<value>",
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

Create topic subscriptions, if the topic does not exist, it will be created.

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.Subscriptions.CreateAsync(
    topicKey: "<value>",
    createTopicSubscriptionsRequestDto: new CreateTopicSubscriptionsRequestDto() {
        SubscriberIds = new List<string>() {
            "subscriberId1",
            "subscriberId2",
        },
    },
    idempotencyKey: "<value>"
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

Delete topic subscriptions

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Topics.Subscriptions.DeleteAsync(
    topicKey: "<value>",
    deleteTopicSubscriptionsRequestDto: new DeleteTopicSubscriptionsRequestDto() {
        SubscriberIds = new List<string>() {
            "subscriberId1",
            "subscriberId2",
        },
    },
    idempotencyKey: "<value>"
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