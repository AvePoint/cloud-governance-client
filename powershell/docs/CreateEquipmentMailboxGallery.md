# CreateEquipmentMailboxGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfficeTenantId** | **String** |  | [optional] 
**Name** | [**TeamNameDescription**](TeamNameDescription.md) |  | [optional] 
**Contacts** | [**Contact**](Contact.md) | Activity model for primary contact,secondary contact | [optional] 
**FullAccessUsers** | [**TeamMembers**](TeamMembers.md) |  | [optional] 
**EmailAddress** | [**EmailAddress**](EmailAddress.md) |  | [optional] 
**GlobalAddressList** | [**CreateResourceMailboxExchangeGlobalAddressListRequestModel**](CreateResourceMailboxExchangeGlobalAddressListRequestModel.md) |  | [optional] 
**MailboxEmail** | **String** |  | [optional] [readonly] 
**MailboxName** | **String** |  | [optional] [readonly] 
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
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateEquipmentMailboxGallery = New-Cloud.Governance.ClientCreateEquipmentMailboxGallery  -OfficeTenantId null `
 -Name null `
 -Contacts null `
 -FullAccessUsers null `
 -EmailAddress null `
 -GlobalAddressList null `
 -MailboxEmail null `
 -MailboxName null `
 -SendAs null `
 -SendOnBehalf null `
 -MultiGeoLocationSetting null `
 -AddressBookPolicy null `
 -Alias null `
 -BookingDelegateSetting null `
 -BookingOption null `
 -Capacity null `
 -ContactInformation null `
 -Company null `
 -Department null `
 -DisableAccountSetting null `
 -MailTip null `
 -Tenant null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$CreateEquipmentMailboxGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

