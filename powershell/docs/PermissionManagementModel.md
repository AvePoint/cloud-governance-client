# PermissionManagementModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsUniquePermission** | **Boolean** |  | [optional] 
**IsPermissionInheritanceChanged** | **Boolean** |  | [optional] 
**IsCopyPermissionsFromParent** | **Boolean** |  | [optional] 
**InheritedSiteUrl** | **String** |  | [optional] 
**PermissionItems** | [**ObjectPermissionManagementModel[]**](ObjectPermissionManagementModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$PermissionManagementModel = New-Cloud.Governance.ClientPermissionManagementModel  -IsUniquePermission null `
 -IsPermissionInheritanceChanged null `
 -IsCopyPermissionsFromParent null `
 -InheritedSiteUrl null `
 -PermissionItems null
```

- Convert the resource to JSON
```powershell
$PermissionManagementModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

