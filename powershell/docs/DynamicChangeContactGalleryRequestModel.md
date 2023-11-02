# DynamicChangeContactGalleryRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectInfo** | [**ChangeContactObjectModel**](ChangeContactObjectModel.md) |  | [optional] 
**ChangeContactInfo** | [**DynamicChangeContactModel**](DynamicChangeContactModel.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$DynamicChangeContactGalleryRequestModel = New-Cloud.Governance.ClientDynamicChangeContactGalleryRequestModel  -ObjectInfo null `
 -ChangeContactInfo null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$DynamicChangeContactGalleryRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

