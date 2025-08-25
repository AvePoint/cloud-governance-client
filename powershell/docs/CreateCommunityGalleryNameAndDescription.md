# CreateCommunityGalleryNameAndDescription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **String** |  | [optional] 
**Prefix** | **String** |  | [optional] 
**Suffix** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateCommunityGalleryNameAndDescription = New-Cloud.Governance.ClientCreateCommunityGalleryNameAndDescription  -DisplayName null `
 -Prefix null `
 -Suffix null `
 -Description null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateCommunityGalleryNameAndDescription | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

