# UserGroupPermissions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserPermissions** | [**ServiceUserWithPermissions[]**](ServiceUserWithPermissions.md) |  | [optional] 
**GroupPermissions** | [**ServiceGroupWithPermissions[]**](ServiceGroupWithPermissions.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$UserGroupPermissions = New-Cloud.Governance.ClientUserGroupPermissions  -UserPermissions null `
 -GroupPermissions null
```

- Convert the resource to JSON
```powershell
$UserGroupPermissions | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

