# CreateSharedMailboxGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContactInformation** | [**CreateSharedMailboxGalleryContactInformation**](CreateSharedMailboxGalleryContactInformation.md) |  | [optional] 
**MultiGeoLocationSetting** | [**CreateEquipmentMailboxGalleryMultiGeoLocationSetting**](CreateEquipmentMailboxGalleryMultiGeoLocationSetting.md) |  | [optional] 
**LanguageDataTime** | [**CreateSharedMailboxGalleryLanguageDataTime**](CreateSharedMailboxGalleryLanguageDataTime.md) |  | [optional] 
**TimeZone** | [**CreateSharedMailboxGalleryTimeZone**](CreateSharedMailboxGalleryTimeZone.md) |  | [optional] 
**EmailForwarding** | [**CreateSharedMailboxGalleryEmailForwarding**](CreateSharedMailboxGalleryEmailForwarding.md) |  | [optional] 
**AutoMappingSettings** | [**CreateSharedMailboxGalleryAutoMappingSettings**](CreateSharedMailboxGalleryAutoMappingSettings.md) |  | [optional] 
**SentItems** | [**CreateSharedMailboxGallerySentItems**](CreateSharedMailboxGallerySentItems.md) |  | [optional] 
**AutomaticReplies** | [**CreateSharedMailboxGalleryAutomaticReplies**](CreateSharedMailboxGalleryAutomaticReplies.md) |  | [optional] 
**Policies** | [**CreateSharedMailboxGalleryPolicies**](CreateSharedMailboxGalleryPolicies.md) |  | [optional] 
**GroupEmailAddress** | [**CreateDistributionListGalleryGroupEmailAddress**](CreateDistributionListGalleryGroupEmailAddress.md) |  | [optional] 
**GlobalAddressList** | [**ChangeTeamSettingGalleryRequestModelChangeGlobalAddressList**](ChangeTeamSettingGalleryRequestModelChangeGlobalAddressList.md) |  | [optional] 
**GroupEmail** | **String** |  | [optional] [readonly] 
**SendAs** | [**CreateCommunityGalleryMembers**](CreateCommunityGalleryMembers.md) |  | [optional] 
**SendOnBehalf** | [**CreateCommunityGalleryMembers**](CreateCommunityGalleryMembers.md) |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**GroupNameAndDescription** | [**CreateCommunityGalleryNameAndDescription**](CreateCommunityGalleryNameAndDescription.md) |  | [optional] 
**GroupContact** | [**CreateCommunityGalleryContact**](CreateCommunityGalleryContact.md) |  | [optional] 
**Owners** | [**CreateCommunityGalleryOwners**](CreateCommunityGalleryOwners.md) |  | [optional] 
**Members** | [**CreateCommunityGalleryMembers**](CreateCommunityGalleryMembers.md) |  | [optional] 
**Tenant** | [**CreateCommunityGalleryTenant**](CreateCommunityGalleryTenant.md) |  | [optional] 
**ElectionProfile** | [**CreateCommunityGalleryElectionProfile**](CreateCommunityGalleryElectionProfile.md) |  | [optional] 
**RenewalProfile** | [**CreateCommunityGalleryRenewalProfile**](CreateCommunityGalleryRenewalProfile.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSharedMailboxGallery = New-Cloud.Governance.ClientCreateSharedMailboxGallery  -ContactInformation null `
 -MultiGeoLocationSetting null `
 -LanguageDataTime null `
 -TimeZone null `
 -EmailForwarding null `
 -AutoMappingSettings null `
 -SentItems null `
 -AutomaticReplies null `
 -Policies null `
 -GroupEmailAddress null `
 -GlobalAddressList null `
 -GroupEmail null `
 -SendAs null `
 -SendOnBehalf null `
 -OfficeTenantId null `
 -GroupNameAndDescription null `
 -GroupContact null `
 -Owners null `
 -Members null `
 -Tenant null `
 -ElectionProfile null `
 -RenewalProfile null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$CreateSharedMailboxGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

