# ManagePermissionValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PermissionLevels** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] [default to null]
**ExternalSharingOptions** | [**ExternalSharingOptions**](ExternalSharingOptions.md) |  | [optional] [default to null]
**EnableShareAnonymousLink** | **Boolean** |  | [optional] [default to null]
**Object** | [**ManagePermissionSPObject**](ManagePermissionSPObject.md) |  | [optional] [default to null]
**IsValid** | **Boolean** |  | [optional] [readonly] [default to null]
**ErrorMessage** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientManagePermissionValidateResult  -PermissionLevels null `
 -ExternalSharingOptions null `
 -EnableShareAnonymousLink null `
 -Object null `
 -IsValid null `
 -ErrorMessage null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

