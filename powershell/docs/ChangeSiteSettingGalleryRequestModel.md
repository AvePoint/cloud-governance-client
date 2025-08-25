# ChangeSiteSettingGalleryRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteInfo** | [**ChangeSiteSettingGalleryRequestModelSiteInfo**](ChangeSiteSettingGalleryRequestModelSiteInfo.md) |  | [optional] 
**ChangedSiteTitle** | [**ChangeSiteSettingGalleryRequestModelChangedSiteTitle**](ChangeSiteSettingGalleryRequestModelChangedSiteTitle.md) |  | [optional] 
**ChangedSiteAddress** | [**ChangeSiteSettingGalleryRequestModelChangedSiteTitle**](ChangeSiteSettingGalleryRequestModelChangedSiteTitle.md) |  | [optional] 
**ChangedSiteDescription** | [**ChangeSiteSettingGalleryRequestModelChangedSiteTitle**](ChangeSiteSettingGalleryRequestModelChangedSiteTitle.md) |  | [optional] 
**ChangedSiteSensitivityLabel** | [**ChangeSiteSettingGalleryRequestModelChangedSiteSensitivityLabel**](ChangeSiteSettingGalleryRequestModelChangedSiteSensitivityLabel.md) |  | [optional] 
**ChangedSiteClassification** | [**ChangeSiteSettingGalleryRequestModelChangedSiteClassification**](ChangeSiteSettingGalleryRequestModelChangedSiteClassification.md) |  | [optional] 
**ChangedSiteStorage** | [**ChangeSharedChannelGallerySiteStorage**](ChangeSharedChannelGallerySiteStorage.md) |  | [optional] 
**ChangedSiteTimeZone** | [**ChangeSiteSettingGalleryRequestModelChangedSiteTimeZone**](ChangeSiteSettingGalleryRequestModelChangedSiteTimeZone.md) |  | [optional] 
**ChangedSiteLocale** | [**ChangeSiteSettingGalleryRequestModelChangedSiteTimeZone**](ChangeSiteSettingGalleryRequestModelChangedSiteTimeZone.md) |  | [optional] 
**ChangedSiteDesign** | [**ChangeSiteSettingGalleryRequestModelChangedSiteDesign**](ChangeSiteSettingGalleryRequestModelChangedSiteDesign.md) |  | [optional] 
**ChangedSiteHubSite** | [**ChangeSiteSettingGalleryRequestModelChangedSiteHubSite**](ChangeSiteSettingGalleryRequestModelChangedSiteHubSite.md) |  | [optional] 
**ChangedSiteSharing** | [**ChangeSiteSettingGalleryRequestModelChangedSiteSharing**](ChangeSiteSettingGalleryRequestModelChangedSiteSharing.md) |  | [optional] 
**ChangeSitePicture** | [**ChangeSiteSettingGalleryRequestModelChangeSitePicture**](ChangeSiteSettingGalleryRequestModelChangeSitePicture.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteSettingGalleryRequestModel = New-Cloud.Governance.ClientChangeSiteSettingGalleryRequestModel  -SiteInfo null `
 -ChangedSiteTitle null `
 -ChangedSiteAddress null `
 -ChangedSiteDescription null `
 -ChangedSiteSensitivityLabel null `
 -ChangedSiteClassification null `
 -ChangedSiteStorage null `
 -ChangedSiteTimeZone null `
 -ChangedSiteLocale null `
 -ChangedSiteDesign null `
 -ChangedSiteHubSite null `
 -ChangedSiteSharing null `
 -ChangeSitePicture null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$ChangeSiteSettingGalleryRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

