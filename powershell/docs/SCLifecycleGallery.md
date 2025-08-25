# SCLifecycleGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScInfo** | [**SCLifecycleGalleryScInfo**](SCLifecycleGalleryScInfo.md) |  | [optional] 
**ScLifecycleActionDetails** | [**SCLifecycleGalleryScLifecycleActionDetails**](SCLifecycleGalleryScLifecycleActionDetails.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SCLifecycleGallery = New-Cloud.Governance.ClientSCLifecycleGallery  -ScInfo null `
 -ScLifecycleActionDetails null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$SCLifecycleGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

