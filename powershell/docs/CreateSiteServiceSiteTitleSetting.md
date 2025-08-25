# CreateSiteServiceSiteTitleSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TitleAssignBy** | **Int32** |  | [optional] [default to 0]
**EnableTitleConstructure** | **Boolean** |  | [optional] [default to $false]
**TitlePrefixes** | [**SiteTitleConstructureRule[]**](SiteTitleConstructureRule.md) |  | [optional] 
**TitleSuffixes** | [**SiteTitleConstructureRule[]**](SiteTitleConstructureRule.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSiteServiceSiteTitleSetting = New-Cloud.Governance.ClientCreateSiteServiceSiteTitleSetting  -TitleAssignBy null `
 -EnableTitleConstructure null `
 -TitlePrefixes null `
 -TitleSuffixes null
```

- Convert the resource to JSON
```powershell
$CreateSiteServiceSiteTitleSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

