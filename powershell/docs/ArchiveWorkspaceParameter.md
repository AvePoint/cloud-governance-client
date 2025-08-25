# ArchiveWorkspaceParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArchiveProfile** | **String** | WorkspaceType is site, you should set profile name              WorkspaceType is teams, you should set profile id | [optional] 
**WorkspaceType** | [**WorkspaceArchivedType**](WorkspaceArchivedType.md) | workspace type | [optional] 
**IsSendCancelEmail** | **Boolean** |  | [optional] [default to $false]
**CancelEmailTemplateId** | **String** |  | [optional] 
**Workspace** | [**WorkspaceIdTypeModel[]**](WorkspaceIdTypeModel.md) |  | [optional] 
**IsSelectAllWorkspace** | **Boolean** |  | [optional] [default to $false]
**Type** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**IsConfirmed** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$ArchiveWorkspaceParameter = New-Cloud.Governance.ClientArchiveWorkspaceParameter  -ArchiveProfile null `
 -WorkspaceType null `
 -IsSendCancelEmail null `
 -CancelEmailTemplateId null `
 -Workspace null `
 -IsSelectAllWorkspace null `
 -Type null `
 -IsConfirmed null
```

- Convert the resource to JSON
```powershell
$ArchiveWorkspaceParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

