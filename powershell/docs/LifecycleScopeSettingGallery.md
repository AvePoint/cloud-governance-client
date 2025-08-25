# LifecycleScopeSettingGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**GalleryType** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LifecycleScopeSettingGallery = New-Cloud.Governance.ClientLifecycleScopeSettingGallery  -Id null `
 -DisplayName null `
 -GalleryType null
```

- Convert the resource to JSON
```powershell
$LifecycleScopeSettingGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

