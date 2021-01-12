# TextValidationRuleRef
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Expression** | **String** |  | [optional] 
**ErrorMessage** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TextValidationRuleRef = New-Cloud.Governance.ClientTextValidationRuleRef  -Id null `
 -Name null `
 -Expression null `
 -ErrorMessage null
```

- Convert the resource to JSON
```powershell
$TextValidationRuleRef | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

