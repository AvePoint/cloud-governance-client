# M365UserLifecycleValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **String** |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$M365UserLifecycleValidationParameter = New-Cloud.Governance.ClientM365UserLifecycleValidationParameter  -UserId null `
 -OfficeTenantId null `
 -Email null
```

- Convert the resource to JSON
```powershell
$M365UserLifecycleValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

