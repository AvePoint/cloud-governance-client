# SPUserManagementModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentityName** | **String** |  | [optional] [default to null]
**DisplayName** | **String** |  | [optional] [default to null]
**IsGroup** | **Boolean** |  | [optional] [default to null]
**Action** | [**ManagePermissionAction**](ManagePermissionAction.md) |  | [optional] [default to null]
**ExternalUserType** | [**ExternalUserType**](ExternalUserType.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSPUserManagementModel  -IdentityName null `
 -DisplayName null `
 -IsGroup null `
 -Action null `
 -ExternalUserType null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

