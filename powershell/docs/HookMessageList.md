# HookMessageList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RenewalTaskCompleted** | [**RenewalTaskHookMessage**](RenewalTaskHookMessage.md) | When a Renewal Task is Completed | [optional] 
**TaskCreated** | [**TaskHookMessage**](TaskHookMessage.md) |  | [optional] 
**AutoImportCompleted** | [**AutoImportProcessHookMessage**](AutoImportProcessHookMessage.md) | When an import process with pre-defined governance details or end user completes a confirm governance details task is completed | [optional] 
**RequestsRelated** | [**RequestHookMessage**](RequestHookMessage.md) |  | [optional] 
**LifecycleHookMessage** | [**LifecycleHookMessage**](LifecycleHookMessage.md) |  | [optional] 
**ElectionHookMessage** | [**ElectionHookMessage**](ElectionHookMessage.md) |  | [optional] 

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

