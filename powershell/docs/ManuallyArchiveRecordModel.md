# ManuallyArchiveRecordModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RowKey** | **String** |  | [default to null]
**PartitionKey** | **String** |  | [optional] [readonly] [default to null]
**SiteId** | [**UUID**](UUID.md) |  | [optional] [readonly] [default to null]
**Url** | **String** |  | [optional] [readonly] [default to null]
**Version** | **String** |  | [optional] [readonly] [default to null]
**IsSelected** | **Boolean** |  | [optional] [default to null]
**NodeType** | [**ManualArchiveNodeLevel**](ManualArchiveNodeLevel.md) |  | [optional] [default to null]
**NodeTypeDescription** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientManuallyArchiveRecordModel  -RowKey null `
 -PartitionKey null `
 -SiteId null `
 -Url null `
 -Version null `
 -IsSelected null `
 -NodeType null `
 -NodeTypeDescription null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

