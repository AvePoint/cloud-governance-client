# TeamSensitivityLabelChangedValueRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NewValue** | [**ChangeTeamClassificationAndSensitivityLabelSensitivityLabel**](ChangeTeamClassificationAndSensitivityLabelSensitivityLabel.md) |  | [optional] 
**OriginalValue** | [**ChangeTeamClassificationAndSensitivityLabelSensitivityLabel**](ChangeTeamClassificationAndSensitivityLabelSensitivityLabel.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$TeamSensitivityLabelChangedValueRequestModel = New-Cloud.Governance.ClientTeamSensitivityLabelChangedValueRequestModel  -NewValue null `
 -OriginalValue null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$TeamSensitivityLabelChangedValueRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

