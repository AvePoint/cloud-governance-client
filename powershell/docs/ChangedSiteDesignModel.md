# ChangedSiteDesignModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**IsOutOfBoxTemplate** | **Boolean** |  | [optional] [default to $false]
**Tenant** | [**GuidModel**](GuidModel.md) |  | [optional] 
**SupportedWebTemplates** | [**SiteTemplateTypeSetting[]**](SiteTemplateTypeSetting.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangedSiteDesignModel = New-Cloud.Governance.ClientChangedSiteDesignModel  -Id null `
 -Title null `
 -IsOutOfBoxTemplate null `
 -Tenant null `
 -SupportedWebTemplates null
```

- Convert the resource to JSON
```powershell
$ChangedSiteDesignModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

