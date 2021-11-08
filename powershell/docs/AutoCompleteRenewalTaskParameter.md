# AutoCompleteRenewalTaskParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsMarkAsCanceled** | **Boolean** |  | [optional] [default to $false]
**IsSendCancelEmail** | **Boolean** |  | [optional] [default to $false]
**CancelEmailTemplateId** | **String** |  | [optional] 
**Workspace** | [**WorkspaceIdTypeModel[]**](WorkspaceIdTypeModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AutoCompleteRenewalTaskParameter = New-Cloud.Governance.ClientAutoCompleteRenewalTaskParameter  -IsMarkAsCanceled null `
 -IsSendCancelEmail null `
 -CancelEmailTemplateId null `
 -Workspace null
```

- Convert the resource to JSON
```powershell
$AutoCompleteRenewalTaskParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

