<!-- Start SDK Example Usage [usage] -->
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
    Actor = Actor.CreateStr(
        "<value>"
    ),
    Context = new Dictionary<string, TriggerEventRequestDtoContext>() {
        { "key", TriggerEventRequestDtoContext.CreateStr(
            "org-acme"
        ) },
    },
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
    Actor = TriggerEventToAllRequestDtoActor.CreateSubscriberPayloadDto(
        new SubscriberPayloadDto() {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            Phone = "+1234567890",
            Avatar = "https://example.com/avatar.jpg",
            Locale = "en-US",
            Timezone = "America/New_York",
            SubscriberId = "<id>",
        }
    ),
    Context = new Dictionary<string, TriggerEventToAllRequestDtoContext>() {
        { "key", TriggerEventToAllRequestDtoContext.CreateStr(
            "org-acme"
        ) },
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