# CustomSiteTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateStoreUrl** | **String** |  | [optional] 
**TemplateName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CustomSiteTemplate = New-Cloud.Governance.ClientCustomSiteTemplate  -TemplateStoreUrl null `
 -TemplateName null
```

- Convert the resource to JSON
```powershell
$CustomSiteTemplate | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

