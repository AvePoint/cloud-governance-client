# DeleteWorkspaceParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableRemoveObject** | **Boolean** |  | [optional] [default to $false]
**IsSendCancelEmail** | **Boolean** |  | [optional] [default to $false]
**CancelEmailTemplateId** | **String** |  | [optional] 
**Workspace** | [**WorkspaceIdTypeModel[]**](WorkspaceIdTypeModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$DeleteWorkspaceParameter = New-Cloud.Governance.ClientDeleteWorkspaceParameter  -EnableRemoveObject null `
 -IsSendCancelEmail null `
 -CancelEmailTemplateId null `
 -Workspace null
```

- Convert the resource to JSON
```powershell
$DeleteWorkspaceParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

