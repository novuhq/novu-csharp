# Typing

Per-turn typing/status control. Pass `{ status?: string }` to set/update the status (omit `status` for "Thinking…"), or `"stop"` to clear it. Best-effort per platform.


## Supported Types

### Typing1

```csharp
Typing.CreateTyping1(/* values here */);
```

### TypingStatusDto

```csharp
Typing.CreateTypingStatusDto(/* values here */);
```
