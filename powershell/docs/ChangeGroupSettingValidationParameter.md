# ChangeGroupSettingValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupEmail** | **String** |  | [optional] 
**GroupId** | **String** |  | [optional] 
**IsEditTask** | **Boolean** |  | [optional] [default to $false]
**IsFromQuestionnaire** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$ChangeGroupSettingValidationParameter = New-Cloud.Governance.ClientChangeGroupSettingValidationParameter  -GroupEmail null `
 -GroupId null `
 -IsEditTask null `
 -IsFromQuestionnaire null
```

- Convert the resource to JSON
```powershell
$ChangeGroupSettingValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

