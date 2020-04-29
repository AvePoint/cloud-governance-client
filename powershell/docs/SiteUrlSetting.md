# SiteUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | [**SiteConstructUrlType**](SiteConstructUrlType.md) |  | [optional] [default to null]
**ManuallyInputSetting** | [**ManuallyInputUrlSetting**](ManuallyInputUrlSetting.md) |  | [optional] [default to null]
**AutoGenerateUrlSetting** | [**AutoGenerateUrlSetting**](AutoGenerateUrlSetting.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSiteUrlSetting  -Type null `
 -ManuallyInputSetting null `
 -AutoGenerateUrlSetting null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

