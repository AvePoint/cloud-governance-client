# TaskCreatedHookMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssigneeDisplayName** | **String** | Display name of the task assignee | [optional] 
**AssigneeIdentityName** | **String** | User principal name of the task assignee | [optional] 
**TaskId** | **String** | Unique ID of the task | [optional] 
**TaskLink** | **String** | Link of the task | [optional] 
**RequestId** | **Int32** | Ticket number of the request | [optional] [default to 0]
**RequestGuid** | **String** | Unique ID of the request | [optional] 
**RequesterIdentityName** | **String** | User principal name of the requester | [optional] 
**Requester** | **String** | Display name of the requester | [optional] 
**ServiceType** | **String** | Type of service that is used to submit this request | [optional] 
**ServiceTypeEnum** | [**ServiceType**](ServiceType.md) | Type enum of service that is used to submit this request | [optional] 
**TriggerType** | **String** | Event type that being triggered, available values:RequestSubmitted,RequestCompleted,RequestCancelled,TaskCreated,TaskApproved,  TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped,RenewalSuccess,RenewalException,RenewalOverdue,FullyAutoImportSuccess,  ConfirmDetailSuccess,ElectionCompleted,LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated,ElectionOverdue | [optional] 
**TriggerTime** | **System.DateTime** | Time that the webhook is triggered | [optional] 
**ObjectUrl** | **String** | URL of the workspace | [optional] 
**ObjectId** | **String** | The unique ID of the workspace | [optional] 
**Summary** | **String** | Request or task summary | [optional] 

## Examples

- Prepare the resource
```powershell
$TaskCreatedHookMessage = New-Cloud.Governance.ClientTaskCreatedHookMessage  -AssigneeDisplayName null `
 -AssigneeIdentityName null `
 -TaskId null `
 -TaskLink null `
 -RequestId null `
 -RequestGuid null `
 -RequesterIdentityName null `
 -Requester null `
 -ServiceType null `
 -ServiceTypeEnum null `
 -TriggerType null `
 -TriggerTime null `
 -ObjectUrl null `
 -ObjectId null `
 -Summary null
```

- Convert the resource to JSON
```powershell
$TaskCreatedHookMessage | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

