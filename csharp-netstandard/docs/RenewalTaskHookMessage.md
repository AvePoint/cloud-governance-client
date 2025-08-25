# Cloud.Governance.Client.Model.RenewalTaskHookMessage
When a Renewal Task is Completed
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PhaseStartTime** | **DateTime?** | Start time of the renewal process | [optional] 
**RenewalProfileName** | **string** | Name of the renewal profile | [optional] 
**Message** | **string** | Details of the renewal exception | [optional] 
**DueDate** | **DateTime?** | Due date for the task assignee to complete the renewal task | [optional] 
**AssigneeDisplayName** | **string** | Display name of the renewal task assignee | [optional] 
**AssigneeIdentityName** | **string** | User principal name of the renewal task assignee | [optional] 
**TaskLink** | **string** | Link of task | [optional] 
**ObjectTitle** | **string** | Name of the workspace | [optional] 
**ObjectType** | **string** | Type of the workspace | [optional] 
**ObjectTypeEnum** | **HookMessageObjectType** | Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer | [optional] 
**GroupEmail** | **string** | E-mail address of the workspace | [optional] 
**TriggerType** | **TriggerType** | Event type that being triggered, available values and corresponding messages:                            RequestSubmitted,RequestCompleted,RequestCancelled - -- -&gt; RequestHookMessage              TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped - -- -&gt; TaskHookMessage              RenewalSuccess RenewalException,RenewalOverdue - -- -&gt; RenewalTaskHookMessage              FullyAutoImportSuccess,ConfirmDetailSuccess - -- -&gt; AutoImportProcessHookMessage              ElectionCompleted,ElectionOverdue - --&gt; ElectionHookMessage              LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated - -- -&gt; ElectionOverdue | [optional] 
**TriggerTime** | **DateTime** | Time that the webhook is triggered | [optional] 
**ObjectUrl** | **string** | URL of the workspace | [optional] 
**ObjectId** | **Guid?** | The unique ID of the workspace | [optional] 
**Summary** | **string** | Request or task summary | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

