# PersonalSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**UserID** | **Int32** |  | [optional] 
**LanguageID** | **Int32** |  | [optional] 
**TimeZoneID** | **Int32** |  | [optional] 
**IsAdjustDaylight** | **Boolean** |  | [optional] 
**Properties** | [**PersonalSettingsPropertyInfo**](PersonalSettingsPropertyInfo.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$PersonalSettings = New-Cloud.Governance.ClientPersonalSettings  -Id null `
 -UserID null `
 -LanguageID null `
 -TimeZoneID null `
 -IsAdjustDaylight null `
 -Properties null
```

- Convert the resource to JSON
```powershell
$PersonalSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

