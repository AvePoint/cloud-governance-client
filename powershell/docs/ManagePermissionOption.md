# ManagePermissionOption
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GrantPermissionSetting** | [**ManagePermissionGrantSetting**](ManagePermissionGrantSetting.md) |  | [optional] [default to null]
**IsEnableEditPermission** | **Boolean** |  | [optional] [default to null]
**IsEnableRemovePermission** | **Boolean** |  | [optional] [default to null]
**IsEnableStopInheritPermission** | **Boolean** |  | [optional] [default to null]
**IsEnableDeleteUniquePermission** | **Boolean** |  | [optional] [default to null]
**IsEnableExcludePermissionLevel** | **Boolean** |  | [optional] [default to null]
**IsHideExcludePermissionItem** | **Boolean** |  | [optional] [default to null]
**ExcludedPermissionLevles** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientManagePermissionOption  -GrantPermissionSetting null `
 -IsEnableEditPermission null `
 -IsEnableRemovePermission null `
 -IsEnableStopInheritPermission null `
 -IsEnableDeleteUniquePermission null `
 -IsEnableExcludePermissionLevel null `
 -IsHideExcludePermissionItem null `
 -ExcludedPermissionLevles null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

