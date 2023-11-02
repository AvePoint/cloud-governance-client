# TeamClassificationAndSensitivityLabel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SensitivityLabel** | [**TeamSensitivityLabel**](TeamSensitivityLabel.md) |  | [optional] 
**OriginalSensitivityLabel** | [**TeamSensitivityLabel**](TeamSensitivityLabel.md) |  | [optional] 
**Classification** | [**TeamClassification**](TeamClassification.md) |  | [optional] 
**OriginalClassification** | [**TeamClassification**](TeamClassification.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$TeamClassificationAndSensitivityLabel = New-Cloud.Governance.ClientTeamClassificationAndSensitivityLabel  -SensitivityLabel null `
 -OriginalSensitivityLabel null `
 -Classification null `
 -OriginalClassification null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$TeamClassificationAndSensitivityLabel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

