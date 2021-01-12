# ExecutionParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** |  | [optional] 
**Type** | **String** |  | [optional] 
**Value** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ExecutionParameter = New-Cloud.Governance.ClientExecutionParameter  -Name null `
 -Type null `
 -Value null
```

- Convert the resource to JSON
```powershell
$ExecutionParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

