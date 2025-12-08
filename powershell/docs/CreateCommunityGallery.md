# CreateCommunityGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] 
**ContentTypes** | [**ContentTypes**](ContentTypes.md) |  | [optional] 
**NameAndDescription** | [**TeamNameDescription**](TeamNameDescription.md) |  | [optional] 
**Contact** | [**Contact**](Contact.md) | Activity model for primary contact,secondary contact | [optional] 
**CommunityInfo** | [**YammerCommunityInfoModel**](YammerCommunityInfoModel.md) | Activity model for community info | [optional] 
**HubSite** | [**HubSiteSetting**](HubSiteSetting.md) |  | [optional] 
**CommunitySharingCapabilities** | [**ExternalSharingOptions**](ExternalSharingOptions.md) |  | [optional] 
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
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**RequestSensitivityLabel**](RequestSensitivityLabel.md) |  | [optional] 
**Requester** | **String** |  | [optional] 

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
 -RequestSensitivityLabel null `
 -Requester null
```

- Convert the resource to JSON
```powershell
$CreateCommunityGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

