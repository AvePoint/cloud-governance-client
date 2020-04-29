# QuestionnaireGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**LanguageID** | **Int32** |  | [optional] [default to null]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] [default to null]
**StatusDescription** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientQuestionnaireGridModel  -Id null `
 -Name null `
 -Description null `
 -LanguageID null `
 -Status null `
 -StatusDescription null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

