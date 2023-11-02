# SiteTemplateTypeSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateType** | [**SiteTemplateTypeInSiteDesign**](SiteTemplateTypeInSiteDesign.md) |  | [optional] 
**DisplayName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SiteTemplateTypeSetting = New-Cloud.Governance.ClientSiteTemplateTypeSetting  -TemplateType null `
 -DisplayName null
```

- Convert the resource to JSON
```powershell
$SiteTemplateTypeSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

