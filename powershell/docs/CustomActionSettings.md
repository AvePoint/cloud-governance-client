# CustomActionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeforeApprovalProcessExecution** | [**CustomActionSettingsBeforeApprovalProcessExecution**](CustomActionSettingsBeforeApprovalProcessExecution.md) |  | [optional] 
**AfterApprovalProcessExecution** | [**CustomActionSettingsBeforeApprovalProcessExecution**](CustomActionSettingsBeforeApprovalProcessExecution.md) |  | [optional] 
**PostExecution** | [**CustomActionSettingsBeforeApprovalProcessExecution**](CustomActionSettingsBeforeApprovalProcessExecution.md) |  | [optional] 
**BeforeSubmission** | [**CustomActionSettingsBeforeApprovalProcessExecution**](CustomActionSettingsBeforeApprovalProcessExecution.md) |  | [optional] 
**WhenErrorTaskGenerated** | [**CustomActionSettingsBeforeApprovalProcessExecution**](CustomActionSettingsBeforeApprovalProcessExecution.md) |  | [optional] 

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

