# InAppRenderOutput


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `Subject`                                             | *string*                                              | :heavy_minus_sign:                                    | Subject of the in-app notification                    |
| `Body`                                                | *string*                                              | :heavy_check_mark:                                    | Body of the in-app notification                       |
| `Avatar`                                              | *string*                                              | :heavy_minus_sign:                                    | Avatar for the in-app notification                    |
| `PrimaryAction`                                       | [ActionDto](../../Models/Components/ActionDto.md)     | :heavy_minus_sign:                                    | Primary action details                                |
| `SecondaryAction`                                     | [ActionDto](../../Models/Components/ActionDto.md)     | :heavy_minus_sign:                                    | Secondary action details                              |
| `Data`                                                | Dictionary<String, *object*>                          | :heavy_minus_sign:                                    | Additional data                                       |
| `Redirect`                                            | [RedirectDto](../../Models/Components/RedirectDto.md) | :heavy_minus_sign:                                    | Redirect details                                      |