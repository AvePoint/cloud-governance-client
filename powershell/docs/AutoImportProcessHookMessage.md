# AutoImportProcessHookMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoImportProfileName** | **String** | Name of the import job | [optional] 
**TaskLink** | **String** | Link of task  &lt;sample&gt;abc&lt;/sample&gt; | [optional] 
**ObjectTitle** | **String** | Name of the workspace | [optional] 
**ObjectType** | **String** | Type of the workspace | [optional] 
**ObjectTypeEnum** | [**HookMessageObjectType**](HookMessageObjectType.md) | Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer | [optional] 
**GroupEmail** | **String** | E-mail address of the workspace | [optional] 
**TriggerType** | [**TriggerType**](TriggerType.md) | Event type that being triggered, available values and corresponding messages:    RequestSubmitted,RequestCompleted,RequestCancelled ----&gt; RequestHookMessage  TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped ----&gt; TaskHookMessage  RenewalSuccess RenewalException,RenewalOverdue ----&gt; RenewalTaskHookMessage  FullyAutoImportSuccess,ConfirmDetailSuccess ----&gt; AutoImportProcessHookMessage  ElectionCompleted,ElectionOverdue ---&gt; ElectionHookMessage  LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated ----&gt; ElectionOverdue | [optional] 
**TriggerTime** | **System.DateTime** | Time that the webhook is triggered | [optional] 
**ObjectUrl** | **String** | URL of the workspace | [optional] 
**ObjectId** | **String** | The unique ID of the workspace | [optional] 
**Summary** | **String** | Request or task summary | [optional] 

## Examples

- Prepare the resource
```powershell
$AutoImportProcessHookMessage = New-Cloud.Governance.ClientAutoImportProcessHookMessage  -AutoImportProfileName null `
 -TaskLink null `
 -ObjectTitle null `
 -ObjectType null `
 -ObjectTypeEnum null `
 -GroupEmail null `
 -TriggerType null `
 -TriggerTime null `
 -ObjectUrl null `
 -ObjectId null `
 -Summary null
```

- Convert the resource to JSON
```powershell
$AutoImportProcessHookMessage | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

