# CreateWebScopeSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RestrictParentUrl** | **String** |  | [optional] [default to null]
**ScopeType** | [**ScopeType**](ScopeType.md) |  | [optional] [default to null]
**UseTitleInUrl** | **Boolean** |  | [optional] [default to null]
**EnableUrlValidation** | **Boolean** |  | [optional] [default to null]
**TextValidationRule** | [**TextValidationRuleRef**](TextValidationRuleRef.md) |  | [optional] [default to null]
**SelectedNodes** | [**SPNode[]**](SPNode.md) |  | [optional] [default to null]
**AutoPopulateUrlWithSPContext** | **Boolean** |  | [optional] [default to null]
**AutoPopulateUrlWithSPContextAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientCreateWebScopeSettings  -RestrictParentUrl null `
 -ScopeType null `
 -UseTitleInUrl null `
 -EnableUrlValidation null `
 -TextValidationRule null `
 -SelectedNodes null `
 -AutoPopulateUrlWithSPContext null `
 -AutoPopulateUrlWithSPContextAssignBy null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

