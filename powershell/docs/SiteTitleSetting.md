# SiteTitleSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TitleAssignBy** | **Int32** |  | [optional] [default to null]
**EnableTitleConstructure** | **Boolean** |  | [optional] [default to null]
**TitlePrefixes** | [**SiteTitleConstructureRule[]**](SiteTitleConstructureRule.md) |  | [optional] [default to null]
**TitleSuffixes** | [**SiteTitleConstructureRule[]**](SiteTitleConstructureRule.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSiteTitleSetting  -TitleAssignBy null `
 -EnableTitleConstructure null `
 -TitlePrefixes null `
 -TitleSuffixes null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

