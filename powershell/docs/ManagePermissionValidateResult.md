# ManagePermissionValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PermissionLevels** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] 
**ExternalSharingOptions** | [**ExternalSharingOptions**](ExternalSharingOptions.md) |  | [optional] 
**EnableShareAnonymousLink** | **Boolean** |  | [optional] [default to $false]
**Object** | [**ManagePermissionSPObject**](ManagePermissionSPObject.md) |  | [optional] 
**UserMetadata** | [**System.Collections.Hashtable**](UserInfo.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManagePermissionValidateResult = New-Cloud.Governance.ClientManagePermissionValidateResult  -PermissionLevels null `
 -ExternalSharingOptions null `
 -EnableShareAnonymousLink null `
 -Object null `
 -UserMetadata null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ManagePermissionValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

