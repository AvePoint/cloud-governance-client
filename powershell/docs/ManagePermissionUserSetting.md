# ManagePermissionUserSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserLevelRestrictionType** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] [default to null]
**UserManagementSourceType** | [**UserManagementSourceType**](UserManagementSourceType.md) |  | [optional] [default to null]
**IsEnableShowAADGroupMembers** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientManagePermissionUserSetting  -UserLevelRestrictionType null `
 -UserManagementSourceType null `
 -IsEnableShowAADGroupMembers null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

