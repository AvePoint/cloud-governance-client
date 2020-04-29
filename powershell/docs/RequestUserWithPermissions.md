# RequestUserWithPermissions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**User** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**PermissionLevels** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientRequestUserWithPermissions  -User null `
 -PermissionLevels null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

