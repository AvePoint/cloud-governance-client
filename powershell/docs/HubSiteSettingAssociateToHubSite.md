# HubSiteSettingAssociateToHubSite
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HubSiteUrl** | **String** |  | [optional] 
**HubSiteTitle** | **String** |  | [optional] 
**HubSiteId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HubSiteSettingAssociateToHubSite = New-Cloud.Governance.ClientHubSiteSettingAssociateToHubSite  -HubSiteUrl null `
 -HubSiteTitle null `
 -HubSiteId null
```

- Convert the resource to JSON
```powershell
$HubSiteSettingAssociateToHubSite | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

