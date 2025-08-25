# M365GroupLifecycleGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Office365TenantId** | **String** |  | [optional] 
**M365GroupInfo** | [**M365GroupLifecycleGalleryM365GroupInfo**](M365GroupLifecycleGalleryM365GroupInfo.md) |  | [optional] 
**M365GroupLifecycleScopeSetting** | [**M365GroupLifecycleGalleryM365GroupLifecycleScopeSetting**](M365GroupLifecycleGalleryM365GroupLifecycleScopeSetting.md) |  | [optional] 
**M365GroupLifecycleActions** | [**M365GroupLifecycleGalleryM365GroupLifecycleActions**](M365GroupLifecycleGalleryM365GroupLifecycleActions.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$M365GroupLifecycleGallery = New-Cloud.Governance.ClientM365GroupLifecycleGallery  -Office365TenantId null `
 -M365GroupInfo null `
 -M365GroupLifecycleScopeSetting null `
 -M365GroupLifecycleActions null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$M365GroupLifecycleGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

