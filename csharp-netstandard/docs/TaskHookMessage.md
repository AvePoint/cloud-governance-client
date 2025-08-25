# Cloud.Governance.Client.Model.TaskHookMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskId** | **Guid?** | Unique ID of the task | [optional] 
**TaskLink** | **string** | Link of the task | [optional] 
**AssigneeDisplayName** | **string** | Display name of the task assignee | [optional] 
**AssigneeIdentityName** | **string** | User principal name of the task assignee | [optional] 
**ApproverDisplayName** | **string** | Display name of the task assignee | [optional] 
**ApproverIdentityName** | **string** | User principal name of the task assignee | [optional] 
**Message** | **string** | Task comments or error message | [optional] 
**RequestId** | **int** | Ticket number of the request | [optional] [default to 0]
**RequestGuid** | **Guid?** | Unique ID of the request | [optional] 
**RequesterIdentityName** | **string** | User principal name of the requester | [optional] 
**Requester** | **string** | Display name of the requester | [optional] 
**ServiceType** | **string** | Type of service that is used to submit this request | [optional] 
**ServiceTypeEnum** | **ServiceType** | Type enum of service that is used to submit this request | [optional] 
**TriggerType** | **TriggerType** | Event type that being triggered, available values and corresponding messages:                            RequestSubmitted,RequestCompleted,RequestCancelled - -- -&gt; RequestHookMessage              TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped - -- -&gt; TaskHookMessage              RenewalSuccess RenewalException,RenewalOverdue - -- -&gt; RenewalTaskHookMessage              FullyAutoImportSuccess,ConfirmDetailSuccess - -- -&gt; AutoImportProcessHookMessage              ElectionCompleted,ElectionOverdue - --&gt; ElectionHookMessage              LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated - -- -&gt; ElectionOverdue | [optional] 
**TriggerTime** | **DateTime** | Time that the webhook is triggered | [optional] 
**ObjectUrl** | **string** | URL of the workspace | [optional] 
**ObjectId** | **Guid?** | The unique ID of the workspace | [optional] 
**Summary** | **string** | Request or task summary | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

