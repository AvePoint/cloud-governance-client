# ConflictResolutionSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContainerConflictSolution** | [**ConflictSolutionType**](ConflictSolutionType.md) |  | [optional] [default to null]
**IsCheckLowerObject** | **Boolean** |  | [optional] [default to null]
**IsEnableContentConflictResolution** | **Boolean** |  | [optional] [default to null]
**ContentConflictSolution** | [**ConflictSolutionType**](ConflictSolutionType.md) |  | [optional] [default to null]
**AppConflictSolution** | [**ConflictSolutionType**](ConflictSolutionType.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientConflictResolutionSetting  -ContainerConflictSolution null `
 -IsCheckLowerObject null `
 -IsEnableContentConflictResolution null `
 -ContentConflictSolution null `
 -AppConflictSolution null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

