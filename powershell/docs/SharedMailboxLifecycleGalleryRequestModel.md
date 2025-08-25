# SharedMailboxLifecycleGalleryRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SharedMailboxInfo** | [**ChangeSharedMailboxPermissionGalleryChangedSharedMailboxInfo**](ChangeSharedMailboxPermissionGalleryChangedSharedMailboxInfo.md) |  | [optional] 
**LifecycleActions** | [**ExchangeResourceLifecycleGalleryLifecycleActions**](ExchangeResourceLifecycleGalleryLifecycleActions.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SharedMailboxLifecycleGalleryRequestModel = New-Cloud.Governance.ClientSharedMailboxLifecycleGalleryRequestModel  -SharedMailboxInfo null `
 -LifecycleActions null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$SharedMailboxLifecycleGalleryRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

