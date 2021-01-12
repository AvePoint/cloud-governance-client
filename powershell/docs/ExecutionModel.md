# ExecutionModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] 
**WebServiceAddress** | **String** |  | [optional] 
**WebServiceAuthenticationType** | [**WebServiceAuthenticationType**](WebServiceAuthenticationType.md) |  | [optional] 
**WebServiceAppClientId** | **String** |  | [optional] 
**MethodName** | **String** |  | [optional] 
**Arguments** | [**ExecutionParameter[]**](ExecutionParameter.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ExecutionModel = New-Cloud.Governance.ClientExecutionModel  -Enabled null `
 -WebServiceAddress null `
 -WebServiceAuthenticationType null `
 -WebServiceAppClientId null `
 -MethodName null `
 -Arguments null
```

- Convert the resource to JSON
```powershell
$ExecutionModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

