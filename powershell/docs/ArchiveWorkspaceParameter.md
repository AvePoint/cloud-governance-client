# ArchiveWorkspaceParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArchiveProfile** | **String** |  | [optional] 
**ObjectIds** | **String[]** |  | [optional] 
**WorkspaceType** | [**WorkspaceArchivedType**](WorkspaceArchivedType.md) |  | [optional] 

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

