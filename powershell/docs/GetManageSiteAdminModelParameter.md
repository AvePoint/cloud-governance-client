# GetManageSiteAdminModelParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 
**ExternalSharingOptions** | [**ExternalSharingOptions**](ExternalSharingOptions.md) |  | [optional] 
**ManageSiteAdminSettingActivityId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GetManageSiteAdminModelParameter = New-Cloud.Governance.ClientGetManageSiteAdminModelParameter  -Uri null `
 -SiteId null `
 -ExternalSharingOptions null `
 -ManageSiteAdminSettingActivityId null
```

- Convert the resource to JSON
```powershell
$GetManageSiteAdminModelParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

