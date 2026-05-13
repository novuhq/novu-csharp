# DomainsControllerUpdateDomainRequest


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `Domain`                                                      | *string*                                                      | :heavy_check_mark:                                            | N/A                                                           |
| `IdempotencyKey`                                              | *string*                                                      | :heavy_minus_sign:                                            | A header for idempotency purposes                             |
| `UpdateDomainDto`                                             | [UpdateDomainDto](../../Models/Components/UpdateDomainDto.md) | :heavy_check_mark:                                            | N/A                                                           |