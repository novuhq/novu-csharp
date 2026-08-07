# AgentSkillInputDto


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `Type`                                                                      | [AgentSkillInputDtoType](../../Models/Components/AgentSkillInputDtoType.md) | :heavy_check_mark:                                                          | N/A                                                                         |
| `SkillId`                                                                   | *string*                                                                    | :heavy_check_mark:                                                          | Skill identifier, e.g. "xlsx" or "skill_01XJ5..."                           |
| `Version`                                                                   | [Models.Components.Version](../../Models/Components/Version.md)             | :heavy_minus_sign:                                                          | Version to pin. Omit for latest.                                            |