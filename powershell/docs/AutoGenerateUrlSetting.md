# AutoGenerateUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GenerateUrlType** | [**AutoGenerateUrlType**](AutoGenerateUrlType.md) |  | [optional] 
**SequentialNumberingSettings** | [**UrlSequentialNumberingSettings**](UrlSequentialNumberingSettings.md) |  | [optional] 
**RandomStringSettings** | [**UrlRandomStringSettings**](UrlRandomStringSettings.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AutoGenerateUrlSetting = New-Cloud.Governance.ClientAutoGenerateUrlSetting  -GenerateUrlType null `
 -SequentialNumberingSettings null `
 -RandomStringSettings null
```

- Convert the resource to JSON
```powershell
$AutoGenerateUrlSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

