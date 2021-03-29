# WorkspaceIdTypeModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** | workspace id | [optional] 
**WorkspaceType** | [**WorkspaceType**](WorkspaceType.md) | workspace type | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkspaceIdTypeModel = New-Cloud.Governance.ClientWorkspaceIdTypeModel  -ObjectId null `
 -WorkspaceType null
```

- Convert the resource to JSON
```powershell
$WorkspaceIdTypeModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

