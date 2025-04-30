# TopicsSubscribers
(*TopicsSubscribers*)

## Overview

### Available Operations

* [Add](#add) - Subscribers addition
* [Get](#get) - Check topic subscriber
* [Remove](#remove) - Subscribers removal

## Add

Add subscribers to a topic by key

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.TopicsSubscribers.AddAsync(
    topicKey: "<value>",
    addSubscribersRequestDto: new AddSubscribersRequestDto() {
        Subscribers = new List<string>() {
            "<value>",
        },
    },
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `TopicKey`                                                                      | *string*                                                                        | :heavy_check_mark:                                                              | The topic key                                                                   |
| `AddSubscribersRequestDto`                                                      | [AddSubscribersRequestDto](../../Models/Components/AddSubscribersRequestDto.md) | :heavy_check_mark:                                                              | N/A                                                                             |
| `IdempotencyKey`                                                                | *string*                                                                        | :heavy_minus_sign:                                                              | A header for idempotency purposes                                               |

### Response

**[TopicsControllerAssignResponse](../../Models/Requests/TopicsControllerAssignResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Get

Check if a subscriber belongs to a certain topic

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.TopicsSubscribers.GetAsync(
    externalSubscriberId: "<id>",
    topicKey: "<value>",
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `ExternalSubscriberId`            | *string*                          | :heavy_check_mark:                | The external subscriber id        |
| `TopicKey`                        | *string*                          | :heavy_check_mark:                | The topic key                     |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[TopicsControllerGetTopicSubscriberResponse](../../Models/Requests/TopicsControllerGetTopicSubscriberResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Remove

Remove subscribers from a topic

### Example Usage

```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.TopicsSubscribers.RemoveAsync(
    topicKey: "<value>",
    removeSubscribersRequestDto: new RemoveSubscribersRequestDto() {
        Subscribers = new List<string>() {
            "<value>",
        },
    },
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `TopicKey`                                                                            | *string*                                                                              | :heavy_check_mark:                                                                    | The topic key                                                                         |
| `RemoveSubscribersRequestDto`                                                         | [RemoveSubscribersRequestDto](../../Models/Components/RemoveSubscribersRequestDto.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `IdempotencyKey`                                                                      | *string*                                                                              | :heavy_minus_sign:                                                                    | A header for idempotency purposes                                                     |

### Response

**[TopicsControllerRemoveSubscribersResponse](../../Models/Requests/TopicsControllerRemoveSubscribersResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |