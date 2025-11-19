# EventBody


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `Status`                                    | [Status](../../Models/Components/Status.md) | :heavy_check_mark:                          | Status of the event                         |
| `Date`                                      | *string*                                    | :heavy_check_mark:                          | Date of the event                           |
| `ExternalId`                                | *string*                                    | :heavy_minus_sign:                          | External ID from the provider               |
| `Attempts`                                  | *double*                                    | :heavy_minus_sign:                          | Number of attempts                          |
| `Response`                                  | *string*                                    | :heavy_minus_sign:                          | Response from the provider                  |
| `Row`                                       | *string*                                    | :heavy_minus_sign:                          | Raw content from the provider webhook       |