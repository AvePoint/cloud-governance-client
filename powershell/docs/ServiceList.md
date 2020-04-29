# ServiceList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Category** | **String** |  | [optional] [default to null]
**Contact** | **String** |  | [optional] [default to null]
**LanguageId** | **Int32** |  | [optional] [default to null]
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] [default to null]
**TypeDescription** | **String** |  | [optional] [readonly] [default to null]
**IsQuestionnaire** | **Boolean** |  | [optional] [default to null]
**QuestionnaireId** | [**UUID**](UUID.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientServiceList  -Id null `
 -Name null `
 -Description null `
 -Category null `
 -Contact null `
 -LanguageId null `
 -Type null `
 -TypeDescription null `
 -IsQuestionnaire null `
 -QuestionnaireId null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

