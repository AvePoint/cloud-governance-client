# UserGroupPermissions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserPermissions** | [**ServiceUserWithPermissions[]**](ServiceUserWithPermissions.md) |  | [optional] [default to null]
**GroupPermissions** | [**ServiceGroupWithPermissions[]**](ServiceGroupWithPermissions.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientUserGroupPermissions  -UserPermissions null `
 -GroupPermissions null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

