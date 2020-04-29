# GroupValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**IsEditTask** | **Boolean** |  | [optional] [default to null]
**IsFromQuestionnaire** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGroupValidationParameter  -GroupId null `
 -IsEditTask null `
 -IsFromQuestionnaire null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

