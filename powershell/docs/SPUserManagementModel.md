# SPUserManagementModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentityName** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**IsGroup** | **Boolean** |  | [optional] [default to $false]
**AzureUserType** | **String** |  | [optional] 
**Action** | [**ManagePermissionAction**](ManagePermissionAction.md) |  | [optional] 
**ExternalUserType** | [**ExternalUserType**](ExternalUserType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SPUserManagementModel = New-Cloud.Governance.ClientSPUserManagementModel  -IdentityName null `
 -DisplayName null `
 -IsGroup null `
 -AzureUserType null `
 -Action null `
 -ExternalUserType null
```

- Convert the resource to JSON
```powershell
$SPUserManagementModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

