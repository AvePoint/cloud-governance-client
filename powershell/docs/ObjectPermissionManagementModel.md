# ObjectPermissionManagementModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | [**SPPrincipalType**](SPPrincipalType.md) |  | [optional] [default to null]
**ObjectInfo** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**Action** | [**ManagePermissionAction**](ManagePermissionAction.md) |  | [optional] [default to null]
**Permissions** | **String[]** |  | [optional] [default to null]
**OriginalPermissions** | **String[]** |  | [optional] [default to null]
**ExternalUserType** | [**ExternalUserType**](ExternalUserType.md) |  | [optional] [default to null]
**Members** | [**SharingEnabledUser[]**](SharingEnabledUser.md) |  | [optional] [default to null]
**GrantPermissionSetting** | [**GrantPermissionModel**](GrantPermissionModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientObjectPermissionManagementModel  -ObjectType null `
 -ObjectInfo null `
 -Action null `
 -Permissions null `
 -OriginalPermissions null `
 -ExternalUserType null `
 -Members null `
 -GrantPermissionSetting null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

