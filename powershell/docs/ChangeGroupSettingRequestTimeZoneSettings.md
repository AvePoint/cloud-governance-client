# ChangeGroupSettingRequestTimeZoneSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** | Enabled | [optional] [default to $false]
**TimeZone** | **Int32** | time zone | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$ChangeGroupSettingRequestTimeZoneSettings = New-Cloud.Governance.ClientChangeGroupSettingRequestTimeZoneSettings  -Enabled null `
 -TimeZone null
```

- Convert the resource to JSON
```powershell
$ChangeGroupSettingRequestTimeZoneSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

