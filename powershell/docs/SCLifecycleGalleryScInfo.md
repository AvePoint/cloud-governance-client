# SCLifecycleGalleryScInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$SCLifecycleGalleryScInfo = New-Cloud.Governance.ClientSCLifecycleGalleryScInfo  -TenantId null `
 -SiteId null `
 -Title null `
 -SiteUrl null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$SCLifecycleGalleryScInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

