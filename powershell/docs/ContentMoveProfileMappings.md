# ContentMoveProfileMappings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnMapping** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**ContentTypeMapping** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**UserMapping** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**LanguageMapping** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientContentMoveProfileMappings  -ColumnMapping null `
 -ContentTypeMapping null `
 -UserMapping null `
 -LanguageMapping null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

