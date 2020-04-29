# PersonalSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**UserID** | **Int32** |  | [optional] [default to null]
**LanguageID** | **Int32** |  | [optional] [default to null]
**TimeZoneID** | **Int32** |  | [optional] [default to null]
**Properties** | [**PersonalSettingsPropertyInfo**](PersonalSettingsPropertyInfo.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientPersonalSettings  -Id null `
 -UserID null `
 -LanguageID null `
 -TimeZoneID null `
 -Properties null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

