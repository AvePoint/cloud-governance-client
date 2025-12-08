# ManagePermissionSiteAdminModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**ObjectId** | **String** |  | [optional] 
**LogonName** | **String** |  | [optional] 
**SharePointLogonName** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**IsBuildInRole** | **Boolean** |  | [optional] [default to $false]
**Type** | [**PrincipalType**](PrincipalType.md) |  | [optional] 
**IsActive** | **Boolean** |  | [optional] [default to $false]
**IsBlock** | **Boolean** |  | [optional] [default to $false]
**IsPrimaryAdmin** | **Boolean** |  | [optional] [default to $false]
**TemporaryPermissionSetting** | [**TemporaryPermissionRequestSetting**](TemporaryPermissionRequestSetting.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManagePermissionSiteAdminModel = New-Cloud.Governance.ClientManagePermissionSiteAdminModel  -Id null `
 -ObjectId null `
 -LogonName null `
 -SharePointLogonName null `
 -DisplayName null `
 -Title null `
 -IsBuildInRole null `
 -Type null `
 -IsActive null `
 -IsBlock null `
 -IsPrimaryAdmin null `
 -TemporaryPermissionSetting null
```

- Convert the resource to JSON
```powershell
$ManagePermissionSiteAdminModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

