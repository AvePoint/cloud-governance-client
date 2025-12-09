# CustomActionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeforeApprovalProcessExecution** | [**ExecutionModel**](ExecutionModel.md) |  | [optional] 
**AfterApprovalProcessExecution** | [**ExecutionModel**](ExecutionModel.md) |  | [optional] 
**PostExecution** | [**ExecutionModel**](ExecutionModel.md) |  | [optional] 
**BeforeSubmission** | [**ExecutionModel**](ExecutionModel.md) |  | [optional] 
**WhenErrorTaskGenerated** | [**ExecutionModel**](ExecutionModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CustomActionSettings = New-Cloud.Governance.ClientCustomActionSettings  -BeforeApprovalProcessExecution null `
 -AfterApprovalProcessExecution null `
 -PostExecution null `
 -BeforeSubmission null `
 -WhenErrorTaskGenerated null
```

- Convert the resource to JSON
```powershell
$CustomActionSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

