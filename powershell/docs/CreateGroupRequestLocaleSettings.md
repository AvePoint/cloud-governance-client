# CreateGroupRequestLocaleSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** | Enabled | [optional] [default to $false]
**Locale** | **Int32** | locale | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$CreateGroupRequestLocaleSettings = New-Cloud.Governance.ClientCreateGroupRequestLocaleSettings  -Enabled null `
 -Locale null
```

- Convert the resource to JSON
```powershell
$CreateGroupRequestLocaleSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

