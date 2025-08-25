# UpdateMetadataParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**Workspace** | [**WorkspaceIdTypeModel[]**](WorkspaceIdTypeModel.md) |  | [optional] 
**IsSelectAllWorkspace** | **Boolean** |  | [optional] [default to $false]
**Type** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**IsConfirmed** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$UpdateMetadataParameter = New-Cloud.Governance.ClientUpdateMetadataParameter  -Metadatas null `
 -Workspace null `
 -IsSelectAllWorkspace null `
 -Type null `
 -IsConfirmed null
```

- Convert the resource to JSON
```powershell
$UpdateMetadataParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

