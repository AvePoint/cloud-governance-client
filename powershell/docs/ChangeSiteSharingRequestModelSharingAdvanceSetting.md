# ChangeSiteSharingRequestModelSharingAdvanceSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NewValue** | [**SharingAdvanceSettingModelChangedValueRequestModelNewValue**](SharingAdvanceSettingModelChangedValueRequestModelNewValue.md) |  | [optional] 
**OriginalValue** | [**SharingAdvanceSettingModelChangedValueRequestModelNewValue**](SharingAdvanceSettingModelChangedValueRequestModelNewValue.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteSharingRequestModelSharingAdvanceSetting = New-Cloud.Governance.ClientChangeSiteSharingRequestModelSharingAdvanceSetting  -NewValue null `
 -OriginalValue null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeSiteSharingRequestModelSharingAdvanceSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

