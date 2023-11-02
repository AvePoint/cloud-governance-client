# ContainerScopeSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Container** | [**ContainerInfo**](ContainerInfo.md) |  | [optional] 
**Type** | [**ContainerScopeType**](ContainerScopeType.md) |  | [optional] 
**Nodes** | [**RemoteNodeInfo[]**](RemoteNodeInfo.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ContainerScopeSetting = New-Cloud.Governance.ClientContainerScopeSetting  -Container null `
 -Type null `
 -Nodes null
```

- Convert the resource to JSON
```powershell
$ContainerScopeSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

