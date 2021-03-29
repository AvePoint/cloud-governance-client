# PersonalSettingsPropertyInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Theme** | [**ThemeType**](ThemeType.md) |  | [optional] 
**SelectedLanguages** | **Int32[]** |  | [optional] 
**IsUsingBrowserLanguage** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$PersonalSettingsPropertyInfo = New-Cloud.Governance.ClientPersonalSettingsPropertyInfo  -Theme null `
 -SelectedLanguages null `
 -IsUsingBrowserLanguage null
```

- Convert the resource to JSON
```powershell
$PersonalSettingsPropertyInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

