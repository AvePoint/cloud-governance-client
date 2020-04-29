# ExecutionModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [default to null]
**WebServiceAddress** | **String** |  | [optional] [default to null]
**WebServiceAuthenticationType** | [**WebServiceAuthenticationType**](WebServiceAuthenticationType.md) |  | [optional] [default to null]
**WebServiceAppClientId** | **String** |  | [optional] [default to null]
**MethodName** | **String** |  | [optional] [default to null]
**Arguments** | [**ExecutionParameter[]**](ExecutionParameter.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientExecutionModel  -Enabled null `
 -WebServiceAddress null `
 -WebServiceAuthenticationType null `
 -WebServiceAppClientId null `
 -MethodName null `
 -Arguments null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

