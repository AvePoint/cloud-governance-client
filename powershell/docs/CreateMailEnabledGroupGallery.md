# CreateMailEnabledGroupGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Communication** | [**CreateDistributionListGalleryCommunication**](CreateDistributionListGalleryCommunication.md) |  | [optional] 
**MembershipApproval** | [**CreateMailEnabledGroupGalleryMembershipApproval**](CreateMailEnabledGroupGalleryMembershipApproval.md) |  | [optional] 
**MessageApproval** | [**CreateDistributionListGalleryMessageApproval**](CreateDistributionListGalleryMessageApproval.md) |  | [optional] 
**DeliveryStatusNotifications** | [**CreateMailEnabledGroupGalleryDeliveryStatusNotifications**](CreateMailEnabledGroupGalleryDeliveryStatusNotifications.md) |  | [optional] 
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
$CreateMailEnabledGroupGallery = New-Cloud.Governance.ClientCreateMailEnabledGroupGallery  -Communication null `
 -MembershipApproval null `
 -MessageApproval null `
 -DeliveryStatusNotifications null `
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
$CreateMailEnabledGroupGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

