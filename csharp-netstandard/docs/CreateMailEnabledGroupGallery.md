# Cloud.Governance.Client.Model.CreateMailEnabledGroupGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Communication** | [**Communication**](Communication.md) |  | [optional] 
**MembershipApproval** | [**JoinGroupApproval**](JoinGroupApproval.md) |  | [optional] 
**MessageApproval** | [**MessageApproval**](MessageApproval.md) |  | [optional] 
**DeliveryStatusNotifications** | [**DeliveryStatusNotificationsRequestModel**](DeliveryStatusNotificationsRequestModel.md) |  | [optional] 
**GroupEmailAddress** | [**EmailAddress**](EmailAddress.md) |  | [optional] 
**GlobalAddressList** | [**GlobalAddressList**](GlobalAddressList.md) |  | [optional] 
**GroupEmail** | **string** |  | [optional] [readonly] 
**SendAs** | [**TeamMembers**](TeamMembers.md) |  | [optional] 
**SendOnBehalf** | [**TeamMembers**](TeamMembers.md) |  | [optional] 
**OfficeTenantId** | **Guid** |  | [optional] 
**GroupNameAndDescription** | [**TeamNameDescription**](TeamNameDescription.md) |  | [optional] 
**GroupContact** | [**Contact**](Contact.md) | Activity model for primary contact,secondary contact | [optional] 
**Owners** | [**TeamOwners**](TeamOwners.md) |  | [optional] 
**Members** | [**TeamMembers**](TeamMembers.md) |  | [optional] 
**Tenant** | [**OfficeTenant**](OfficeTenant.md) |  | [optional] 
**ElectionProfile** | [**TeamElectionProfile**](TeamElectionProfile.md) |  | [optional] 
**RenewalProfile** | [**RenewalProfile**](RenewalProfile.md) |  | [optional] 
**GalleryType** | **string** |  | [optional] 
**GalleryInternalName** | **string** |  | [optional] 
**GalleryMetadata** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **bool?** |  | [optional] [default to false]
**RequestSensitivityLabel** | [**RequestSensitivityLabel**](RequestSensitivityLabel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

