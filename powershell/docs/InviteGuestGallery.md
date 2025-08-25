# InviteGuestGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfficeTenantId** | **String** |  | [optional] 
**DisplayName** | [**CreateCommunityGalleryNameAndDescription**](CreateCommunityGalleryNameAndDescription.md) |  | [optional] 
**GuestDisplayName** | **String** |  | [optional] [readonly] 
**Contacts** | [**CreateCommunityGalleryContact**](CreateCommunityGalleryContact.md) |  | [optional] 
**EmailAddress** | [**InviteGuestGalleryEmailAddress**](InviteGuestGalleryEmailAddress.md) |  | [optional] 
**FirstName** | [**InviteGuestGalleryEmailAddress**](InviteGuestGalleryEmailAddress.md) |  | [optional] 
**LastName** | [**InviteGuestGalleryEmailAddress**](InviteGuestGalleryEmailAddress.md) |  | [optional] 
**WelcomeMessage** | [**InviteGuestGalleryEmailAddress**](InviteGuestGalleryEmailAddress.md) |  | [optional] 
**JobTitle** | [**InviteGuestGalleryEmailAddress**](InviteGuestGalleryEmailAddress.md) |  | [optional] 
**Department** | [**InviteGuestGalleryEmailAddress**](InviteGuestGalleryEmailAddress.md) |  | [optional] 
**CompanyName** | [**InviteGuestGalleryEmailAddress**](InviteGuestGalleryEmailAddress.md) |  | [optional] 
**UsageLocation** | [**InviteGuestGalleryUsageLocation**](InviteGuestGalleryUsageLocation.md) |  | [optional] 
**ContactInformation** | [**InviteGuestGalleryContactInformation**](InviteGuestGalleryContactInformation.md) |  | [optional] 
**Manager** | [**InviteGuestGalleryManager**](InviteGuestGalleryManager.md) |  | [optional] 
**ElectionProfile** | [**CreateCommunityGalleryElectionProfile**](CreateCommunityGalleryElectionProfile.md) |  | [optional] 
**RenewalProfile** | [**InviteGuestGalleryRenewalProfile**](InviteGuestGalleryRenewalProfile.md) |  | [optional] 
**PrimaryContact** | [**InviteGuestGalleryManager**](InviteGuestGalleryManager.md) |  | [optional] 
**SecondaryContact** | [**InviteGuestGalleryManager**](InviteGuestGalleryManager.md) |  | [optional] 
**AddToGroups** | [**InviteGuestGalleryAddToGroups**](InviteGuestGalleryAddToGroups.md) |  | [optional] 
**MultipleInvite** | [**InviteGuestGalleryMultipleInvite**](InviteGuestGalleryMultipleInvite.md) |  | [optional] 
**InviteGuestUserScope** | [**InviteGuestGalleryInviteGuestUserScope**](InviteGuestGalleryInviteGuestUserScope.md) |  | [optional] 
**LimitDomains** | [**InviteGuestGalleryLimitDomains**](InviteGuestGalleryLimitDomains.md) |  | [optional] 
**SubRequestIds** | **String[]** |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$InviteGuestGallery = New-Cloud.Governance.ClientInviteGuestGallery  -OfficeTenantId null `
 -DisplayName null `
 -GuestDisplayName null `
 -Contacts null `
 -EmailAddress null `
 -FirstName null `
 -LastName null `
 -WelcomeMessage null `
 -JobTitle null `
 -Department null `
 -CompanyName null `
 -UsageLocation null `
 -ContactInformation null `
 -Manager null `
 -ElectionProfile null `
 -RenewalProfile null `
 -PrimaryContact null `
 -SecondaryContact null `
 -AddToGroups null `
 -MultipleInvite null `
 -InviteGuestUserScope null `
 -LimitDomains null `
 -SubRequestIds null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$InviteGuestGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

