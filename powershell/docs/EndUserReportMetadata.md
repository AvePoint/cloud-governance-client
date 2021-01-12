# EndUserReportMetadata
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
$EndUserReportMetadata = New-Cloud.Governance.ClientEndUserReportMetadata  -Id null `
 -Name null `
 -Value null `
 -DisplayValue null `
 -Type null
```

- Convert the resource to JSON
```powershell
$EndUserReportMetadata | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

