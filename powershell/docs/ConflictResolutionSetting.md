# ConflictResolutionSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContainerConflictSolution** | [**ConflictSolutionType**](ConflictSolutionType.md) |  | [optional] 
**IsCheckLowerObject** | **Boolean** |  | [optional] [default to $false]
**IsEnableContentConflictResolution** | **Boolean** |  | [optional] [default to $false]
**ContentConflictSolution** | [**ConflictSolutionType**](ConflictSolutionType.md) |  | [optional] 
**AppConflictSolution** | [**ConflictSolutionType**](ConflictSolutionType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ConflictResolutionSetting = New-Cloud.Governance.ClientConflictResolutionSetting  -ContainerConflictSolution null `
 -IsCheckLowerObject null `
 -IsEnableContentConflictResolution null `
 -ContentConflictSolution null `
 -AppConflictSolution null
```

- Convert the resource to JSON
```powershell
$ConflictResolutionSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

