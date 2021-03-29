# CreateWebValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentUrl** | **String** |  | [optional] 
**Uri** | **String** |  | [optional] 
**IgnoreLock** | **Boolean** |  | [optional] [default to $false]
**IsEditTask** | **Boolean** |  | [optional] [default to $false]
**IsFromQuestionnaire** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$CreateWebValidationParameter = New-Cloud.Governance.ClientCreateWebValidationParameter  -ParentUrl null `
 -Uri null `
 -IgnoreLock null `
 -IsEditTask null `
 -IsFromQuestionnaire null
```

- Convert the resource to JSON
```powershell
$CreateWebValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

