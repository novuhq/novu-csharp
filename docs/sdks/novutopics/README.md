# Subscribers.Topics

## Overview

### Available Operations

* [List](#list) - Retrieve subscriber subscriptions

## List

Retrieve subscriber's topic subscriptions by its unique key identifier **subscriberId**. 
    Checkout all available filters in the query section.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_listSubscriberTopics" method="get" path="/v2/subscribers/{subscriberId}/subscriptions" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

SubscribersControllerListSubscriberTopicsRequest req = new SubscribersControllerListSubscriberTopicsRequest() {
    SubscriberId = "<id>",
    Limit = 10D,
};

var res = await sdk.Subscribers.Topics.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                     | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                     | [SubscribersControllerListSubscriberTopicsRequest](../../Models/Requests/SubscribersControllerListSubscriberTopicsRequest.md) | :heavy_check_mark:                                                                                                            | The request object to use for the request.                                                                                    |

### Response

**[SubscribersControllerListSubscriberTopicsResponse](../../Models/Requests/SubscribersControllerListSubscriberTopicsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |