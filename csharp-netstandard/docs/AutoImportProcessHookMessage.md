# Cloud.Governance.Client.Model.AutoImportProcessHookMessage
When an import process with pre-defined governance details or end user completes a confirm governance details task is completed
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoImportProfileName** | **string** | Name of the import job | [optional] 
**TaskLink** | **string** | Link of task  &lt;sample&gt;abc&lt;/sample&gt; | [optional] 
**ObjectTitle** | **string** | Name of the workspace | [optional] 
**ObjectType** | **string** | Type of the workspace | [optional] 
**ObjectTypeEnum** | **HookMessageObjectType** | Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer | [optional] 
**GroupEmail** | **string** | E-mail address of the workspace | [optional] 
**TriggerType** | **TriggerType** | Event type that being triggered, available values and corresponding messages:    RequestSubmitted,RequestCompleted,RequestCancelled - -- -&gt; RequestHookMessage  TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped - -- -&gt; TaskHookMessage  RenewalSuccess RenewalException,RenewalOverdue - -- -&gt; RenewalTaskHookMessage  FullyAutoImportSuccess,ConfirmDetailSuccess - -- -&gt; AutoImportProcessHookMessage  ElectionCompleted,ElectionOverdue - --&gt; ElectionHookMessage  LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated - -- -&gt; ElectionOverdue | [optional] 
**TriggerTime** | **DateTime** | Time that the webhook is triggered | [optional] 
**ObjectUrl** | **string** | URL of the workspace | [optional] 
**ObjectId** | **Guid?** | The unique ID of the workspace | [optional] 
**Summary** | **string** | Request or task summary | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

