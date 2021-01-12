# ObjectPermissionManagementModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | [**SPPrincipalType**](SPPrincipalType.md) |  | [optional] 
**ObjectInfo** | [**ApiUser**](ApiUser.md) |  | [optional] 
**Action** | [**ManagePermissionAction**](ManagePermissionAction.md) |  | [optional] 
**Permissions** | **String[]** |  | [optional] 
**OriginalPermissions** | **String[]** |  | [optional] 
**ExternalUserType** | [**ExternalUserType**](ExternalUserType.md) |  | [optional] 
**Members** | [**SharingEnabledUser[]**](SharingEnabledUser.md) |  | [optional] 
**GrantPermissionSetting** | [**GrantPermissionModel**](GrantPermissionModel.md) |  | [optional] 
**OriginalName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ObjectPermissionManagementModel = New-Cloud.Governance.ClientObjectPermissionManagementModel  -ObjectType null `
 -ObjectInfo null `
 -Action null `
 -Permissions null `
 -OriginalPermissions null `
 -ExternalUserType null `
 -Members null `
 -GrantPermissionSetting null `
 -OriginalName null
```

- Convert the resource to JSON
```powershell
$ObjectPermissionManagementModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

