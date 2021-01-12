# MetadataGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedBy** | **String** |  | [optional] 
**CreatedByDisplayName** | **String** |  | [optional] 
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**FieldType** | [**MetadataFieldType**](MetadataFieldType.md) |  | [optional] 
**MetadataValue** | **String** |  | [optional] 
**ShowInReportType** | [**MetadataDisplayType**](MetadataDisplayType.md) |  | [optional] 
**ShowInReportTypeDescription** | **String** |  | [optional] 
**LastModifiedTime** | **System.DateTime** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MetadataGridModel = New-Cloud.Governance.ClientMetadataGridModel  -CreatedBy null `
 -CreatedByDisplayName null `
 -Id null `
 -Name null `
 -Description null `
 -FieldType null `
 -MetadataValue null `
 -ShowInReportType null `
 -ShowInReportTypeDescription null `
 -LastModifiedTime null
```

- Convert the resource to JSON
```powershell
$MetadataGridModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

