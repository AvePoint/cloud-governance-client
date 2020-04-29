# LanguageWithTemplates
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LanguageId** | **Int32** |  | [optional] [default to null]
**DefaultTemplate** | **String** |  | [optional] [default to null]
**Templates** | [**SiteTemplate[]**](SiteTemplate.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientLanguageWithTemplates  -LanguageId null `
 -DefaultTemplate null `
 -Templates null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

