# CreateSharedChannelGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SharedChannelInfo** | [**CreateSharedChannelModel**](CreateSharedChannelModel.md) |  | [optional] 
**SharedChannelNameAndDescription** | [**TeamNameDescription**](TeamNameDescription.md) |  | [optional] 
**Owners** | [**TeamOwners**](TeamOwners.md) |  | [optional] 
**Creator** | **String** |  | [optional] 
**Members** | [**TeamMembers**](TeamMembers.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

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
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$CreateSharedChannelGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

