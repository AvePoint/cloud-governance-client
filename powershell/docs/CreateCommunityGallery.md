# CreateCommunityGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] 
**ContentTypes** | [**CreateCommunityGalleryContentTypes**](CreateCommunityGalleryContentTypes.md) |  | [optional] 
**NameAndDescription** | [**CreateCommunityGalleryNameAndDescription**](CreateCommunityGalleryNameAndDescription.md) |  | [optional] 
**Contact** | [**CreateCommunityGalleryContact**](CreateCommunityGalleryContact.md) |  | [optional] 
**CommunityInfo** | [**CreateCommunityGalleryCommunityInfo**](CreateCommunityGalleryCommunityInfo.md) |  | [optional] 
**HubSite** | [**CreateCommunityGalleryHubSite**](CreateCommunityGalleryHubSite.md) |  | [optional] 
**CommunitySharingCapabilities** | [**ExternalSharingOptions**](ExternalSharingOptions.md) |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**Owners** | [**CreateCommunityGalleryOwners**](CreateCommunityGalleryOwners.md) |  | [optional] 
**Members** | [**CreateCommunityGalleryMembers**](CreateCommunityGalleryMembers.md) |  | [optional] 
**Privacy** | [**CreateCommunityGalleryPrivacy**](CreateCommunityGalleryPrivacy.md) |  | [optional] 
**OutlookExperience** | [**ChangeTeamSettingGalleryRequestModelChangeTeamOutlookExperience**](ChangeTeamSettingGalleryRequestModelChangeTeamOutlookExperience.md) |  | [optional] 
**GlobalAddressList** | [**ChangeTeamSettingGalleryRequestModelChangeGlobalAddressList**](ChangeTeamSettingGalleryRequestModelChangeGlobalAddressList.md) |  | [optional] 
**ClassificationAndSensitivityLabel** | [**CreateCommunityGalleryClassificationAndSensitivityLabel**](CreateCommunityGalleryClassificationAndSensitivityLabel.md) |  | [optional] 
**GovernancePanel** | [**CreateCommunityGalleryGovernancePanel**](CreateCommunityGalleryGovernancePanel.md) |  | [optional] 
**ElectionProfile** | [**CreateCommunityGalleryElectionProfile**](CreateCommunityGalleryElectionProfile.md) |  | [optional] 
**ExternalSharingSettingProfile** | [**CreateCommunityGalleryExternalSharingSettingProfile**](CreateCommunityGalleryExternalSharingSettingProfile.md) |  | [optional] 
**QuotaSettingProfile** | [**CreateCommunityGalleryQuotaSettingProfile**](CreateCommunityGalleryQuotaSettingProfile.md) |  | [optional] 
**RenewalProfile** | [**CreateCommunityGalleryRenewalProfile**](CreateCommunityGalleryRenewalProfile.md) |  | [optional] 
**Locale** | [**CreateCommunityGalleryLocale**](CreateCommunityGalleryLocale.md) |  | [optional] 
**TimeZone** | [**CreateCommunityGalleryTimeZone**](CreateCommunityGalleryTimeZone.md) |  | [optional] 
**ShowLinksInRequestDetailsPage** | [**CreateCommunityGalleryShowLinksInRequestDetailsPage**](CreateCommunityGalleryShowLinksInRequestDetailsPage.md) |  | [optional] 
**SiteDesign** | [**CreateCommunityGallerySiteDesign**](CreateCommunityGallerySiteDesign.md) |  | [optional] 
**WelcomeEmail** | [**CreateCommunityGalleryWelcomeEmail**](CreateCommunityGalleryWelcomeEmail.md) |  | [optional] 
**DynamicMembershipRules** | [**CreateCommunityGalleryDynamicMembershipRules**](CreateCommunityGalleryDynamicMembershipRules.md) |  | [optional] 
**Tenant** | [**CreateCommunityGalleryTenant**](CreateCommunityGalleryTenant.md) |  | [optional] 
**TeamEmail** | **String** |  | [optional] [readonly] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateCommunityGallery = New-Cloud.Governance.ClientCreateCommunityGallery  -ObjectId null `
 -ContentTypes null `
 -NameAndDescription null `
 -Contact null `
 -CommunityInfo null `
 -HubSite null `
 -CommunitySharingCapabilities null `
 -OfficeTenantId null `
 -Owners null `
 -Members null `
 -Privacy null `
 -OutlookExperience null `
 -GlobalAddressList null `
 -ClassificationAndSensitivityLabel null `
 -GovernancePanel null `
 -ElectionProfile null `
 -ExternalSharingSettingProfile null `
 -QuotaSettingProfile null `
 -RenewalProfile null `
 -Locale null `
 -TimeZone null `
 -ShowLinksInRequestDetailsPage null `
 -SiteDesign null `
 -WelcomeEmail null `
 -DynamicMembershipRules null `
 -Tenant null `
 -TeamEmail null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$CreateCommunityGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

