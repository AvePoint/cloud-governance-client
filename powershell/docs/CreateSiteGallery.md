# CreateSiteGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContentTypes** | [**ContentTypes**](ContentTypes.md) |  | [optional] 
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
**FullUrl** | **String** |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSiteGallery = New-Cloud.Governance.ClientCreateSiteGallery  -ContentTypes null `
 -SiteTitleAndDescription null `
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
 -FullUrl null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$CreateSiteGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

