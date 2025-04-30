# ConstraintValidation


## Fields

| Field                                     | Type                                      | Required                                  | Description                               | Example                                   |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| `Messages`                                | List<*string*>                            | :heavy_check_mark:                        | List of validation error messages         | [<br/>"Field is required",<br/>"Invalid format"<br/>] |
| `Value`                                   | [Value](../../Models/Components/Value.md) | :heavy_minus_sign:                        | Value that failed validation              | xx xx xx                                  |