# LanguageWithTemplates
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LanguageId** | **Int32** |  | [optional] [default to 0]
**DefaultTemplate** | **String** |  | [optional] 
**Templates** | [**SiteTemplate[]**](SiteTemplate.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LanguageWithTemplates = New-Cloud.Governance.ClientLanguageWithTemplates  -LanguageId null `
 -DefaultTemplate null `
 -Templates null
```

- Convert the resource to JSON
```powershell
$LanguageWithTemplates | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

