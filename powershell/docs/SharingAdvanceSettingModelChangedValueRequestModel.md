# SharingAdvanceSettingModelChangedValueRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NewValue** | [**SharingAdvanceSettingModel**](SharingAdvanceSettingModel.md) |  | [optional] 
**OriginalValue** | [**SharingAdvanceSettingModel**](SharingAdvanceSettingModel.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$SharingAdvanceSettingModelChangedValueRequestModel = New-Cloud.Governance.ClientSharingAdvanceSettingModelChangedValueRequestModel  -NewValue null `
 -OriginalValue null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$SharingAdvanceSettingModelChangedValueRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

