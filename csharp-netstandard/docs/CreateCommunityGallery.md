# Cloud.Governance.Client.Model.CreateCommunityGallery
This is create community gallery model class inside DynamicRequest.ActivityGalleries
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **string** |  | [optional] 
**ContentTypes** | [**ContentTypes**](ContentTypes.md) |  | [optional] 
**NameAndDescription** | [**TeamNameDescription**](TeamNameDescription.md) |  | [optional] 
**Contact** | [**Contact**](Contact.md) | Activity model for primary contact,secondary contact | [optional] 
**CommunityInfo** | [**YammerCommunityInfoModel**](YammerCommunityInfoModel.md) | Activity model for community info | [optional] 
**HubSite** | [**HubSiteSetting**](HubSiteSetting.md) |  | [optional] 
**CommunitySharingCapabilities** | **ExternalSharingOptions** |  | [optional] 
**OfficeTenantId** | **Guid** |  | [optional] 
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
**TeamEmail** | **string** |  | [optional] [readonly] 
**GalleryType** | **string** |  | [optional] 
**GalleryInternalName** | **string** |  | [optional] 
**GalleryMetadata** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **bool?** |  | [optional] [default to false]
**RequestSensitivityLabel** | [**RequestSensitivityLabel**](RequestSensitivityLabel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

