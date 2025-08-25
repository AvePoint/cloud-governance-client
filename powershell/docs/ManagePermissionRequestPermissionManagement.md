# ManagePermissionRequestPermissionManagement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsUniquePermission** | **Boolean** |  | [optional] [default to $false]
**IsPermissionInheritanceChanged** | **Boolean** |  | [optional] [default to $false]
**IsCopyPermissionsFromParent** | **Boolean** |  | [optional] [default to $false]
**InheritedSiteUrl** | **String** |  | [optional] 
**PermissionItems** | [**ObjectPermissionManagementModel[]**](ObjectPermissionManagementModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManagePermissionRequestPermissionManagement = New-Cloud.Governance.ClientManagePermissionRequestPermissionManagement  -IsUniquePermission null `
 -IsPermissionInheritanceChanged null `
 -IsCopyPermissionsFromParent null `
 -InheritedSiteUrl null `
 -PermissionItems null
```

- Convert the resource to JSON
```powershell
$ManagePermissionRequestPermissionManagement | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

