# ListPermissionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StopInheritingPermissions** | **Boolean** |  | [optional] [default to null]
**UserPermissions** | [**RequestUserWithPermissions[]**](RequestUserWithPermissions.md) |  | [optional] [default to null]
**GroupPermissions** | [**RequestGroupWithPermissions[]**](RequestGroupWithPermissions.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientListPermissionSettings  -StopInheritingPermissions null `
 -UserPermissions null `
 -GroupPermissions null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

