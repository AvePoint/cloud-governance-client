# ArchiveWorkspaceParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArchiveProfile** | **String** | WorkspaceType is site, you should set profile name  WorkspaceType is teams, you should set profile id | [optional] 
**ObjectIds** | **String[]** | workspace ids | [optional] 
**WorkspaceType** | [**WorkspaceArchivedType**](WorkspaceArchivedType.md) | workspace type | [optional] 

## Examples

- Prepare the resource
```powershell
$ArchiveWorkspaceParameter = New-Cloud.Governance.ClientArchiveWorkspaceParameter  -ArchiveProfile null `
 -ObjectIds null `
 -WorkspaceType null
```

- Convert the resource to JSON
```powershell
$ArchiveWorkspaceParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

