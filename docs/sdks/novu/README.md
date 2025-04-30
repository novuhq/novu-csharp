# Novu SDK

## Overview

Novu API: Novu REST API. Please see https://docs.novu.co/api-reference for more details.

Novu Documentation
<https://docs.novu.co>

### Available Operations

* [Trigger](#trigger) - Trigger event
* [Cancel](#cancel) - Cancel triggered event
* [Broadcast](#broadcast) - Broadcast event to all
* [TriggerBulk](#triggerbulk) - Bulk trigger event

## Trigger


    Trigger event is the main (and only) way to send notifications to subscribers. 
    The trigger identifier is used to match the particular workflow associated with it. 
    Additional information can be passed according the body interface below.
    

### Example Usage

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

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `TriggerEventRequestDto`                                                    | [TriggerEventRequestDto](../../Models/Components/TriggerEventRequestDto.md) | :heavy_check_mark:                                                          | N/A                                                                         |
| `IdempotencyKey`                                                            | *string*                                                                    | :heavy_minus_sign:                                                          | A header for idempotency purposes                                           |

### Response

**[EventsControllerTriggerResponse](../../Models/Requests/EventsControllerTriggerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Cancel


    Using a previously generated transactionId during the event trigger,
     will cancel any active or pending workflows. This is useful to cancel active digests, delays etc...
    

### Example Usage

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

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `TransactionId`                   | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[EventsControllerCancelResponse](../../Models/Requests/EventsControllerCancelResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Broadcast

Trigger a broadcast event to all existing subscribers, could be used to send announcements, etc.

      In the future could be used to trigger events to a subset of subscribers based on defined filters.

### Example Usage

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

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `TriggerEventToAllRequestDto`                                                         | [TriggerEventToAllRequestDto](../../Models/Components/TriggerEventToAllRequestDto.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `IdempotencyKey`                                                                      | *string*                                                                              | :heavy_minus_sign:                                                                    | A header for idempotency purposes                                                     |

### Response

**[EventsControllerBroadcastEventToAllResponse](../../Models/Requests/EventsControllerBroadcastEventToAllResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## TriggerBulk


      Using this endpoint you can trigger multiple events at once, to avoid multiple calls to the API.
      The bulk API is limited to 100 events per request.
    

### Example Usage

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

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `BulkTriggerEventDto`                                                 | [BulkTriggerEventDto](../../Models/Components/BulkTriggerEventDto.md) | :heavy_check_mark:                                                    | N/A                                                                   |
| `IdempotencyKey`                                                      | *string*                                                              | :heavy_minus_sign:                                                    | A header for idempotency purposes                                     |

### Response

**[EventsControllerTriggerBulkResponse](../../Models/Requests/EventsControllerTriggerBulkResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |