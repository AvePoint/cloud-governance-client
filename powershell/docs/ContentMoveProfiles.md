# ContentMoveProfiles
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackupEnvironmentStoragePolices** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]
**ColumnMappings** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]
**ContentTypeMappings** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]
**UserMappings** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]
**LanguageMappings** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]
**FilterPolices** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientContentMoveProfiles  -BackupEnvironmentStoragePolices null `
 -ColumnMappings null `
 -ContentTypeMappings null `
 -UserMappings null `
 -LanguageMappings null `
 -FilterPolices null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

