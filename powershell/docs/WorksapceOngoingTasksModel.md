# WorksapceOngoingTasksModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskName** | **String** |  | [optional] 
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceTypeDescription** | **String** |  | [optional] 
**InstanceId** | **String** |  | [optional] 
**WorkspaceId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorksapceOngoingTasksModel = New-Cloud.Governance.ClientWorksapceOngoingTasksModel  -TaskName null `
 -ServiceType null `
 -ServiceTypeDescription null `
 -InstanceId null `
 -WorkspaceId null
```

- Convert the resource to JSON
```powershell
$WorksapceOngoingTasksModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

