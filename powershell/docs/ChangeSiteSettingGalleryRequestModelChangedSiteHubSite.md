# ChangeSiteSettingGalleryRequestModelChangedSiteHubSite
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | [**ChangeHubSiteMethod**](ChangeHubSiteMethod.md) |  | [optional] 
**ChangeHubSite** | [**ChangeSiteHubSiteRequestModelChangeHubSite**](ChangeSiteHubSiteRequestModelChangeHubSite.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteSettingGalleryRequestModelChangedSiteHubSite = New-Cloud.Governance.ClientChangeSiteSettingGalleryRequestModelChangedSiteHubSite  -Method null `
 -ChangeHubSite null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeSiteSettingGalleryRequestModelChangedSiteHubSite | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

