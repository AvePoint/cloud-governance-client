# QuestionnaireModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Category** | **String** |  | [optional] [default to null]
**Questions** | [**QuestionItem[]**](QuestionItem.md) |  | [optional] [default to null]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] [default to null]
**LanguageID** | **Int32** |  | [optional] [default to null]
**Permissions** | [**ServicePermissionSettings**](ServicePermissionSettings.md) |  | [optional] [default to null]
**Details** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientQuestionnaireModel  -Id null `
 -Name null `
 -Description null `
 -Category null `
 -Questions null `
 -Status null `
 -LanguageID null `
 -Permissions null `
 -Details null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

