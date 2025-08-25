# CreateSecurityGroupGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
$CreateSecurityGroupGallery = New-Cloud.Governance.ClientCreateSecurityGroupGallery  -OfficeTenantId null `
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
$CreateSecurityGroupGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

