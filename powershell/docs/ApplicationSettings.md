# ApplicationSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocaleId** | **Int32** |  | [optional] [default to null]
**Locale** | **String** |  | [optional] [default to null]
**TimezoneId** | **Int32** |  | [optional] [default to null]
**Terminologies** | [**Terminology[]**](Terminology.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientApplicationSettings  -LocaleId null `
 -Locale null `
 -TimezoneId null `
 -Terminologies null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

