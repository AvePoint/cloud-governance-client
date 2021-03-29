# ListTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**SPListTemplateType**](SPListTemplateType.md) |  | [optional] 
**BaseType** | [**SPBaseType**](SPBaseType.md) |  | [optional] 
**Name** | **String** |  | [optional] 
**IsCustomTemplate** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$ListTemplate = New-Cloud.Governance.ClientListTemplate  -Title null `
 -Description null `
 -Type null `
 -BaseType null `
 -Name null `
 -IsCustomTemplate null
```

- Convert the resource to JSON
```powershell
$ListTemplate | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

