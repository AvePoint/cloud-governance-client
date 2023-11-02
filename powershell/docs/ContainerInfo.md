# ContainerInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**RemoteNodeType** | [**RemoteNodeType**](RemoteNodeType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ContainerInfo = New-Cloud.Governance.ClientContainerInfo  -Id null `
 -Name null `
 -RemoteNodeType null
```

- Convert the resource to JSON
```powershell
$ContainerInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

