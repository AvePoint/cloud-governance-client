# GroupValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **String** |  | [optional] 
**IsEditTask** | **Boolean** |  | [optional] [default to $false]
**IsFromQuestionnaire** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$GroupValidationParameter = New-Cloud.Governance.ClientGroupValidationParameter  -GroupId null `
 -IsEditTask null `
 -IsFromQuestionnaire null
```

- Convert the resource to JSON
```powershell
$GroupValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

