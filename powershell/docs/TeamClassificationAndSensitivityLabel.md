# TeamClassificationAndSensitivityLabel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SensitivityLabel** | [**ChangeTeamClassificationAndSensitivityLabelSensitivityLabel**](ChangeTeamClassificationAndSensitivityLabelSensitivityLabel.md) |  | [optional] 
**OriginalSensitivityLabel** | [**ChangeTeamClassificationAndSensitivityLabelSensitivityLabel**](ChangeTeamClassificationAndSensitivityLabelSensitivityLabel.md) |  | [optional] 
**Classification** | [**ChangeTeamClassificationAndSensitivityLabelClassification**](ChangeTeamClassificationAndSensitivityLabelClassification.md) |  | [optional] 
**OriginalClassification** | [**ChangeTeamClassificationAndSensitivityLabelClassification**](ChangeTeamClassificationAndSensitivityLabelClassification.md) |  | [optional] 
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

