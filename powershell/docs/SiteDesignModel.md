# SiteDesignModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** |  | [optional] 
**IsDefault** | **Boolean** |  | [optional] [default to $false]
**IsOutOfBoxTemplate** | **Boolean** |  | [optional] [default to $false]
**PreviewImageAltText** | **String** |  | [optional] 
**PreviewImageUrl** | **String** |  | [optional] 
**SiteScriptIds** | **String[]** |  | [optional] 
**Title** | **String** |  | [optional] 
**SupportedWebTemplates** | **Int32[]** |  | [optional] 
**Id** | **String** |  | [optional] 
**Version** | **Int32** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$SiteDesignModel = New-Cloud.Governance.ClientSiteDesignModel  -Description null `
 -IsDefault null `
 -IsOutOfBoxTemplate null `
 -PreviewImageAltText null `
 -PreviewImageUrl null `
 -SiteScriptIds null `
 -Title null `
 -SupportedWebTemplates null `
 -Id null `
 -Version null
```

- Convert the resource to JSON
```powershell
$SiteDesignModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

