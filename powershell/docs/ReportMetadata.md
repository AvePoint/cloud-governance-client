# ReportMetadata
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Value** | **String** |  | [optional] 
**DisplayValue** | **String** |  | [optional] 
**Type** | [**MetadataFieldType**](MetadataFieldType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ReportMetadata = New-Cloud.Governance.ClientReportMetadata  -Id null `
 -Name null `
 -Value null `
 -DisplayValue null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ReportMetadata | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

