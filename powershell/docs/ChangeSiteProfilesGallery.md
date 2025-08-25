# ChangeSiteProfilesGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteProfileInfo** | [**ChangeSiteProfilesGallerySiteProfileInfo**](ChangeSiteProfilesGallerySiteProfileInfo.md) |  | [optional] 
**SiteExternalSharingProfile** | [**ChangeSiteProfilesGallerySiteExternalSharingProfile**](ChangeSiteProfilesGallerySiteExternalSharingProfile.md) |  | [optional] 
**SiteStorageManagementProfile** | [**ChangeSiteProfilesGallerySiteStorageManagementProfile**](ChangeSiteProfilesGallerySiteStorageManagementProfile.md) |  | [optional] 
**SiteContactElectionProfile** | [**ChangeSiteProfilesGallerySiteContactElectionProfile**](ChangeSiteProfilesGallerySiteContactElectionProfile.md) |  | [optional] 
**SiteRenewalProfile** | [**ChangeSiteProfilesGallerySiteRenewalProfile**](ChangeSiteProfilesGallerySiteRenewalProfile.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteProfilesGallery = New-Cloud.Governance.ClientChangeSiteProfilesGallery  -SiteProfileInfo null `
 -SiteExternalSharingProfile null `
 -SiteStorageManagementProfile null `
 -SiteContactElectionProfile null `
 -SiteRenewalProfile null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$ChangeSiteProfilesGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

