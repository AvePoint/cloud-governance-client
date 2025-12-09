# SiteUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | [**SiteConstructUrlType**](SiteConstructUrlType.md) |  | [optional] 
**ManuallyInputSetting** | [**ManuallyInputUrlSetting**](ManuallyInputUrlSetting.md) |  | [optional] 
**AutoGenerateUrlSetting** | [**AutoGenerateUrlSetting**](AutoGenerateUrlSetting.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SiteUrlSetting = New-Cloud.Governance.ClientSiteUrlSetting  -Type null `
 -ManuallyInputSetting null `
 -AutoGenerateUrlSetting null
```

- Convert the resource to JSON
```powershell
$SiteUrlSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

