# CreateDistributionListGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Communication** | [**Communication**](Communication.md) |  | [optional] 
**MembershipApproval** | [**MembershipApproval**](MembershipApproval.md) |  | [optional] 
**MessageApproval** | [**MessageApproval**](MessageApproval.md) |  | [optional] 
**DeliveryManagement** | [**DeliveryManagement**](DeliveryManagement.md) |  | [optional] 
**GroupEmailAddress** | [**EmailAddress**](EmailAddress.md) |  | [optional] 
**GlobalAddressList** | [**GlobalAddressList**](GlobalAddressList.md) |  | [optional] 
**GroupEmail** | **String** |  | [optional] [readonly] 
**SendAs** | [**TeamMembers**](TeamMembers.md) |  | [optional] 
**SendOnBehalf** | [**TeamMembers**](TeamMembers.md) |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**GroupNameAndDescription** | [**TeamNameDescription**](TeamNameDescription.md) |  | [optional] 
**GroupContact** | [**Contact**](Contact.md) | Activity model for primary contact,secondary contact | [optional] 
**Owners** | [**TeamOwners**](TeamOwners.md) |  | [optional] 
**Members** | [**TeamMembers**](TeamMembers.md) |  | [optional] 
**Tenant** | [**OfficeTenant**](OfficeTenant.md) |  | [optional] 
**ElectionProfile** | [**TeamElectionProfile**](TeamElectionProfile.md) |  | [optional] 
**RenewalProfile** | [**RenewalProfile**](RenewalProfile.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateDistributionListGallery = New-Cloud.Governance.ClientCreateDistributionListGallery  -Communication null `
 -MembershipApproval null `
 -MessageApproval null `
 -DeliveryManagement null `
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
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$CreateDistributionListGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

