# ManuallyInputUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableConstructUrl** | **Boolean** |  | [optional] [default to $false]
**EnableUrlValidation** | **Boolean** |  | [optional] [default to $false]
**ConstructUrlAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**ValidationRule** | [**TextValidationRuleRef**](TextValidationRuleRef.md) |  | [optional] 
**Rules** | **String[]** |  | [optional] 
**Suffix** | **String** |  | [optional] 
**Connection** | **String** |  | [optional] 
**ContructUrlAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManuallyInputUrlSetting = New-Cloud.Governance.ClientManuallyInputUrlSetting  -EnableConstructUrl null `
 -EnableUrlValidation null `
 -ConstructUrlAssignBy null `
 -ValidationRule null `
 -Rules null `
 -Suffix null `
 -Connection null `
 -ContructUrlAssignBy null
```

- Convert the resource to JSON
```powershell
$ManuallyInputUrlSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

