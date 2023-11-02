# CreateLibraryGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NameDescription** | [**NameDescription**](NameDescription.md) |  | [optional] 
**VersionSetting** | [**LibraryVersionSetting**](LibraryVersionSetting.md) |  | [optional] 
**NavigationSetting** | [**NavigationSetting**](NavigationSetting.md) |  | [optional] 
**LibraryUrl** | [**LibraryScope**](LibraryScope.md) |  | [optional] 
**ConstructedUrl** | [**ConstructedUrl**](ConstructedUrl.md) |  | [optional] 
**PermissionSettings** | [**ListPermissionSetting**](ListPermissionSetting.md) |  | [optional] 
**LibraryDesign** | [**LibraryDesign**](LibraryDesign.md) |  | [optional] 
**ContentTypes** | [**ContentTypes**](ContentTypes.md) |  | [optional] 
**PnpTemplate** | [**PnpTemplate**](PnpTemplate.md) |  | [optional] 
**FolderDefaultValues** | [**FolderDefaultValueSetting[]**](FolderDefaultValueSetting.md) |  | [optional] 
**ListFullUrl** | **String** |  | [optional] [readonly] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateLibraryGallery = New-Cloud.Governance.ClientCreateLibraryGallery  -NameDescription null `
 -VersionSetting null `
 -NavigationSetting null `
 -LibraryUrl null `
 -ConstructedUrl null `
 -PermissionSettings null `
 -LibraryDesign null `
 -ContentTypes null `
 -PnpTemplate null `
 -FolderDefaultValues null `
 -ListFullUrl null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$CreateLibraryGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

