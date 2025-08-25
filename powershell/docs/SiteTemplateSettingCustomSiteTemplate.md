# SiteTemplateSettingCustomSiteTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateStoreUrl** | **String** |  | [optional] 
**TemplateName** | **String** |  | [optional] 
**ClearSolutionGallery** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$SiteTemplateSettingCustomSiteTemplate = New-Cloud.Governance.ClientSiteTemplateSettingCustomSiteTemplate  -TemplateStoreUrl null `
 -TemplateName null `
 -ClearSolutionGallery null
```

- Convert the resource to JSON
```powershell
$SiteTemplateSettingCustomSiteTemplate | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

