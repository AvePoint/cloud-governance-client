# ManagePermissionServiceUserScopeSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserLevelRestrictionType** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] 
**UserManagementSourceType** | [**UserManagementSourceType**](UserManagementSourceType.md) |  | [optional] 
**IsEnableShowAADGroupMembers** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$ManagePermissionServiceUserScopeSetting = New-Cloud.Governance.ClientManagePermissionServiceUserScopeSetting  -UserLevelRestrictionType null `
 -UserManagementSourceType null `
 -IsEnableShowAADGroupMembers null
```

- Convert the resource to JSON
```powershell
$ManagePermissionServiceUserScopeSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

