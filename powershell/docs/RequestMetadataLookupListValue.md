# RequestMetadataLookupListValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnType** | **String** | type of lookup list column | [optional] 
**ColumnName** | **String** | name of lookup list column | [optional] 
**Value** | **String** | Value of lookup list | [optional] 
**DisplayValue** | **String** | Display value of lookup list | [optional] 

## Examples

- Prepare the resource
```powershell
$RequestMetadataLookupListValue = New-Cloud.Governance.ClientRequestMetadataLookupListValue  -ColumnType null `
 -ColumnName null `
 -Value null `
 -DisplayValue null
```

- Convert the resource to JSON
```powershell
$RequestMetadataLookupListValue | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

