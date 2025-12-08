# SharedMailboxLifecycleValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeActivityId** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**ObjectId** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**Type** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SharedMailboxLifecycleValidationParameter = New-Cloud.Governance.ClientSharedMailboxLifecycleValidationParameter  -ScopeActivityId null `
 -TenantId null `
 -ObjectId null `
 -DisplayName null `
 -Email null `
 -Type null
```

- Convert the resource to JSON
```powershell
$SharedMailboxLifecycleValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

