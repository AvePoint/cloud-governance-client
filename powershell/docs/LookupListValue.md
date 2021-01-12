# LookupListValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnType** | **String** |  | [optional] 
**ColumnName** | **String** |  | [optional] 
**Value** | **String** |  | [optional] 
**DisplayValue** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LookupListValue = New-Cloud.Governance.ClientLookupListValue  -ColumnType null `
 -ColumnName null `
 -Value null `
 -DisplayValue null
```

- Convert the resource to JSON
```powershell
$LookupListValue | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

