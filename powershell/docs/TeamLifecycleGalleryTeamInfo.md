# TeamLifecycleGalleryTeamInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**ObjectId** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**SharedPointSiteUrl** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$TeamLifecycleGalleryTeamInfo = New-Cloud.Governance.ClientTeamLifecycleGalleryTeamInfo  -TenantId null `
 -ObjectId null `
 -Email null `
 -DisplayName null `
 -SharedPointSiteUrl null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$TeamLifecycleGalleryTeamInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

