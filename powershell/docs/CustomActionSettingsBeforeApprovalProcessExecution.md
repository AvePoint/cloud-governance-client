# CustomActionSettingsBeforeApprovalProcessExecution
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [default to $false]
**WebServiceAddress** | **String** |  | [optional] 
**WebServiceAuthenticationType** | [**WebServiceAuthenticationType**](WebServiceAuthenticationType.md) |  | [optional] 
**WebServiceAppClientId** | **String** |  | [optional] 
**MethodName** | **String** |  | [optional] 
**Arguments** | [**ExecutionParameter[]**](ExecutionParameter.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CustomActionSettingsBeforeApprovalProcessExecution = New-Cloud.Governance.ClientCustomActionSettingsBeforeApprovalProcessExecution  -Enabled null `
 -WebServiceAddress null `
 -WebServiceAuthenticationType null `
 -WebServiceAppClientId null `
 -MethodName null `
 -Arguments null
```

- Convert the resource to JSON
```powershell
$CustomActionSettingsBeforeApprovalProcessExecution | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

