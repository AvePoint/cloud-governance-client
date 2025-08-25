# AutoCompleteRenewalTaskParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsMarkAsCanceled** | **Boolean** |  | [optional] [default to $false]
**Processor** | **String** |  | [optional] 
**IsSendCancelEmail** | **Boolean** |  | [optional] [default to $false]
**CancelEmailTemplateId** | **String** |  | [optional] 
**Workspace** | [**WorkspaceIdTypeModel[]**](WorkspaceIdTypeModel.md) |  | [optional] 
**IsSelectAllWorkspace** | **Boolean** |  | [optional] [default to $false]
**Type** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**IsConfirmed** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$AutoCompleteRenewalTaskParameter = New-Cloud.Governance.ClientAutoCompleteRenewalTaskParameter  -IsMarkAsCanceled null `
 -Processor null `
 -IsSendCancelEmail null `
 -CancelEmailTemplateId null `
 -Workspace null `
 -IsSelectAllWorkspace null `
 -Type null `
 -IsConfirmed null
```

- Convert the resource to JSON
```powershell
$AutoCompleteRenewalTaskParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

