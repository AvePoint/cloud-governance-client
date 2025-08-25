# CreateListServiceListTemplateSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AvailabeTemplates** | [**ListTemplate[]**](ListTemplate.md) |  | [optional] 
**DefaultTemplate** | **String** |  | [optional] 
**TemplateStoreUrl** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateListServiceListTemplateSettings = New-Cloud.Governance.ClientCreateListServiceListTemplateSettings  -AvailabeTemplates null `
 -DefaultTemplate null `
 -TemplateStoreUrl null
```

- Convert the resource to JSON
```powershell
$CreateListServiceListTemplateSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

