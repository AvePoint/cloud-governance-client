# ManagePermissionValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **String** |  | [optional] 
**IgnoreLock** | **Boolean** |  | [optional] [default to $false]
**IsKeepPageUrl** | **Boolean** |  | [optional] [default to $false]
**Office365TenantId** | **String** |  | [optional] 
**ScopeActivityId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManagePermissionValidationParameter = New-Cloud.Governance.ClientManagePermissionValidationParameter  -Uri null `
 -IgnoreLock null `
 -IsKeepPageUrl null `
 -Office365TenantId null `
 -ScopeActivityId null
```

- Convert the resource to JSON
```powershell
$ManagePermissionValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

