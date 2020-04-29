# QuestionnaireRef
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Questions** | [**Question[]**](Question.md) |  | [optional] [default to null]
**Node** | [**QuestionnaireNode**](QuestionnaireNode.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientQuestionnaireRef  -Id null `
 -Name null `
 -Description null `
 -Questions null `
 -Node null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

