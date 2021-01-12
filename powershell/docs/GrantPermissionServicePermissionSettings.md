# GrantPermissionServicePermissionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**IsGrantPermissionDirectly** | **Boolean** |  | [optional] 
**EnableExcludePermissionLevles** | **Boolean** |  | [optional] 
**ExcludedPermissionLevles** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GrantPermissionServicePermissionSettings = New-Cloud.Governance.ClientGrantPermissionServicePermissionSettings  -AssignBy null `
 -IsGrantPermissionDirectly null `
 -EnableExcludePermissionLevles null `
 -ExcludedPermissionLevles null
```

- Convert the resource to JSON
```powershell
$GrantPermissionServicePermissionSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

