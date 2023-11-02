# CreateTeamGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] 
**ContentTypes** | [**ContentTypes**](ContentTypes.md) |  | [optional] 
**TeamNameAndDescription** | [**TeamNameDescription**](TeamNameDescription.md) |  | [optional] 
**TeamId** | [**TeamId**](TeamId.md) | Activity model for team id | [optional] 
**TeamContact** | [**Contact**](Contact.md) | Activity model for primary contact,secondary contact | [optional] 
**TeamTemplate** | [**TeamTemplate**](TeamTemplate.md) | Activity model for team template | [optional] 
**CloneTeam** | [**CloneTeam**](CloneTeam.md) | Request activity model for clone team settings | [optional] 
**MemberPermissionSetting** | [**TeamMemberPermissionSetting**](TeamMemberPermissionSetting.md) |  | [optional] 
**GuestPermissionSetting** | [**TeamGuestPermissionSetting**](TeamGuestPermissionSetting.md) |  | [optional] 
**FunSetting** | [**TeamFunSetting**](TeamFunSetting.md) |  | [optional] 
**MentionSetting** | [**TeamMentionSetting**](TeamMentionSetting.md) |  | [optional] 
**TeamMessagingSettings** | [**TeamMessagingSettings**](TeamMessagingSettings.md) |  | [optional] 
**TeamHubSite** | [**HubSiteSetting**](HubSiteSetting.md) |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**Owners** | [**TeamOwners**](TeamOwners.md) |  | [optional] 
**Members** | [**TeamMembers**](TeamMembers.md) |  | [optional] 
**Privacy** | [**Privacy**](Privacy.md) |  | [optional] 
**OutlookExperience** | [**OutlookExperience**](OutlookExperience.md) |  | [optional] 
**GlobalAddressList** | [**GlobalAddressList**](GlobalAddressList.md) |  | [optional] 
**ClassificationAndSensitivityLabel** | [**TeamClassificationAndSensitivityLabel**](TeamClassificationAndSensitivityLabel.md) |  | [optional] 
**GovernancePanel** | [**GovernancePanel**](GovernancePanel.md) |  | [optional] 
**ElectionProfile** | [**TeamElectionProfile**](TeamElectionProfile.md) |  | [optional] 
**ExternalSharingSettingProfile** | [**ExternalSharingProfile**](ExternalSharingProfile.md) |  | [optional] 
**QuotaSettingProfile** | [**QuotaProfile**](QuotaProfile.md) |  | [optional] 
**RenewalProfile** | [**RenewalProfile**](RenewalProfile.md) |  | [optional] 
**Locale** | [**TeamLocale**](TeamLocale.md) |  | [optional] 
**TimeZone** | [**TeamTimeZone**](TeamTimeZone.md) |  | [optional] 
**ShowLinksInRequestDetailsPage** | [**ShowLinksInRequestDetailsPage**](ShowLinksInRequestDetailsPage.md) |  | [optional] 
**SiteDesign** | [**SiteDesign**](SiteDesign.md) |  | [optional] 
**WelcomeEmail** | [**WelcomeEmail**](WelcomeEmail.md) |  | [optional] 
**DynamicMembershipRules** | [**DynamicMembership**](DynamicMembership.md) |  | [optional] 
**Tenant** | [**OfficeTenant**](OfficeTenant.md) |  | [optional] 
**TeamEmail** | **String** |  | [optional] [readonly] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

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
 -MentionSetting null `
 -TeamMessagingSettings null `
 -TeamHubSite null `
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
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$CreateTeamGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

