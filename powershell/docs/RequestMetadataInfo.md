# RequestMetadataInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**TagName** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**FieldType** | **Int32** |  | [optional] [default to null]
**DefaultValue** | **String** |  | [optional] [default to null]
**MetadataValues** | **String** |  | [optional] [default to null]
**DisplayValues** | **String** |  | [optional] [default to null]
**ValueConfig** | **Int32** |  | [optional] [default to null]
**DisplayInReportType** | **Int32** |  | [optional] [default to null]
**Action** | **Int32** |  | [optional] [default to null]
**EnableTextValidation** | **Boolean** |  | [optional] [default to null]
**TextValidationRuleId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**OrginalValue** | **String** |  | [optional] [default to null]
**OrginalDisplayValue** | **String** |  | [optional] [default to null]
**IsNewMetadata** | **Boolean** |  | [optional] [default to null]
**OriginalTargetUserDisplayName** | **String** |  | [optional] [default to null]
**TenantId** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientRequestMetadataInfo  -Id null `
 -TagName null `
 -Description null `
 -FieldType null `
 -DefaultValue null `
 -MetadataValues null `
 -DisplayValues null `
 -ValueConfig null `
 -DisplayInReportType null `
 -Action null `
 -EnableTextValidation null `
 -TextValidationRuleId null `
 -OrginalValue null `
 -OrginalDisplayValue null `
 -IsNewMetadata null `
 -OriginalTargetUserDisplayName null `
 -TenantId null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

