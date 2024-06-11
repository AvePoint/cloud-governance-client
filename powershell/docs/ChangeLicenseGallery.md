# ChangeLicenseGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UsersInfo** | [**ChangeLicenseUserModel**](ChangeLicenseUserModel.md) |  | [optional] 
**LicenseDetails** | [**ChangeLicenseModel**](ChangeLicenseModel.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeLicenseGallery = New-Cloud.Governance.ClientChangeLicenseGallery  -UsersInfo null `
 -LicenseDetails null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$ChangeLicenseGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

