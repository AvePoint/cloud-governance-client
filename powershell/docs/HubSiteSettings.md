# HubSiteSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** | Whether the hub site functionality is enabled. | [optional] [default to $false]
**Action** | [**ConvertHubSiteActionType**](ConvertHubSiteActionType.md) | Set how to enable the hub site functionality. You can register the site collection as a hub site or associate the site collection with a hub site. | [optional] 
**AssociatedHubSiteId** | **String** | ID of the associated hub site | [optional] 
**AssociatedHubSiteTitle** | **String** | Title of the associated hub site | [optional] 

## Examples

- Prepare the resource
```powershell
$HubSiteSettings = New-Cloud.Governance.ClientHubSiteSettings  -Enabled null `
 -Action null `
 -AssociatedHubSiteId null `
 -AssociatedHubSiteTitle null
```

- Convert the resource to JSON
```powershell
$HubSiteSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

