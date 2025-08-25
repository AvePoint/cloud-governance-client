# CreateCommunityGalleryHubSite
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConvertHubSite** | [**ConvertHubSite**](ConvertHubSite.md) |  | [optional] 
**AssociateToHubSite** | [**HubSiteSettingAssociateToHubSite**](HubSiteSettingAssociateToHubSite.md) |  | [optional] 
**RegisterAsHubSite** | [**HubSiteSettingRegisterAsHubSite**](HubSiteSettingRegisterAsHubSite.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateCommunityGalleryHubSite = New-Cloud.Governance.ClientCreateCommunityGalleryHubSite  -ConvertHubSite null `
 -AssociateToHubSite null `
 -RegisterAsHubSite null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateCommunityGalleryHubSite | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

