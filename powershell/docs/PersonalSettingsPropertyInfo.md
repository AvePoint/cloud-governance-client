# PersonalSettingsPropertyInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelectedLanguages** | **Int32[]** |  | [optional] 
**IsUsingBrowserLanguage** | **Boolean** |  | [optional] [default to $false]
**ThemeCode** | **String** |  | [optional] 
**ThemeType** | [**ThemeSettingType**](ThemeSettingType.md) |  | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$PersonalSettingsPropertyInfo = New-Cloud.Governance.ClientPersonalSettingsPropertyInfo  -SelectedLanguages null `
 -IsUsingBrowserLanguage null `
 -ThemeCode null `
 -ThemeType null
```

- Convert the resource to JSON
```powershell
$PersonalSettingsPropertyInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

