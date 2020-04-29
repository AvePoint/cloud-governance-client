# CustomActionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeforeApprovalProcessExecution** | [**ExecutionModel**](ExecutionModel.md) |  | [optional] [default to null]
**AfterApprovalProcessExecution** | [**ExecutionModel**](ExecutionModel.md) |  | [optional] [default to null]
**PostExecution** | [**ExecutionModel**](ExecutionModel.md) |  | [optional] [default to null]
**BeforeSubmission** | [**ExecutionModel**](ExecutionModel.md) |  | [optional] [default to null]
**WhenErrorTaskGenerated** | [**ExecutionModel**](ExecutionModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientCustomActionSettings  -BeforeApprovalProcessExecution null `
 -AfterApprovalProcessExecution null `
 -PostExecution null `
 -BeforeSubmission null `
 -WhenErrorTaskGenerated null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

