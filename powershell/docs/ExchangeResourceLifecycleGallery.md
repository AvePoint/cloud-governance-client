# ExchangeResourceLifecycleGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Office365TenantId** | **String** |  | [optional] 
**GroupInfo** | [**ExchangeResourceLifecycleGalleryGroupInfo**](ExchangeResourceLifecycleGalleryGroupInfo.md) |  | [optional] 
**LifecycleScopeSetting** | [**ExchangeResourceLifecycleGalleryLifecycleScopeSetting**](ExchangeResourceLifecycleGalleryLifecycleScopeSetting.md) |  | [optional] 
**LifecycleActions** | [**ExchangeResourceLifecycleGalleryLifecycleActions**](ExchangeResourceLifecycleGalleryLifecycleActions.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ExchangeResourceLifecycleGallery = New-Cloud.Governance.ClientExchangeResourceLifecycleGallery  -Office365TenantId null `
 -GroupInfo null `
 -LifecycleScopeSetting null `
 -LifecycleActions null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$ExchangeResourceLifecycleGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

