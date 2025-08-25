# HookMessageList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RenewalTaskCompleted** | [**HookMessageListRenewalTaskCompleted**](HookMessageListRenewalTaskCompleted.md) |  | [optional] 
**TaskCreated** | [**HookMessageListTaskCreated**](HookMessageListTaskCreated.md) |  | [optional] 
**AutoImportCompleted** | [**HookMessageListAutoImportCompleted**](HookMessageListAutoImportCompleted.md) |  | [optional] 
**RequestsRelated** | [**HookMessageListRequestsRelated**](HookMessageListRequestsRelated.md) |  | [optional] 
**LifecycleHookMessage** | [**HookMessageListLifecycleHookMessage**](HookMessageListLifecycleHookMessage.md) |  | [optional] 
**ElectionHookMessage** | [**HookMessageListElectionHookMessage**](HookMessageListElectionHookMessage.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HookMessageList = New-Cloud.Governance.ClientHookMessageList  -RenewalTaskCompleted null `
 -TaskCreated null `
 -AutoImportCompleted null `
 -RequestsRelated null `
 -LifecycleHookMessage null `
 -ElectionHookMessage null
```

- Convert the resource to JSON
```powershell
$HookMessageList | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

