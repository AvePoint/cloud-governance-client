# Cloud.Governance.Client.Model.InviteGuestGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfficeTenantId** | **Guid** |  | [optional] 
**DisplayName** | [**TeamNameDescription**](TeamNameDescription.md) |  | [optional] 
**GuestDisplayName** | **string** |  | [optional] [readonly] 
**Contacts** | [**Contact**](Contact.md) | Activity model for primary contact,secondary contact | [optional] 
**EmailAddress** | [**InviteGuestUserPropertyRequestModel**](InviteGuestUserPropertyRequestModel.md) |  | [optional] 
**FirstName** | [**InviteGuestUserPropertyRequestModel**](InviteGuestUserPropertyRequestModel.md) |  | [optional] 
**LastName** | [**InviteGuestUserPropertyRequestModel**](InviteGuestUserPropertyRequestModel.md) |  | [optional] 
**WelcomeMessage** | [**InviteGuestUserPropertyRequestModel**](InviteGuestUserPropertyRequestModel.md) |  | [optional] 
**JobTitle** | [**InviteGuestUserPropertyRequestModel**](InviteGuestUserPropertyRequestModel.md) |  | [optional] 
**Department** | [**InviteGuestUserPropertyRequestModel**](InviteGuestUserPropertyRequestModel.md) |  | [optional] 
**CompanyName** | [**InviteGuestUserPropertyRequestModel**](InviteGuestUserPropertyRequestModel.md) |  | [optional] 
**UsageLocation** | [**InviteGuestUsageLocationRequestModel**](InviteGuestUsageLocationRequestModel.md) |  | [optional] 
**ContactInformation** | [**InviteGuestContactInformationRequestModel**](InviteGuestContactInformationRequestModel.md) |  | [optional] 
**Manager** | [**InviteGuestUserTypePropertyRequestModel**](InviteGuestUserTypePropertyRequestModel.md) |  | [optional] 
**ElectionProfile** | [**TeamElectionProfile**](TeamElectionProfile.md) |  | [optional] 
**RenewalProfile** | [**InviteGuestRenewalProfileRequestModel**](InviteGuestRenewalProfileRequestModel.md) |  | [optional] 
**PrimaryContact** | [**InviteGuestUserTypePropertyRequestModel**](InviteGuestUserTypePropertyRequestModel.md) |  | [optional] 
**SecondaryContact** | [**InviteGuestUserTypePropertyRequestModel**](InviteGuestUserTypePropertyRequestModel.md) |  | [optional] 
**AddToGroups** | [**InviteGuestAddToGroupsRequestModel**](InviteGuestAddToGroupsRequestModel.md) |  | [optional] 
**MultipleInvite** | [**InviteMultipleGuestRequestModel**](InviteMultipleGuestRequestModel.md) |  | [optional] 
**InviteGuestUserScope** | [**InviteGuestScopeRequestModel**](InviteGuestScopeRequestModel.md) |  | [optional] 
**LimitDomains** | [**ActivityModelbase**](ActivityModelbase.md) | This is activity model base class under dynamic request model. | [optional] 
**SubRequestIds** | **List&lt;Guid&gt;** |  | [optional] 
**GalleryType** | **string** |  | [optional] 
**GalleryInternalName** | **string** |  | [optional] 
**GalleryMetadata** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **bool?** |  | [optional] [default to false]
**RequestSensitivityLabel** | [**RequestSensitivityLabel**](RequestSensitivityLabel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

