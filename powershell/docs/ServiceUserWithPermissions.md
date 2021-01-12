# ServiceUserWithPermissions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**User** | [**ApiUser**](ApiUser.md) |  | [optional] 
**PermissionLevels** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ServiceUserWithPermissions = New-Cloud.Governance.ClientServiceUserWithPermissions  -UserAssignBy null `
 -User null `
 -PermissionLevels null
```

- Convert the resource to JSON
```powershell
$ServiceUserWithPermissions | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

