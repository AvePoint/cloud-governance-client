# CreateSharedChannelGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SharedChannelInfo** | [**CreateSharedChannelGallerySharedChannelInfo**](CreateSharedChannelGallerySharedChannelInfo.md) |  | [optional] 
**SharedChannelNameAndDescription** | [**CreateCommunityGalleryNameAndDescription**](CreateCommunityGalleryNameAndDescription.md) |  | [optional] 
**Owners** | [**CreateCommunityGalleryOwners**](CreateCommunityGalleryOwners.md) |  | [optional] 
**Creator** | **String** |  | [optional] 
**Members** | [**CreateCommunityGalleryMembers**](CreateCommunityGalleryMembers.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSharedChannelGallery = New-Cloud.Governance.ClientCreateSharedChannelGallery  -SharedChannelInfo null `
 -SharedChannelNameAndDescription null `
 -Owners null `
 -Creator null `
 -Members null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$CreateSharedChannelGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

