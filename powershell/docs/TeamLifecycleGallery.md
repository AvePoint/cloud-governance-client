# TeamLifecycleGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeamInfo** | [**TeamLifecycleGalleryTeamInfo**](TeamLifecycleGalleryTeamInfo.md) |  | [optional] 
**TeamLifecycleActionDetails** | [**TeamLifecycleGalleryTeamLifecycleActionDetails**](TeamLifecycleGalleryTeamLifecycleActionDetails.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TeamLifecycleGallery = New-Cloud.Governance.ClientTeamLifecycleGallery  -TeamInfo null `
 -TeamLifecycleActionDetails null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$TeamLifecycleGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

