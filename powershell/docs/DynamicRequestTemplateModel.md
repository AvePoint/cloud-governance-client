# DynamicRequestTemplateModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceId** | **String** |  | [optional] 
**Summary** | **String** |  | [optional] 
**NotesToApprovers** | **String** |  | [optional] 
**ActivityGalleries** | [**Gallerybase[]**](Gallerybase.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$DynamicRequestTemplateModel = New-Cloud.Governance.ClientDynamicRequestTemplateModel  -ServiceId null `
 -Summary null `
 -NotesToApprovers null `
 -ActivityGalleries null
```

- Convert the resource to JSON
```powershell
$DynamicRequestTemplateModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

