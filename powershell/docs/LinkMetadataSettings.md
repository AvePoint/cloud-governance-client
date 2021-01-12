# LinkMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **String** |  | [optional] 
**Address** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LinkMetadataSettings = New-Cloud.Governance.ClientLinkMetadataSettings  -Title null `
 -Address null
```

- Convert the resource to JSON
```powershell
$LinkMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

