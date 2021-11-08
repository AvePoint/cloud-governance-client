# ContentMoveUrlValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsCheckSourceUrl** | **Boolean** |  | [optional] [default to $false]
**Uri** | **String** |  | [optional] 
**IgnoreLock** | **Boolean** |  | [optional] [default to $false]
**IsEditTask** | **Boolean** |  | [optional] [default to $false]
**IsFromQuestionnaire** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$ContentMoveUrlValidationParameter = New-Cloud.Governance.ClientContentMoveUrlValidationParameter  -IsCheckSourceUrl null `
 -Uri null `
 -IgnoreLock null `
 -IsEditTask null `
 -IsFromQuestionnaire null
```

- Convert the resource to JSON
```powershell
$ContentMoveUrlValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

