# ChangeSharedChannelGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SharedChannelInfo** | [**ChangeSharedChannelModel**](ChangeSharedChannelModel.md) |  | [optional] 
**SharedChannelName** | [**SharedChannelName**](SharedChannelName.md) |  | [optional] 
**SharedChannelDescription** | [**SharedChannelDescription**](SharedChannelDescription.md) |  | [optional] 
**Owners** | [**SharedChannelChangedMembership**](SharedChannelChangedMembership.md) |  | [optional] 
**Members** | [**SharedChannelChangedMembership**](SharedChannelChangedMembership.md) |  | [optional] 
**SiteStorage** | [**ChangeSiteStorageSettingModel**](ChangeSiteStorageSettingModel.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

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
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$ChangeSharedChannelGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

