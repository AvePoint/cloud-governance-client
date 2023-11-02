# ExchangeResourceLifecycleGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Office365TenantId** | **String** |  | [optional] 
**GroupInfo** | [**DynamicExchangeResource**](DynamicExchangeResource.md) | Activity model for Azure Object Info | [optional] 
**LifecycleScopeSetting** | [**LifecycleScopeSetting**](LifecycleScopeSetting.md) |  | [optional] 
**LifecycleActions** | [**LifecycleActions**](LifecycleActions.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ExchangeResourceLifecycleGallery = New-Cloud.Governance.ClientExchangeResourceLifecycleGallery  -Office365TenantId null `
 -GroupInfo null `
 -LifecycleScopeSetting null `
 -LifecycleActions null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$ExchangeResourceLifecycleGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

