# GrantPermissionUrlValidationResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalSharingOptions** | [**ExternalSharingOptions**](ExternalSharingOptions.md) |  | [optional] 
**EnableShareAnnoymousLink** | **Boolean** |  | [optional] 
**Object** | [**GrantPermissionSPObject**](GrantPermissionSPObject.md) |  | [optional] 
**SpPermissionLevels** | [**IntModel[]**](IntModel.md) |  | [optional] 
**SpGroups** | [**GrantPermissionGroup[]**](GrantPermissionGroup.md) |  | [optional] 
**AllowBreakPermissionInheritance** | **Boolean** |  | [optional] 
**UserMetadata** | [**System.Collections.Hashtable**](UserInfo.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] 
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GrantPermissionUrlValidationResult = New-Cloud.Governance.ClientGrantPermissionUrlValidationResult  -ExternalSharingOptions null `
 -EnableShareAnnoymousLink null `
 -Object null `
 -SpPermissionLevels null `
 -SpGroups null `
 -AllowBreakPermissionInheritance null `
 -UserMetadata null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$GrantPermissionUrlValidationResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

