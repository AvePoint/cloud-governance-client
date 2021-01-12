# RequestGroupWithPermissions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Users** | [**GroupUser[]**](GroupUser.md) |  | [optional] 
**PermissionLevels** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] 
**GroupOwner** | [**ApiUser**](ApiUser.md) |  | [optional] 
**GroupOwnerType** | [**GroupOwnerType**](GroupOwnerType.md) |  | [optional] 
**BuildInGroupType** | [**SharePointBuildInGroupType**](SharePointBuildInGroupType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RequestGroupWithPermissions = New-Cloud.Governance.ClientRequestGroupWithPermissions  -Name null `
 -Description null `
 -Users null `
 -PermissionLevels null `
 -GroupOwner null `
 -GroupOwnerType null `
 -BuildInGroupType null
```

- Convert the resource to JSON
```powershell
$RequestGroupWithPermissions | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

