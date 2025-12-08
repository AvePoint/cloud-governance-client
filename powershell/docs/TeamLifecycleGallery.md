# TeamLifecycleGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeamInfo** | [**LifecycleTeamModel**](LifecycleTeamModel.md) |  | [optional] 
**TeamLifecycleActionDetails** | [**TeamLifecycleActionModel**](TeamLifecycleActionModel.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**RequestSensitivityLabel**](RequestSensitivityLabel.md) |  | [optional] 
**Requester** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TeamLifecycleGallery = New-Cloud.Governance.ClientTeamLifecycleGallery  -TeamInfo null `
 -TeamLifecycleActionDetails null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null `
 -Requester null
```

- Convert the resource to JSON
```powershell
$TeamLifecycleGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

