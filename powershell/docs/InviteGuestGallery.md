# InviteGuestGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfficeTenantId** | **String** |  | [optional] 
**DisplayName** | [**TeamNameDescription**](TeamNameDescription.md) |  | [optional] 
**GuestDisplayName** | **String** |  | [optional] [readonly] 
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
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

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
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$InviteGuestGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

