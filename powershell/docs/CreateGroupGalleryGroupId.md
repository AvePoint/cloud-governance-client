# CreateGroupGalleryGroupId
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Prefix** | **String** |  | [optional] 
**Suffix** | **String** |  | [optional] 
**Domain** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateGroupGalleryGroupId = New-Cloud.Governance.ClientCreateGroupGalleryGroupId  -Id null `
 -Prefix null `
 -Suffix null `
 -Domain null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateGroupGalleryGroupId | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

