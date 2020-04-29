# ManuallyInputUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableConstructUrl** | **Boolean** |  | [optional] [default to null]
**EnableUrlValidation** | **Boolean** |  | [optional] [default to null]
**ConstructUrlAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**ValidationRule** | [**TextValidationRuleRef**](TextValidationRuleRef.md) |  | [optional] [default to null]
**Rules** | **String[]** |  | [optional] [default to null]
**Suffix** | **String** |  | [optional] [default to null]
**Connection** | **String** |  | [optional] [default to null]
**ContructUrlAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientManuallyInputUrlSetting  -EnableConstructUrl null `
 -EnableUrlValidation null `
 -ConstructUrlAssignBy null `
 -ValidationRule null `
 -Rules null `
 -Suffix null `
 -Connection null `
 -ContructUrlAssignBy null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

