# AutoGenerateUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GenerateUrlType** | [**AutoGenerateUrlType**](AutoGenerateUrlType.md) |  | [optional] [default to null]
**SequentialNumberingSettings** | [**UrlSequentialNumberingSettings**](UrlSequentialNumberingSettings.md) |  | [optional] [default to null]
**RandomStringSettings** | [**UrlRandomStringSettings**](UrlRandomStringSettings.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientAutoGenerateUrlSetting  -GenerateUrlType null `
 -SequentialNumberingSettings null `
 -RandomStringSettings null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

