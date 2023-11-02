# DRSiteTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateName** | **String** |  | [optional] 
**TemplateTitle** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$DRSiteTemplate = New-Cloud.Governance.ClientDRSiteTemplate  -TemplateName null `
 -TemplateTitle null
```

- Convert the resource to JSON
```powershell
$DRSiteTemplate | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

