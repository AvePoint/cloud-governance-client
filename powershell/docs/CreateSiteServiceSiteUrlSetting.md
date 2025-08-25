# CreateSiteServiceSiteUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | [**SiteConstructUrlType**](SiteConstructUrlType.md) |  | [optional] 
**ManuallyInputSetting** | [**SiteUrlSettingManuallyInputSetting**](SiteUrlSettingManuallyInputSetting.md) |  | [optional] 
**AutoGenerateUrlSetting** | [**SiteUrlSettingAutoGenerateUrlSetting**](SiteUrlSettingAutoGenerateUrlSetting.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSiteServiceSiteUrlSetting = New-Cloud.Governance.ClientCreateSiteServiceSiteUrlSetting  -Type null `
 -ManuallyInputSetting null `
 -AutoGenerateUrlSetting null
```

- Convert the resource to JSON
```powershell
$CreateSiteServiceSiteUrlSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

