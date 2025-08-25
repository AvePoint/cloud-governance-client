# CreateRoomMailboxGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalInformation** | [**CreateRoomMailboxGalleryAdditionalInformation**](CreateRoomMailboxGalleryAdditionalInformation.md) |  | [optional] 
**RoomList** | [**CreateRoomMailboxGalleryRoomList**](CreateRoomMailboxGalleryRoomList.md) |  | [optional] 
**RoomPlace** | [**CreateRoomMailboxGalleryRoomPlace**](CreateRoomMailboxGalleryRoomPlace.md) |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**Name** | [**CreateCommunityGalleryNameAndDescription**](CreateCommunityGalleryNameAndDescription.md) |  | [optional] 
**Contacts** | [**CreateCommunityGalleryContact**](CreateCommunityGalleryContact.md) |  | [optional] 
**FullAccessUsers** | [**CreateCommunityGalleryMembers**](CreateCommunityGalleryMembers.md) |  | [optional] 
**EmailAddress** | [**CreateDistributionListGalleryGroupEmailAddress**](CreateDistributionListGalleryGroupEmailAddress.md) |  | [optional] 
**GlobalAddressList** | [**CreateEquipmentMailboxGalleryGlobalAddressList**](CreateEquipmentMailboxGalleryGlobalAddressList.md) |  | [optional] 
**MailboxEmail** | **String** |  | [optional] [readonly] 
**MailboxName** | **String** |  | [optional] [readonly] 
**SendAs** | [**CreateCommunityGalleryMembers**](CreateCommunityGalleryMembers.md) |  | [optional] 
**SendOnBehalf** | [**CreateCommunityGalleryMembers**](CreateCommunityGalleryMembers.md) |  | [optional] 
**MultiGeoLocationSetting** | [**CreateEquipmentMailboxGalleryMultiGeoLocationSetting**](CreateEquipmentMailboxGalleryMultiGeoLocationSetting.md) |  | [optional] 
**AddressBookPolicy** | [**CreateEquipmentMailboxGalleryAddressBookPolicy**](CreateEquipmentMailboxGalleryAddressBookPolicy.md) |  | [optional] 
**Alias** | [**CreateEquipmentMailboxGalleryAlias**](CreateEquipmentMailboxGalleryAlias.md) |  | [optional] 
**BookingDelegateSetting** | [**CreateEquipmentMailboxGalleryBookingDelegateSetting**](CreateEquipmentMailboxGalleryBookingDelegateSetting.md) |  | [optional] 
**BookingOption** | [**CreateEquipmentMailboxGalleryBookingOption**](CreateEquipmentMailboxGalleryBookingOption.md) |  | [optional] 
**Capacity** | [**CreateEquipmentMailboxGalleryCapacity**](CreateEquipmentMailboxGalleryCapacity.md) |  | [optional] 
**ContactInformation** | [**CreateEquipmentMailboxGalleryContactInformation**](CreateEquipmentMailboxGalleryContactInformation.md) |  | [optional] 
**Company** | [**CreateEquipmentMailboxGalleryCompany**](CreateEquipmentMailboxGalleryCompany.md) |  | [optional] 
**Department** | [**CreateEquipmentMailboxGalleryDepartment**](CreateEquipmentMailboxGalleryDepartment.md) |  | [optional] 
**DisableAccountSetting** | [**CreateEquipmentMailboxGalleryDisableAccountSetting**](CreateEquipmentMailboxGalleryDisableAccountSetting.md) |  | [optional] 
**MailTip** | [**CreateEquipmentMailboxGalleryMailTip**](CreateEquipmentMailboxGalleryMailTip.md) |  | [optional] 
**Tenant** | [**CreateCommunityGalleryTenant**](CreateCommunityGalleryTenant.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateRoomMailboxGallery = New-Cloud.Governance.ClientCreateRoomMailboxGallery  -AdditionalInformation null `
 -RoomList null `
 -RoomPlace null `
 -OfficeTenantId null `
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
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$CreateRoomMailboxGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

