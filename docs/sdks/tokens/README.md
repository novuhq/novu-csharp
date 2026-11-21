# Subscribers.Tokens

## Overview

### Available Operations

* [Create](#create) - Create a subscriber login token

## Create

Create a short-lived, Novu-signed login token for the subscriber identified by **subscriberId**.


    Call it from your backend with your secret key, then pass the token to the browser, which exchanges it for an Inbox session.
    Creating a token does not read or change the subscriber, so the subscriber does not need to exist yet.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="SubscribersController_createSubscriberToken" method="post" path="/v2/subscribers/{subscriberId}/tokens" -->
```csharp
using Novu;
using Novu.Models.Components;
using System.Collections.Generic;

var sdk = new NovuSDK(secretKey: "YOUR_SECRET_KEY_HERE");

var res = await sdk.Subscribers.Tokens.CreateAsync(
    subscriberId: "<id>",
    createSubscriberTokenRequestDto: new CreateSubscriberTokenRequestDto() {
        Context = new Dictionary<string, CreateSubscriberTokenRequestDtoContext>() {
            { "key", CreateSubscriberTokenRequestDtoContext.CreateStr(
                "org-acme"
            ) },
        },
        Subscriber = new BaseSubscriberFieldsDto() {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            Phone = "+1234567890",
            Avatar = "https://example.com/avatar.jpg",
            Locale = "en-US",
            Timezone = "America/New_York",
        },
        Scope = new List<SubscriberTokenScopeEnum>() {
            SubscriberTokenScopeEnum.ChannelsShared,
        },
        ExpiresIn = 600,
    }
);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `SubscriberId`                                                                                | *string*                                                                                      | :heavy_check_mark:                                                                            | The identifier of the subscriber                                                              |
| `CreateSubscriberTokenRequestDto`                                                             | [CreateSubscriberTokenRequestDto](../../Models/Components/CreateSubscriberTokenRequestDto.md) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `IdempotencyKey`                                                                              | *string*                                                                                      | :heavy_minus_sign:                                                                            | A header for idempotency purposes                                                             |

### Response

**[SubscribersControllerCreateSubscriberTokenResponse](../../Models/Requests/SubscribersControllerCreateSubscriberTokenResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| Novu.Models.Errors.ErrorDto            | 414                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 400, 401, 403, 404, 405, 409, 413, 415 | application/json                       |
| Novu.Models.Errors.ValidationErrorDto  | 422                                    | application/json                       |
| Novu.Models.Errors.ErrorDto            | 500                                    | application/json                       |
| Novu.Models.Errors.APIException        | 4XX, 5XX                               | \*/\*                                  |