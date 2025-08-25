# StringModelChangedValueRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NewValue** | [**ChangeGroupSettingCheckResultSensitivity**](ChangeGroupSettingCheckResultSensitivity.md) |  | [optional] 
**OriginalValue** | [**ChangeGroupSettingCheckResultSensitivity**](ChangeGroupSettingCheckResultSensitivity.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$StringModelChangedValueRequestModel = New-Cloud.Governance.ClientStringModelChangedValueRequestModel  -NewValue null `
 -OriginalValue null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$StringModelChangedValueRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

