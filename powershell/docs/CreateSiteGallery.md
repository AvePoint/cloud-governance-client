# CreateSiteGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteTitleAndDescription** | [**SiteTitleDescription**](SiteTitleDescription.md) |  | [optional] 
**SiteUrlSetting** | [**DRSiteUrlSetting**](DRSiteUrlSetting.md) |  | [optional] 
**SiteTimeZone** | [**SiteTimeZone**](SiteTimeZone.md) |  | [optional] 
**SiteTemplate** | [**SiteTemplateSetting**](SiteTemplateSetting.md) |  | [optional] 
**SiteOfficeTenant** | [**OfficeTenant**](OfficeTenant.md) |  | [optional] 
**SiteLanguage** | [**SiteLanguage**](SiteLanguage.md) |  | [optional] 
**SiteContacts** | [**Contact**](Contact.md) | Activity model for primary contact,secondary contact | [optional] 
**ExternalSharingProfile** | [**ExternalSharingProfile**](ExternalSharingProfile.md) |  | [optional] 
**QuotaProfile** | [**QuotaProfile**](QuotaProfile.md) |  | [optional] 
**SiteDesign** | [**SiteDesign**](SiteDesign.md) |  | [optional] 
**SiteAdmins** | [**SiteAdmins**](SiteAdmins.md) |  | [optional] 
**SiteInformationIcon** | [**InformationIconSetting**](InformationIconSetting.md) |  | [optional] 
**SiteDepthLimit** | [**DepthLimitSetting**](DepthLimitSetting.md) |  | [optional] 
**DpmPlanSetting** | [**DpmPlanSetting**](DpmPlanSetting.md) |  | [optional] 
**PermissionSetting** | [**DRPermissionSetting**](DRPermissionSetting.md) |  | [optional] 
**SiteCloudGovernancePanel** | [**SiteCloudGovernancePanel**](SiteCloudGovernancePanel.md) |  | [optional] 
**SiteClassificationAndSensitivityLabel** | [**SiteClassificationAndSensitivityLabel**](SiteClassificationAndSensitivityLabel.md) |  | [optional] 
**SiteHubSite** | [**HubSiteSetting**](HubSiteSetting.md) |  | [optional] 
**MultiGeoLocationSetting** | [**MultiGeoLocationSetting**](MultiGeoLocationSetting.md) |  | [optional] 
**RenewalProfile** | [**RenewalProfile**](RenewalProfile.md) |  | [optional] 
**ElectionProfile** | [**SiteElectionProfile**](SiteElectionProfile.md) |  | [optional] 
**ContentTypes** | [**ContentTypes**](ContentTypes.md) |  | [optional] 
**ActivateFeatures** | [**SiteFeature**](SiteFeature.md) |  | [optional] 
**AddSiteColumns** | [**SiteColumns**](SiteColumns.md) |  | [optional] 
**PublishColumns** | [**SiteColumns**](SiteColumns.md) |  | [optional] 
**AlternateCssUrl** | [**SiteAlternateCssUrl**](SiteAlternateCssUrl.md) |  | [optional] 
**FullUrl** | **String** |  | [optional] 
**SitePicture** | [**SitePicture**](SitePicture.md) |  | [optional] 
**ScAvePointPortalManagerTemplate** | [**ApmTemplateSetting**](ApmTemplateSetting.md) |  | [optional] 
**CreateSiteCollectionNotifyOpusForNewFiles** | [**NotifyOpusForNewFilesRequestModel**](NotifyOpusForNewFilesRequestModel.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**RequestSensitivityLabel**](RequestSensitivityLabel.md) |  | [optional] 
**Requester** | **String** |  | [optional] 

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
 -RequestSensitivityLabel null `
 -Requester null
```

- Convert the resource to JSON
```powershell
$CreateSiteGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

