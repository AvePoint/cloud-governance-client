# SiteTemplateSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomSiteTemplate** | [**SiteTemplateSettingCustomSiteTemplate**](SiteTemplateSettingCustomSiteTemplate.md) |  | [optional] 
**SiteTemplate** | [**SiteTemplateSettingSiteTemplate**](SiteTemplateSettingSiteTemplate.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$SiteTemplateSetting = New-Cloud.Governance.ClientSiteTemplateSetting  -CustomSiteTemplate null `
 -SiteTemplate null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$SiteTemplateSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

