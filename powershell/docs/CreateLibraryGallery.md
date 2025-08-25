# CreateLibraryGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NameDescription** | [**CreateLibraryGalleryNameDescription**](CreateLibraryGalleryNameDescription.md) |  | [optional] 
**VersionSetting** | [**CreateLibraryGalleryVersionSetting**](CreateLibraryGalleryVersionSetting.md) |  | [optional] 
**NavigationSetting** | [**CreateLibraryGalleryNavigationSetting**](CreateLibraryGalleryNavigationSetting.md) |  | [optional] 
**LibraryUrl** | [**CreateLibraryGalleryLibraryUrl**](CreateLibraryGalleryLibraryUrl.md) |  | [optional] 
**ConstructedUrl** | [**CreateLibraryGalleryConstructedUrl**](CreateLibraryGalleryConstructedUrl.md) |  | [optional] 
**PermissionSettings** | [**CreateLibraryGalleryPermissionSettings**](CreateLibraryGalleryPermissionSettings.md) |  | [optional] 
**LibraryDesign** | [**CreateLibraryGalleryLibraryDesign**](CreateLibraryGalleryLibraryDesign.md) |  | [optional] 
**ContentTypes** | [**CreateCommunityGalleryContentTypes**](CreateCommunityGalleryContentTypes.md) |  | [optional] 
**PnpTemplate** | [**CreateLibraryGalleryPnpTemplate**](CreateLibraryGalleryPnpTemplate.md) |  | [optional] 
**FolderDefaultValues** | [**FolderDefaultValueSetting[]**](FolderDefaultValueSetting.md) |  | [optional] 
**AddSiteColumns** | [**CreateLibraryGalleryAddSiteColumns**](CreateLibraryGalleryAddSiteColumns.md) |  | [optional] 
**LibraryRecordDeclaration** | [**CreateLibraryGalleryLibraryRecordDeclaration**](CreateLibraryGalleryLibraryRecordDeclaration.md) |  | [optional] 
**SetColumnDefaultValue** | [**CreateLibraryGallerySetColumnDefaultValue**](CreateLibraryGallerySetColumnDefaultValue.md) |  | [optional] 
**ListFullUrl** | **String** |  | [optional] [readonly] 
**CreateLibraryNotifyOpusForNewFiles** | [**CreateLibraryGalleryCreateLibraryNotifyOpusForNewFiles**](CreateLibraryGalleryCreateLibraryNotifyOpusForNewFiles.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

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
 -AddSiteColumns null `
 -LibraryRecordDeclaration null `
 -SetColumnDefaultValue null `
 -ListFullUrl null `
 -CreateLibraryNotifyOpusForNewFiles null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$CreateLibraryGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

