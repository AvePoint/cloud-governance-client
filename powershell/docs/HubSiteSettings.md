# HubSiteSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [default to $false]
**Action** | [**ConvertHubSiteActionType**](ConvertHubSiteActionType.md) |  | [optional] 
**AssociatedHubSiteId** | **String** |  | [optional] 
**AssociatedHubSiteTitle** | **String** |  | [optional] 

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

