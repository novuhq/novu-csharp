# TopicsSubscribers
(*TopicsSubscribers*)

## Overview

### Available Operations

* [Get](#get) - Check topic subscriber

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

**[TopicsV1ControllerGetTopicSubscriberResponse](../../Models/Requests/TopicsV1ControllerGetTopicSubscriberResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |