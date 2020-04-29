# CreateWebValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentUrl** | [**URI**](URI.md) |  | [optional] [default to null]
**Uri** | [**URI**](URI.md) |  | [optional] [default to null]
**IgnoreLock** | **Boolean** |  | [optional] [default to null]
**IsEditTask** | **Boolean** |  | [optional] [default to null]
**IsFromQuestionnaire** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientCreateWebValidationParameter  -ParentUrl null `
 -Uri null `
 -IgnoreLock null `
 -IsEditTask null `
 -IsFromQuestionnaire null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

