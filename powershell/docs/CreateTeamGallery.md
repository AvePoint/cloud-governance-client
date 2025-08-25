# CreateTeamGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] 
**ContentTypes** | [**CreateCommunityGalleryContentTypes**](CreateCommunityGalleryContentTypes.md) |  | [optional] 
**TeamNameAndDescription** | [**CreateCommunityGalleryNameAndDescription**](CreateCommunityGalleryNameAndDescription.md) |  | [optional] 
**TeamId** | [**CreateTeamGalleryTeamId**](CreateTeamGalleryTeamId.md) |  | [optional] 
**TeamContact** | [**CreateCommunityGalleryContact**](CreateCommunityGalleryContact.md) |  | [optional] 
**TeamTemplate** | [**CreateTeamGalleryTeamTemplate**](CreateTeamGalleryTeamTemplate.md) |  | [optional] 
**CloneTeam** | [**CreateTeamGalleryCloneTeam**](CreateTeamGalleryCloneTeam.md) |  | [optional] 
**MemberPermissionSetting** | [**CreateTeamGalleryMemberPermissionSetting**](CreateTeamGalleryMemberPermissionSetting.md) |  | [optional] 
**GuestPermissionSetting** | [**CreateTeamGalleryGuestPermissionSetting**](CreateTeamGalleryGuestPermissionSetting.md) |  | [optional] 
**FunSetting** | [**CreateTeamGalleryFunSetting**](CreateTeamGalleryFunSetting.md) |  | [optional] 
**TeamPicture** | [**CreateGroupGalleryGroupPicture**](CreateGroupGalleryGroupPicture.md) |  | [optional] 
**MentionSetting** | [**CreateTeamGalleryMentionSetting**](CreateTeamGalleryMentionSetting.md) |  | [optional] 
**TeamMessagingSettings** | [**CreateTeamGalleryTeamMessagingSettings**](CreateTeamGalleryTeamMessagingSettings.md) |  | [optional] 
**TeamHubSite** | [**CreateCommunityGalleryHubSite**](CreateCommunityGalleryHubSite.md) |  | [optional] 
**TeamSiteUrl** | [**CreateTeamGalleryTeamSiteUrl**](CreateTeamGalleryTeamSiteUrl.md) |  | [optional] 
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
$CreateTeamGallery = New-Cloud.Governance.ClientCreateTeamGallery  -ObjectId null `
 -ContentTypes null `
 -TeamNameAndDescription null `
 -TeamId null `
 -TeamContact null `
 -TeamTemplate null `
 -CloneTeam null `
 -MemberPermissionSetting null `
 -GuestPermissionSetting null `
 -FunSetting null `
 -TeamPicture null `
 -MentionSetting null `
 -TeamMessagingSettings null `
 -TeamHubSite null `
 -TeamSiteUrl null `
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
$CreateTeamGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

