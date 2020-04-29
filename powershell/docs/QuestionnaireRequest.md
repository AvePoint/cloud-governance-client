# QuestionnaireRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Questions** | [**QuestionRequest[]**](QuestionRequest.md) |  | [optional] [default to null]
**Services** | [**UUID[]**](UUID.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientQuestionnaireRequest  -Id null `
 -Questions null `
 -Services null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

