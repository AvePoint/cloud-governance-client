# ManagePermissionUserSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserLevelRestrictionType** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] 
**UserManagementSourceType** | [**UserManagementSourceType**](UserManagementSourceType.md) |  | [optional] 
**IsEnableShowAADGroupMembers** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManagePermissionUserSetting = New-Cloud.Governance.ClientManagePermissionUserSetting  -UserLevelRestrictionType null `
 -UserManagementSourceType null `
 -IsEnableShowAADGroupMembers null
```

- Convert the resource to JSON
```powershell
$ManagePermissionUserSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

