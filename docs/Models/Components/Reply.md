# Reply

Outbound message content. Exactly one of `markdown`, `card`, or `toolApprovalCard`. Optional `files` attach to the message. Cannot be combined with `edit`.


## Supported Types

### MarkdownReplyContentDto

```csharp
Reply.CreateMarkdownReplyContentDto(/* values here */);
```

### CardReplyContentDto

```csharp
Reply.CreateCardReplyContentDto(/* values here */);
```

### ToolApprovalCardReplyContentDto

```csharp
Reply.CreateToolApprovalCardReplyContentDto(/* values here */);
```
