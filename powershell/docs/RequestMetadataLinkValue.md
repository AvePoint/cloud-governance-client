# RequestMetadataLinkValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **String** | Title of link metadata | [optional] 
**Address** | **String** | Address of link metadata | [optional] 

## Examples

- Prepare the resource
```powershell
$RequestMetadataLinkValue = New-Cloud.Governance.ClientRequestMetadataLinkValue  -Title null `
 -Address null
```

- Convert the resource to JSON
```powershell
$RequestMetadataLinkValue | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

