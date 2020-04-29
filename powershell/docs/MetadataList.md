# MetadataList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedBy** | **String** |  | [optional] [default to null]
**CreatedByDisplayName** | **String** |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**FieldType** | [**MetadataFieldType**](MetadataFieldType.md) |  | [optional] [default to null]
**MetadataValue** | **String** |  | [optional] [default to null]
**ShowInReportType** | [**MetadataDisplayType**](MetadataDisplayType.md) |  | [optional] [default to null]
**ShowInReportTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**LastModifiedTime** | **System.DateTime** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientMetadataList  -CreatedBy null `
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

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

