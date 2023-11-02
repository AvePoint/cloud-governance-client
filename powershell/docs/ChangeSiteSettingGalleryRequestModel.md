# ChangeSiteSettingGalleryRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteInfo** | [**ChangeSiteObjectModel**](ChangeSiteObjectModel.md) |  | [optional] 
**ChangedSiteTitle** | [**StringChangedValueRequestModel**](StringChangedValueRequestModel.md) |  | [optional] 
**ChangedSiteAddress** | [**StringChangedValueRequestModel**](StringChangedValueRequestModel.md) |  | [optional] 
**ChangedSiteDescription** | [**StringChangedValueRequestModel**](StringChangedValueRequestModel.md) |  | [optional] 
**ChangedSiteSensitivityLabel** | [**TeamSensitivityLabelChangedValueRequestModel**](TeamSensitivityLabelChangedValueRequestModel.md) |  | [optional] 
**ChangedSiteClassification** | [**StringModelChangedValueRequestModel**](StringModelChangedValueRequestModel.md) |  | [optional] 
**ChangedSiteStorage** | [**ChangeSiteStorageSettingModel**](ChangeSiteStorageSettingModel.md) |  | [optional] 
**ChangedSiteTimeZone** | [**Int32ChangedValueRequestModel**](Int32ChangedValueRequestModel.md) |  | [optional] 
**ChangedSiteLocale** | [**Int32ChangedValueRequestModel**](Int32ChangedValueRequestModel.md) |  | [optional] 
**ChangedSiteDesign** | [**ChangedSiteDesignModelChangedValueRequestModel**](ChangedSiteDesignModelChangedValueRequestModel.md) |  | [optional] 
**ChangedSiteHubSite** | [**ChangeSiteHubSiteRequestModel**](ChangeSiteHubSiteRequestModel.md) |  | [optional] 
**ChangedSiteSharing** | [**ChangeSiteSharingRequestModel**](ChangeSiteSharingRequestModel.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

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
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$ChangeSiteSettingGalleryRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

