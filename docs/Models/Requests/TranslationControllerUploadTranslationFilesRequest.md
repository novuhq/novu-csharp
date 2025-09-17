# TranslationControllerUploadTranslationFilesRequest


## Fields

| Field                                                                                   | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `IdempotencyKey`                                                                        | *string*                                                                                | :heavy_minus_sign:                                                                      | A header for idempotency purposes                                                       |
| `UploadTranslationsRequestDto`                                                          | [UploadTranslationsRequestDto](../../Models/Components/UploadTranslationsRequestDto.md) | :heavy_check_mark:                                                                      | Translation files upload body details                                                   |