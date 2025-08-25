# CreateSiteGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteTitleAndDescription** | [**CreateSiteGallerySiteTitleAndDescription**](CreateSiteGallerySiteTitleAndDescription.md) |  | [optional] 
**SiteUrlSetting** | [**CreateSiteGallerySiteUrlSetting**](CreateSiteGallerySiteUrlSetting.md) |  | [optional] 
**SiteTimeZone** | [**CreateSharedMailboxGalleryTimeZone**](CreateSharedMailboxGalleryTimeZone.md) |  | [optional] 
**SiteTemplate** | [**CreateSiteGallerySiteTemplate**](CreateSiteGallerySiteTemplate.md) |  | [optional] 
**SiteOfficeTenant** | [**CreateCommunityGalleryTenant**](CreateCommunityGalleryTenant.md) |  | [optional] 
**SiteLanguage** | [**CreateSiteGallerySiteLanguage**](CreateSiteGallerySiteLanguage.md) |  | [optional] 
**SiteContacts** | [**CreateCommunityGalleryContact**](CreateCommunityGalleryContact.md) |  | [optional] 
**ExternalSharingProfile** | [**CreateCommunityGalleryExternalSharingSettingProfile**](CreateCommunityGalleryExternalSharingSettingProfile.md) |  | [optional] 
**QuotaProfile** | [**CreateCommunityGalleryQuotaSettingProfile**](CreateCommunityGalleryQuotaSettingProfile.md) |  | [optional] 
**SiteDesign** | [**CreateCommunityGallerySiteDesign**](CreateCommunityGallerySiteDesign.md) |  | [optional] 
**SiteAdmins** | [**CreateSiteGallerySiteAdmins**](CreateSiteGallerySiteAdmins.md) |  | [optional] 
**SiteInformationIcon** | [**CreateSiteGallerySiteInformationIcon**](CreateSiteGallerySiteInformationIcon.md) |  | [optional] 
**SiteDepthLimit** | [**CreateSiteGallerySiteDepthLimit**](CreateSiteGallerySiteDepthLimit.md) |  | [optional] 
**DpmPlanSetting** | [**CreateSiteGalleryDpmPlanSetting**](CreateSiteGalleryDpmPlanSetting.md) |  | [optional] 
**PermissionSetting** | [**CreateSiteGalleryPermissionSetting**](CreateSiteGalleryPermissionSetting.md) |  | [optional] 
**SiteCloudGovernancePanel** | [**CreateSiteGallerySiteCloudGovernancePanel**](CreateSiteGallerySiteCloudGovernancePanel.md) |  | [optional] 
**SiteClassificationAndSensitivityLabel** | [**CreateSiteGallerySiteClassificationAndSensitivityLabel**](CreateSiteGallerySiteClassificationAndSensitivityLabel.md) |  | [optional] 
**SiteHubSite** | [**CreateCommunityGalleryHubSite**](CreateCommunityGalleryHubSite.md) |  | [optional] 
**MultiGeoLocationSetting** | [**CreateEquipmentMailboxGalleryMultiGeoLocationSetting**](CreateEquipmentMailboxGalleryMultiGeoLocationSetting.md) |  | [optional] 
**RenewalProfile** | [**CreateCommunityGalleryRenewalProfile**](CreateCommunityGalleryRenewalProfile.md) |  | [optional] 
**ElectionProfile** | [**CreateSiteGalleryElectionProfile**](CreateSiteGalleryElectionProfile.md) |  | [optional] 
**ContentTypes** | [**CreateCommunityGalleryContentTypes**](CreateCommunityGalleryContentTypes.md) |  | [optional] 
**ActivateFeatures** | [**CreateSiteGalleryActivateFeatures**](CreateSiteGalleryActivateFeatures.md) |  | [optional] 
**AddSiteColumns** | [**CreateSiteGalleryAddSiteColumns**](CreateSiteGalleryAddSiteColumns.md) |  | [optional] 
**PublishColumns** | [**CreateSiteGalleryAddSiteColumns**](CreateSiteGalleryAddSiteColumns.md) |  | [optional] 
**AlternateCssUrl** | [**CreateSiteGalleryAlternateCssUrl**](CreateSiteGalleryAlternateCssUrl.md) |  | [optional] 
**FullUrl** | **String** |  | [optional] 
**SitePicture** | [**CreateSiteGallerySitePicture**](CreateSiteGallerySitePicture.md) |  | [optional] 
**ScAvePointPortalManagerTemplate** | [**CreateSiteGalleryScAvePointPortalManagerTemplate**](CreateSiteGalleryScAvePointPortalManagerTemplate.md) |  | [optional] 
**CreateSiteCollectionNotifyOpusForNewFiles** | [**CreateLibraryGalleryCreateLibraryNotifyOpusForNewFiles**](CreateLibraryGalleryCreateLibraryNotifyOpusForNewFiles.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSiteGallery = New-Cloud.Governance.ClientCreateSiteGallery  -SiteTitleAndDescription null `
 -SiteUrlSetting null `
 -SiteTimeZone null `
 -SiteTemplate null `
 -SiteOfficeTenant null `
 -SiteLanguage null `
 -SiteContacts null `
 -ExternalSharingProfile null `
 -QuotaProfile null `
 -SiteDesign null `
 -SiteAdmins null `
 -SiteInformationIcon null `
 -SiteDepthLimit null `
 -DpmPlanSetting null `
 -PermissionSetting null `
 -SiteCloudGovernancePanel null `
 -SiteClassificationAndSensitivityLabel null `
 -SiteHubSite null `
 -MultiGeoLocationSetting null `
 -RenewalProfile null `
 -ElectionProfile null `
 -ContentTypes null `
 -ActivateFeatures null `
 -AddSiteColumns null `
 -PublishColumns null `
 -AlternateCssUrl null `
 -FullUrl null `
 -SitePicture null `
 -ScAvePointPortalManagerTemplate null `
 -CreateSiteCollectionNotifyOpusForNewFiles null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$CreateSiteGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

