# SiteUrlSettingAutoGenerateUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GenerateUrlType** | [**AutoGenerateUrlType**](AutoGenerateUrlType.md) |  | [optional] 
**SequentialNumberingSettings** | [**AutoGenerateUrlSettingSequentialNumberingSettings**](AutoGenerateUrlSettingSequentialNumberingSettings.md) |  | [optional] 
**RandomStringSettings** | [**AutoGenerateUrlSettingRandomStringSettings**](AutoGenerateUrlSettingRandomStringSettings.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SiteUrlSettingAutoGenerateUrlSetting = New-Cloud.Governance.ClientSiteUrlSettingAutoGenerateUrlSetting  -GenerateUrlType null `
 -SequentialNumberingSettings null `
 -RandomStringSettings null
```

- Convert the resource to JSON
```powershell
$SiteUrlSettingAutoGenerateUrlSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

