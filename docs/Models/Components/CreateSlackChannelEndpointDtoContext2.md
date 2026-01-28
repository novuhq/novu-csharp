# CreateSlackChannelEndpointDtoContext2

Rich context object with id and optional data


## Fields

| Field                                          | Type                                           | Required                                       | Description                                    | Example                                        |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| `Id`                                           | *string*                                       | :heavy_check_mark:                             | N/A                                            | org-acme                                       |
| `Data`                                         | Dictionary<String, *object*>                   | :heavy_minus_sign:                             | Optional additional context data               | {<br/>"name": "Acme Corp",<br/>"region": "us-east-1"<br/>} |