# RequestGroupWithPermissions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [readonly] [default to null]
**Users** | [**GroupUser[]**](GroupUser.md) |  | [optional] [default to null]
**PermissionLevels** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] [default to null]
**GroupOwner** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**GroupOwnerType** | [**GroupOwnerType**](GroupOwnerType.md) |  | [optional] [default to null]
**BuildInGroupType** | [**SharePointBuildInGroupType**](SharePointBuildInGroupType.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientRequestGroupWithPermissions  -Name null `
 -Description null `
 -Users null `
 -PermissionLevels null `
 -GroupOwner null `
 -GroupOwnerType null `
 -BuildInGroupType null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

