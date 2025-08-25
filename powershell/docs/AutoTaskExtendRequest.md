# AutoTaskExtendRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | [**LifecycleAction**](LifecycleAction.md) |  | [optional] 
**ExtendDuration** | **Int32** |  | [optional] [default to 0]
**ExtendDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**TaskId** | **String** |  | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**Comments** | [**AutoTaskExtendRequestComments**](AutoTaskExtendRequestComments.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AutoTaskExtendRequest = New-Cloud.Governance.ClientAutoTaskExtendRequest  -Action null `
 -ExtendDuration null `
 -ExtendDurationType null `
 -TaskId null `
 -Metadatas null `
 -Comments null
```

- Convert the resource to JSON
```powershell
$AutoTaskExtendRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

