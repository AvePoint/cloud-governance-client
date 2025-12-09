# ChangeSiteProfilesGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteProfileInfo** | [**ChangeSiteProfilesModel**](ChangeSiteProfilesModel.md) |  | [optional] 
**SiteExternalSharingProfile** | [**ChangeSiteExternalSharingProfileModel**](ChangeSiteExternalSharingProfileModel.md) |  | [optional] 
**SiteStorageManagementProfile** | [**ChangeSiteStorageManagementProfileModel**](ChangeSiteStorageManagementProfileModel.md) |  | [optional] 
**SiteContactElectionProfile** | [**ChangeSiteContactElectionProfileModel**](ChangeSiteContactElectionProfileModel.md) |  | [optional] 
**SiteRenewalProfile** | [**ChangeSiteRenewProfileModel**](ChangeSiteRenewProfileModel.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**RequestSensitivityLabel**](RequestSensitivityLabel.md) |  | [optional] 
**Requester** | **String** |  | [optional] 

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
 -RequestSensitivityLabel null `
 -Requester null
```

- Convert the resource to JSON
```powershell
$ChangeSiteProfilesGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

