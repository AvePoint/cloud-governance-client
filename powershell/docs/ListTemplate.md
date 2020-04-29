# ListTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Type** | [**SPListTemplateType**](SPListTemplateType.md) |  | [optional] [default to null]
**BaseType** | [**SPBaseType**](SPBaseType.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**IsCustomTemplate** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientListTemplate  -Title null `
 -Description null `
 -Type null `
 -BaseType null `
 -Name null `
 -IsCustomTemplate null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

