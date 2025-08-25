# ChangeSharedChannelGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SharedChannelInfo** | [**ChangeSharedChannelGallerySharedChannelInfo**](ChangeSharedChannelGallerySharedChannelInfo.md) |  | [optional] 
**SharedChannelName** | [**ChangeSharedChannelGallerySharedChannelName**](ChangeSharedChannelGallerySharedChannelName.md) |  | [optional] 
**SharedChannelDescription** | [**ChangeSharedChannelGallerySharedChannelDescription**](ChangeSharedChannelGallerySharedChannelDescription.md) |  | [optional] 
**Owners** | [**ChangeSharedChannelGalleryOwners**](ChangeSharedChannelGalleryOwners.md) |  | [optional] 
**Members** | [**ChangeSharedChannelGalleryOwners**](ChangeSharedChannelGalleryOwners.md) |  | [optional] 
**SiteStorage** | [**ChangeSharedChannelGallerySiteStorage**](ChangeSharedChannelGallerySiteStorage.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSharedChannelGallery = New-Cloud.Governance.ClientChangeSharedChannelGallery  -SharedChannelInfo null `
 -SharedChannelName null `
 -SharedChannelDescription null `
 -Owners null `
 -Members null `
 -SiteStorage null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$ChangeSharedChannelGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

