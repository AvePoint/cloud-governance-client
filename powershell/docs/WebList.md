# WebList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**Url** | **String** |  | [optional] [default to null]
**Template** | **String** |  | [optional] [default to null]
**PrimaryContact** | **String** |  | [optional] [default to null]
**PrimaryContactDisplayName** | **String** |  | [optional] [default to null]
**SecondaryContact** | **String** |  | [optional] [default to null]
**SecondaryContactDisplayName** | **String** |  | [optional] [default to null]
**CreatedTime** | **String** |  | [optional] [default to null]
**Status** | [**GroupStatus**](GroupStatus.md) |  | [optional] [default to null]
**StatusDescription** | **String** |  | [optional] [readonly] [default to null]
**Metadata** | [**ReportMetadata[]**](ReportMetadata.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientWebList  -Id null `
 -Description null `
 -Title null `
 -Url null `
 -Template null `
 -PrimaryContact null `
 -PrimaryContactDisplayName null `
 -SecondaryContact null `
 -SecondaryContactDisplayName null `
 -CreatedTime null `
 -Status null `
 -StatusDescription null `
 -Metadata null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

