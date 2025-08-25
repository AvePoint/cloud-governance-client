# Cloud.Governance.Client.Model.CreateEquipmentMailboxGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfficeTenantId** | **Guid** |  | [optional] 
**Name** | [**TeamNameDescription**](TeamNameDescription.md) |  | [optional] 
**Contacts** | [**Contact**](Contact.md) | Activity model for primary contact,secondary contact | [optional] 
**FullAccessUsers** | [**TeamMembers**](TeamMembers.md) |  | [optional] 
**EmailAddress** | [**EmailAddress**](EmailAddress.md) |  | [optional] 
**GlobalAddressList** | [**CreateResourceMailboxExchangeGlobalAddressListRequestModel**](CreateResourceMailboxExchangeGlobalAddressListRequestModel.md) |  | [optional] 
**MailboxEmail** | **string** |  | [optional] [readonly] 
**MailboxName** | **string** |  | [optional] [readonly] 
**SendAs** | [**TeamMembers**](TeamMembers.md) |  | [optional] 
**SendOnBehalf** | [**TeamMembers**](TeamMembers.md) |  | [optional] 
**MultiGeoLocationSetting** | [**MultiGeoLocationSetting**](MultiGeoLocationSetting.md) |  | [optional] 
**AddressBookPolicy** | [**CreateResourceMailboxAddressBookPolicyRequestModel**](CreateResourceMailboxAddressBookPolicyRequestModel.md) |  | [optional] 
**Alias** | [**CreateResourceMailboxAliasRequestModel**](CreateResourceMailboxAliasRequestModel.md) |  | [optional] 
**BookingDelegateSetting** | [**CreateResourceMailboxBookingDelegateSettingRequestModel**](CreateResourceMailboxBookingDelegateSettingRequestModel.md) |  | [optional] 
**BookingOption** | [**CreateResourceMailboxBookingOptionRequestModel**](CreateResourceMailboxBookingOptionRequestModel.md) |  | [optional] 
**Capacity** | [**CreateResourceMailboxCapacityRequestModel**](CreateResourceMailboxCapacityRequestModel.md) |  | [optional] 
**ContactInformation** | [**CreateResourceMailboxContactInformationRequestModel**](CreateResourceMailboxContactInformationRequestModel.md) |  | [optional] 
**Company** | [**CreateResourceMailboxCompanyRequestModel**](CreateResourceMailboxCompanyRequestModel.md) |  | [optional] 
**Department** | [**CreateResourceMailboxDepartmentRequestModel**](CreateResourceMailboxDepartmentRequestModel.md) |  | [optional] 
**DisableAccountSetting** | [**CreateResourceMailboxDisableAccountRequestModel**](CreateResourceMailboxDisableAccountRequestModel.md) |  | [optional] 
**MailTip** | [**CreateResourceMailboxMailTipRequestModel**](CreateResourceMailboxMailTipRequestModel.md) |  | [optional] 
**Tenant** | [**OfficeTenant**](OfficeTenant.md) |  | [optional] 
**GalleryType** | **string** |  | [optional] 
**GalleryInternalName** | **string** |  | [optional] 
**GalleryMetadata** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **bool?** |  | [optional] [default to false]
**RequestSensitivityLabel** | [**RequestSensitivityLabel**](RequestSensitivityLabel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

