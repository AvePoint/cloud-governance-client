# ContentMoveProfileMappings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnMapping** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**ContentTypeMapping** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**UserMapping** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**LanguageMapping** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 

## Examples

- Prepare the resource
```powershell
$ContentMoveProfileMappings = New-Cloud.Governance.ClientContentMoveProfileMappings  -ColumnMapping null `
 -ContentTypeMapping null `
 -UserMapping null `
 -LanguageMapping null
```

- Convert the resource to JSON
```powershell
$ContentMoveProfileMappings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

