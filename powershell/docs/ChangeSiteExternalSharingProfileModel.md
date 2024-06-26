# ChangeSiteExternalSharingProfileModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OriginalProfile** | [**GuidModel**](GuidModel.md) |  | [optional] 
**DestinationProfile** | [**GuidModel**](GuidModel.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteExternalSharingProfileModel = New-Cloud.Governance.ClientChangeSiteExternalSharingProfileModel  -OriginalProfile null `
 -DestinationProfile null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeSiteExternalSharingProfileModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

