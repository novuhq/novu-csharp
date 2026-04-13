# SubscribersControllerPatchSubscriberRequest


## Fields

| Field                                                                             | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `SubscriberId`                                                                    | *string*                                                                          | :heavy_check_mark:                                                                | The identifier of the subscriber                                                  |
| `IdempotencyKey`                                                                  | *string*                                                                          | :heavy_minus_sign:                                                                | A header for idempotency purposes                                                 |
| `PatchSubscriberRequestDto`                                                       | [PatchSubscriberRequestDto](../../Models/Components/PatchSubscriberRequestDto.md) | :heavy_check_mark:                                                                | N/A                                                                               |