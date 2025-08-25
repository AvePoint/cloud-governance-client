# HubSiteSettingRegisterAsHubSite
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnabledUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**HubSiteName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HubSiteSettingRegisterAsHubSite = New-Cloud.Governance.ClientHubSiteSettingRegisterAsHubSite  -EnabledUsers null `
 -HubSiteName null
```

- Convert the resource to JSON
```powershell
$HubSiteSettingRegisterAsHubSite | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

