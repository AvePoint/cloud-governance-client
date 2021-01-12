# SiteTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Category** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SiteTemplate = New-Cloud.Governance.ClientSiteTemplate  -Id null `
 -Title null `
 -Category null
```

- Convert the resource to JSON
```powershell
$SiteTemplate | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

