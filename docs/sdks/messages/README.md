# Messages

## Overview

A message in Novu represents a notification delivered to a recipient on a particular channel. Messages contain information about the request that triggered its delivery, a view of the data sent to the recipient, and a timeline of its lifecycle events. Learn more about messages.
<https://docs.novu.co/workflows/messages>

### Available Operations

* [Get](#get) - List all messages
* [Delete](#delete) - Delete a message
* [DeleteByTransactionId](#deletebytransactionid) - Delete messages by transactionId

## Get

List all messages for the current environment. 
    This API supports filtering by **channel**, **subscriberId**, and **transactionId**. 
    This API returns a paginated list of messages.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="MessagesController_getMessages" method="get" path="/v1/messages" -->
```csharp
using Novu;
using Novu.Models.Components;
using Novu.Models.Requests;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

MessagesControllerGetMessagesRequest req = new MessagesControllerGetMessagesRequest() {
    ContextKeys = new List<string>() {
        "tenant:org-123",
        "region:us-east-1",
    },
};

var res = await sdk.Messages.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [MessagesControllerGetMessagesRequest](../../Models/Requests/MessagesControllerGetMessagesRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[MessagesControllerGetMessagesResponse](../../Models/Requests/MessagesControllerGetMessagesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## Delete

Delete a message entity from the Novu platform by **messageId**. 
    This action is irreversible. **messageId** is required and of mongodbId type.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="MessagesController_deleteMessage" method="delete" path="/v1/messages/{messageId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Messages.DeleteAsync(messageId: "507f1f77bcf86cd799439011");

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       | Example                           |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `MessageId`                       | *string*                          | :heavy_check_mark:                | N/A                               | 507f1f77bcf86cd799439011          |
| `IdempotencyKey`                  | *string*                          | :heavy_minus_sign:                | A header for idempotency purposes |                                   |

### Response

**[MessagesControllerDeleteMessageResponse](../../Models/Requests/MessagesControllerDeleteMessageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |

## DeleteByTransactionId

Delete multiple messages from the Novu platform using **transactionId** of triggered event. 
    This API supports filtering by **channel** and delete all messages associated with the **transactionId**.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="MessagesController_deleteMessagesByTransactionId" method="delete" path="/v1/messages/transaction/{transactionId}" -->
```csharp
using Novu;
using Novu.Models.Components;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Messages.DeleteByTransactionIdAsync(transactionId: "507f1f77bcf86cd799439011");

// handle response
```

### Parameters

| Parameter                                                                                                                                                     | Type                                                                                                                                                          | Required                                                                                                                                                      | Description                                                                                                                                                   | Example                                                                                                                                                       |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `TransactionId`                                                                                                                                               | *string*                                                                                                                                                      | :heavy_check_mark:                                                                                                                                            | N/A                                                                                                                                                           | 507f1f77bcf86cd799439011                                                                                                                                      |
| `Channel`                                                                                                                                                     | [MessagesControllerDeleteMessagesByTransactionIdQueryParamChannel](../../Models/Requests/MessagesControllerDeleteMessagesByTransactionIdQueryParamChannel.md) | :heavy_minus_sign:                                                                                                                                            | The channel of the message to be deleted                                                                                                                      |                                                                                                                                                               |
| `IdempotencyKey`                                                                                                                                              | *string*                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                            | A header for idempotency purposes                                                                                                                             |                                                                                                                                                               |

### Response

**[MessagesControllerDeleteMessagesByTransactionIdResponse](../../Models/Requests/MessagesControllerDeleteMessagesByTransactionIdResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |