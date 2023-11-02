# Int64ChangedValueRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NewValue** | **Int64** |  | [optional] [default to 0]
**OriginalValue** | **Int64** |  | [optional] [default to 0]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$Int64ChangedValueRequestModel = New-Cloud.Governance.ClientInt64ChangedValueRequestModel  -NewValue null `
 -OriginalValue null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$Int64ChangedValueRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

