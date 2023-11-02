# RemoteNodeInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Url** | **String** |  | [optional] 
**ParentId** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RemoteNodeInfo = New-Cloud.Governance.ClientRemoteNodeInfo  -Id null `
 -Url null `
 -ParentId null `
 -Name null `
 -TenantId null
```

- Convert the resource to JSON
```powershell
$RemoteNodeInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

