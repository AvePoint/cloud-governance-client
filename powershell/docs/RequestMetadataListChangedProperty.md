# RequestMetadataListChangedProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeValue** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**OriginalValue** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RequestMetadataListChangedProperty = New-Cloud.Governance.ClientRequestMetadataListChangedProperty  -ChangeValue null `
 -OriginalValue null
```

- Convert the resource to JSON
```powershell
$RequestMetadataListChangedProperty | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

