# CreateResourceMailboxDepartmentRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateResourceMailboxDepartmentRequestModel = New-Cloud.Governance.ClientCreateResourceMailboxDepartmentRequestModel  -Value null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateResourceMailboxDepartmentRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

