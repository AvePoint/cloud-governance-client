# ChangeTeamPrivacySetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OriginalEnabled** | **Boolean** |  | [optional] [default to $false]
**Enabled** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeTeamPrivacySetting = New-Cloud.Governance.ClientChangeTeamPrivacySetting  -OriginalEnabled null `
 -Enabled null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeTeamPrivacySetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

