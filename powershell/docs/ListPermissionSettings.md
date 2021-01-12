# ListPermissionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StopInheritingPermissions** | **Boolean** |  | [optional] 
**UserPermissions** | [**RequestUserWithPermissions[]**](RequestUserWithPermissions.md) |  | [optional] 
**GroupPermissions** | [**RequestGroupWithPermissions[]**](RequestGroupWithPermissions.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ListPermissionSettings = New-Cloud.Governance.ClientListPermissionSettings  -StopInheritingPermissions null `
 -UserPermissions null `
 -GroupPermissions null
```

- Convert the resource to JSON
```powershell
$ListPermissionSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

