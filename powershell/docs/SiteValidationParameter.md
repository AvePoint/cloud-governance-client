# SiteValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **String** |  | [optional] 
**IgnoreLock** | **Boolean** |  | [optional] [default to $false]
**IsEditTask** | **Boolean** |  | [optional] [default to $false]
**IsFromQuestionnaire** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$SiteValidationParameter = New-Cloud.Governance.ClientSiteValidationParameter  -Uri null `
 -IgnoreLock null `
 -IsEditTask null `
 -IsFromQuestionnaire null
```

- Convert the resource to JSON
```powershell
$SiteValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

