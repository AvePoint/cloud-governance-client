# PermissionManagementModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsUniquePermission** | **Boolean** |  | [optional] [default to null]
**IsPermissionInheritanceChanged** | **Boolean** |  | [optional] [default to null]
**IsCopyPermissionsFromParent** | **Boolean** |  | [optional] [default to null]
**InheritedSiteUrl** | **String** |  | [optional] [default to null]
**PermissionItems** | [**ObjectPermissionManagementModel[]**](ObjectPermissionManagementModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientPermissionManagementModel  -IsUniquePermission null `
 -IsPermissionInheritanceChanged null `
 -IsCopyPermissionsFromParent null `
 -InheritedSiteUrl null `
 -PermissionItems null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

