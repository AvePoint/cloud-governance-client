# CreateWebScopeSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RestrictParentUrl** | **String** |  | [optional] 
**ScopeType** | [**ScopeType**](ScopeType.md) |  | [optional] 
**UseTitleInUrl** | **Boolean** |  | [optional] [default to $false]
**EnableUrlValidation** | **Boolean** |  | [optional] [default to $false]
**TextValidationRule** | [**TextValidationRuleRef**](TextValidationRuleRef.md) |  | [optional] 
**SelectedNodes** | [**SPNode[]**](SPNode.md) |  | [optional] 
**AutoPopulateUrlWithSPContext** | **Boolean** |  | [optional] [default to $false]
**AutoPopulateUrlWithSPContextAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateWebScopeSettings = New-Cloud.Governance.ClientCreateWebScopeSettings  -RestrictParentUrl null `
 -ScopeType null `
 -UseTitleInUrl null `
 -EnableUrlValidation null `
 -TextValidationRule null `
 -SelectedNodes null `
 -AutoPopulateUrlWithSPContext null `
 -AutoPopulateUrlWithSPContextAssignBy null
```

- Convert the resource to JSON
```powershell
$CreateWebScopeSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

