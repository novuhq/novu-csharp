# Agents

## Overview

Agents are conversational assistants that receive inbound messages from connected channels and respond through a custom code bridge or a managed runtime provider.
<https://docs.novu.co/agents>

### Available Operations

* [Create](#create) - Create an agent
* [List](#list) - List all agents
* [SendReply](#sendreply) - Send an agent reply
* [Retrieve](#retrieve) - Retrieve an agent
* [Update](#update) - Update an agent
* [Delete](#delete) - Delete an agent
* [UpdateBridge](#updatebridge) - Update an agent bridge

## Create

Create an agent scoped to the current environment. The identifier must be unique per environment. Set `runtime` to `managed` and supply `managedRuntime` to provision a provider-hosted agent brain.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="AgentsController_createAgent" method="post" path="/v1/agents" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.CreateAsync(
    novuAnalyticsSource: "<value>",
    createAgentRequestDto: new CreateAgentRequestDto() {
        Name = "<value>",
        Identifier = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `NovuAnalyticsSource`                                                     | *string*                                                                  | :heavy_check_mark:                                                        | N/A                                                                       |
| `CreateAgentRequestDto`                                                   | [CreateAgentRequestDto](../../Models/Components/CreateAgentRequestDto.md) | :heavy_check_mark:                                                        | N/A                                                                       |
| `IdempotencyKey`                                                          | *string*                                                                  | :heavy_minus_sign:                                                        | A header for idempotency purposes                                         |

### Response

**[AgentsControllerCreateAgentResponse](../../Models/Requests/AgentsControllerCreateAgentResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## List

Retrieve a cursor-paginated list of agents for the current environment. Use **after**, **before**, **limit**, **orderBy**, and **orderDirection** query parameters.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="AgentsController_listAgents" method="get" path="/v1/agents" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

AgentsControllerListAgentsRequest req = new AgentsControllerListAgentsRequest() {
    Limit = 10D,
};

var res = await sdk.Agents.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [AgentsControllerListAgentsRequest](../../Models/Requests/AgentsControllerListAgentsRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[AgentsControllerListAgentsResponse](../../Models/Requests/AgentsControllerListAgentsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## SendReply

Send a message or side-effect into an existing agent conversation from your backend.

Use this endpoint when you are not using `@novu/framework` (for example Python, Go, PHP, .NET, or Java SDKs),
or when a server process outside the bridge needs to post into a live conversation.

**Message actions**
- `reply` — markdown, interactive card, or tool-approval card (optional `files`)
- `edit` — update a previously delivered message in place
- `deleteMessages` — remove rendered platform messages (history is kept)
- `addReactions` — add emoji reactions to existing messages

**Turn control**
- `typing` — `{ status?: string }` to set status, or `"stop"` to clear
- `resolve` — mark the conversation resolved (optionally with a final reply)
- `error: true` — report a customer-runtime failure (cannot combine with other actions)

**Signals & tools**
- `signals` — metadata set/delete/clear, or trigger a Novu workflow
- `toolResults` — persist tool outputs into conversation history
- `toolApprovalRequest` — ledger a gated tool call (pair with an approval card reply)

Returns `{ data: { messageId, platformThreadId } }` when a reply or edit is delivered;
otherwise `{ data: null }`.

### Example Usage: addReaction

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="addReaction" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        AddReactions = new List<AddReactionPayloadDto>() {
            new AddReactionPayloadDto() {
                MessageId = "1712345678.123456",
                EmojiName = "white_check_mark",
            },
        },
    }
);

// handle response
```
### Example Usage: cardReply

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="cardReply" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        Reply = Reply.CreateCardReplyContentDto(
            new CardReplyContentDto() {
                Card = new Dictionary<string, object>() {
                    { "type", "card" },
                    { "title", "Order #123" },
                    { "children", new List<object>() {
                        new Dictionary<string, object>() {
                            { "type", "text" },
                            { "content", "Your order is ready for pickup." },
                        },
                        new Dictionary<string, object>() {
                            { "type", "button" },
                            { "id", "confirm" },
                            { "label", "Confirm" },
                            { "style", "primary" },
                        },
                    } },
                },
            }
        ),
    }
);

// handle response
```
### Example Usage: deleteMessage

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="deleteMessage" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        DeleteMessages = new List<DeleteMessagePayloadDto>() {
            new DeleteMessagePayloadDto() {
                MessageId = "1712345678.123456",
            },
        },
    }
);

// handle response
```
### Example Usage: editMessage

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="editMessage" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        Edit = new EditPayloadDto() {
            MessageId = "1712345678.123456",
            Content = Content.CreateMarkdownReplyContentDto(
                new MarkdownReplyContentDto() {
                    Markdown = "Updated: the report is now final.",
                }
            ),
        },
    }
);

// handle response
```
### Example Usage: markdownReply

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="markdownReply" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        Reply = Reply.CreateMarkdownReplyContentDto(
            new MarkdownReplyContentDto() {
                Markdown = "**Report ready.** Your weekly summary is attached.",
            }
        ),
    }
);

// handle response
```
### Example Usage: metadataSignal

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="metadataSignal" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        Signals = new List<Signals>() {
            Signals.CreateTriggerSignalDto(
                new TriggerSignalDto() {
                    Type = TriggerSignalDtoType.Trigger,
                    WorkflowId = "order-shipped",
                    To = To.CreateStr(
                        "subscriber-123"
                    ),
                    Payload = new Dictionary<string, object>() {
                        { "orderId", "ORD-42" },
                    },
                }
            ),
        },
    }
);

// handle response
```
### Example Usage: replyWithFile

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="replyWithFile" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        Reply = Reply.CreateMarkdownReplyContentDto(
            new MarkdownReplyContentDto() {
                Markdown = "Here is your report.",
                Files = new List<FileRefDto>() {
                    new FileRefDto() {
                        Filename = "report.pdf",
                        MimeType = "application/pdf",
                        Url = "https://example.com/files/report.pdf",
                    },
                },
            }
        ),
    }
);

// handle response
```
### Example Usage: resolveConversation

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="resolveConversation" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        Reply = Reply.CreateMarkdownReplyContentDto(
            new MarkdownReplyContentDto() {
                Markdown = "Glad that helped — marking this as resolved.",
            }
        ),
        Resolve = new ResolveDto() {
            Summary = "Answered billing question about invoice INV-42.",
        },
    }
);

// handle response
```
### Example Usage: toolApprovalRequest

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="toolApprovalRequest" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        Reply = Reply.CreateToolApprovalCardReplyContentDto(
            new ToolApprovalCardReplyContentDto() {
                ToolApprovalCard = new Dictionary<string, object>() {
                    { "type", "tool-approval-card" },
                    { "title", "Approve refund?" },
                    { "subtitle", "issue_refund · ORD-42 · $25.00" },
                    { "approveLabel", "Approve" },
                    { "denyLabel", "Deny" },
                },
            }
        ),
        ToolApprovalRequest = new ToolApprovalRequestPayloadDto() {
            ApprovalId = "apr_01HZX",
            ToolCallId = "call_refund_1",
            Name = "issue_refund",
            Input = new Dictionary<string, object>() {
                { "orderId", "ORD-42" },
                { "amountCents", 2500 },
            },
        },
    }
);

// handle response
```
### Example Usage: toolResult

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="toolResult" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        Reply = Reply.CreateMarkdownReplyContentDto(
            new MarkdownReplyContentDto() {
                Markdown = "Your order **ORD-42** has shipped and should arrive by July 16.",
            }
        ),
        ToolResults = new List<ToolResultDto>() {
            new ToolResultDto() {
                ToolCallId = "call_abc123",
                ToolName = "lookup_order",
                Output = new Output() {},
                Preview = "Order ORD-42 is shipped",
            },
        },
    }
);

// handle response
```
### Example Usage: triggerWorkflow

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="triggerWorkflow" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        Signals = new List<Signals>() {
            Signals.CreateTriggerSignalDto(
                new TriggerSignalDto() {
                    Type = TriggerSignalDtoType.Trigger,
                    WorkflowId = "order-shipped",
                    To = To.CreateStr(
                        "subscriber-123"
                    ),
                    Payload = new Dictionary<string, object>() {
                        { "orderId", "ORD-42" },
                    },
                }
            ),
        },
    }
);

// handle response
```
### Example Usage: turnError

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="turnError" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        Error = true,
    }
);

// handle response
```
### Example Usage: typingStart

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="typingStart" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        Typing = Typing.CreateTypingStatusDto(
            new TypingStatusDto() {
                Status = "Looking up your order…",
            }
        ),
    }
);

// handle response
```
### Example Usage: typingStop

<!-- UsageSnippet language="csharp" operationID="AgentReplyController_handleAgentReplyHandler" method="post" path="/v1/agents/{agentId}/reply" example="typingStop" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.SendReplyAsync(
    agentId: "support-agent",
    agentReplyPayloadDto: new AgentReplyPayloadDto() {
        ConversationId = "64f5a1c2e8b7a3d9f0c1b2a3",
        IntegrationIdentifier = "slack-support",
        Typing = Typing.CreateTyping1(
            Typing1.Stop
        ),
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                       | Type                                                                                                                                                                                                                                            | Required                                                                                                                                                                                                                                        | Description                                                                                                                                                                                                                                     | Example                                                                                                                                                                                                                                         |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AgentId`                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                              | Agent identifier (slug) for the agent that owns the conversation.                                                                                                                                                                               | support-agent                                                                                                                                                                                                                                   |
| `AgentReplyPayloadDto`                                                                                                                                                                                                                          | [AgentReplyPayloadDto](../../Models/Components/AgentReplyPayloadDto.md)                                                                                                                                                                         | :heavy_check_mark:                                                                                                                                                                                                                              | Reply payload. Provide at least one action: `reply`, `edit`, `resolve`, `signals`, `toolResults`, `toolApprovalRequest`, `addReactions`, `deleteMessages`, `typing`, or `error`. See named examples for common shapes used by server-side SDKs. |                                                                                                                                                                                                                                                 |
| `IdempotencyKey`                                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                              | A header for idempotency purposes                                                                                                                                                                                                               |                                                                                                                                                                                                                                                 |

### Response

**[AgentReplyControllerHandleAgentReplyHandlerResponse](../../Models/Requests/AgentReplyControllerHandleAgentReplyHandlerResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 405, 409, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |

## Retrieve

Retrieve an agent by its external identifier (not the internal MongoDB id).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="AgentsController_getAgent" method="get" path="/v1/agents/{identifier}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.RetrieveAsync(identifier: "<value>");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Identifier`                      | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[AgentsControllerGetAgentResponse](../../Models/Requests/AgentsControllerGetAgentResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 405, 409, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |

## Update

Update an agent by its external identifier.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="AgentsController_updateAgent" method="patch" path="/v1/agents/{identifier}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.UpdateAsync(
    identifier: "<value>",
    updateAgentRequestDto: new UpdateAgentRequestDto() {}
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `Identifier`                                                              | *string*                                                                  | :heavy_check_mark:                                                        | N/A                                                                       |
| `UpdateAgentRequestDto`                                                   | [UpdateAgentRequestDto](../../Models/Components/UpdateAgentRequestDto.md) | :heavy_check_mark:                                                        | N/A                                                                       |
| `IdempotencyKey`                                                          | *string*                                                                  | :heavy_minus_sign:                                                        | A header for idempotency purposes                                         |

### Response

**[AgentsControllerUpdateAgentResponse](../../Models/Requests/AgentsControllerUpdateAgentResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 405, 409, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |

## Delete

Delete an agent by identifier and remove all agent-integration links. For managed-runtime agents, pass `deleteFromProvider=true` to also archive the agent on the provider side (e.g. Anthropic). By default only the Novu record is deleted and the provider agent is left intact.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="AgentsController_deleteAgent" method="delete" path="/v1/agents/{identifier}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.DeleteAsync(
    identifier: "<value>",
    deleteFromProvider: "<value>"
);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Identifier`                      | *string*                          | :heavy_check_mark:                | N/A                               |
| `DeleteFromProvider`              | *string*                          | :heavy_check_mark:                | N/A                               |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |

### Response

**[AgentsControllerDeleteAgentResponse](../../Models/Requests/AgentsControllerDeleteAgentResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 405, 409, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |

## UpdateBridge

Update the bridge URL configuration for an agent. Used by the CLI to register dev tunnel URLs. Refuses to activate dev bridges on production environments.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="AgentsController_updateAgentBridge" method="put" path="/v1/agents/{identifier}/bridge" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Agents.UpdateBridgeAsync(
    identifier: "<value>",
    updateAgentBridgeRequestDto: new UpdateAgentBridgeRequestDto() {}
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Identifier`                                                                          | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `UpdateAgentBridgeRequestDto`                                                         | [UpdateAgentBridgeRequestDto](../../Models/Components/UpdateAgentBridgeRequestDto.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `IdempotencyKey`                                                                      | *string*                                                                              | :heavy_minus_sign:                                                                    | A header for idempotency purposes                                                     |

### Response

**[AgentsControllerUpdateAgentBridgeResponse](../../Models/Requests/AgentsControllerUpdateAgentBridgeResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| Novu.Models.Errors.ErrorDto           | 414                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 400, 401, 403, 405, 409, 413, 415     | application/json                      |
| Novu.Models.Errors.ValidationErrorDto | 422                                   | application/json                      |
| Novu.Models.Errors.ErrorDto           | 500                                   | application/json                      |
| Novu.Models.Errors.APIException       | 4XX, 5XX                              | \*/\*                                 |