# ListValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ListUrl** | **String** |  | [optional] 
**ParentUrl** | **String** |  | [optional] 
**ListTitle** | **String** |  | [optional] 
**IsDocumentLibrary** | **Boolean** |  | [optional] 
**IsEditTask** | **Boolean** |  | [optional] 
**IsFromQuestionnaire** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ListValidationParameter = New-Cloud.Governance.ClientListValidationParameter  -ListUrl null `
 -ParentUrl null `
 -ListTitle null `
 -IsDocumentLibrary null `
 -IsEditTask null `
 -IsFromQuestionnaire null
```

- Convert the resource to JSON
```powershell
$ListValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

