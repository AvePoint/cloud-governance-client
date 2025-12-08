# ManagePermissionOption
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GrantPermissionSetting** | [**ManagePermissionGrantSetting**](ManagePermissionGrantSetting.md) |  | [optional] 
**IsEnableEditPermission** | **Boolean** |  | [optional] [default to $false]
**IsEnableRemovePermission** | **Boolean** |  | [optional] [default to $false]
**IsEnableStopInheritPermission** | **Boolean** |  | [optional] [default to $false]
**IsEnableDeleteUniquePermission** | **Boolean** |  | [optional] [default to $false]
**IsEnableExcludePermissionLevel** | **Boolean** |  | [optional] [default to $false]
**IsHideExcludePermissionItem** | **Boolean** |  | [optional] [default to $false]
**ExcludedPermissionLevles** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManagePermissionOption = New-Cloud.Governance.ClientManagePermissionOption  -GrantPermissionSetting null `
 -IsEnableEditPermission null `
 -IsEnableRemovePermission null `
 -IsEnableStopInheritPermission null `
 -IsEnableDeleteUniquePermission null `
 -IsEnableExcludePermissionLevel null `
 -IsHideExcludePermissionItem null `
 -ExcludedPermissionLevles null
```

- Convert the resource to JSON
```powershell
$ManagePermissionOption | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

