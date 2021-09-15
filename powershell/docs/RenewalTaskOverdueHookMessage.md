# RenewalTaskOverdueHookMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DueDate** | **System.DateTime** | Due date for the task assignee to complete the renewal task | [optional] 
**AssigneeDisplayName** | **String** | Display name of the renewal task assignee | [optional] 
**AssigneeIdentityName** | **String** | User principal name of the renewal task assignee | [optional] 
**PhaseStartTime** | **System.DateTime** | Start time of the renewal process | [optional] 
**RenewalProfileName** | **String** | Name of the renewal profile | [optional] 
**TaskLink** | **String** | Link of task  &lt;sample&gt;abc&lt;/sample&gt; | [optional] 
**ObjectTitle** | **String** | Name of the workspace | [optional] 
**ObjectType** | **String** | Type of the workspace | [optional] 
**ObjectTypeEnum** | **String** | Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer | [optional] 
**GroupEmail** | **String** | E-mail address of the workspace | [optional] 
**TriggerType** | **String** | Event type that being triggered, available values:RequestSubmitted,RequestCompleted,RequestCancelled,TaskCreated,TaskApproved,  TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped,RenewalSuccess,RenewalException,RenewalOverdue,FullyAutoImportSuccess,  ConfirmDetailSuccess,ElectionCompleted,LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated,ElectionOverdue | [optional] 
**TriggerTime** | **System.DateTime** | Time that the webhook is triggered | [optional] 
**ObjectUrl** | **String** | URL of the workspace | [optional] 
**ObjectId** | **String** | The unique ID of the workspace | [optional] 
**Summary** | **String** | Request or task summary | [optional] 

## Examples

- Prepare the resource
```powershell
$RenewalTaskOverdueHookMessage = New-Cloud.Governance.ClientRenewalTaskOverdueHookMessage  -DueDate null `
 -AssigneeDisplayName null `
 -AssigneeIdentityName null `
 -PhaseStartTime null `
 -RenewalProfileName null `
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
$RenewalTaskOverdueHookMessage | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

