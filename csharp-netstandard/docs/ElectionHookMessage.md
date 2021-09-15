# Cloud.Governance.Client.Model.ElectionHookMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceType** | **string** | Type enum of election, available values: Group Deactivated Contact Election, Site Collection Deactivated Contact Election  , Elect Contact, Specify contact | [optional] 
**IsPrimaryContactDeactived** | **bool** | Is primary contact deactived | [optional] [default to false]
**OriginalPrimaryContact** | [**ElectionContact**](ElectionContact.md) | Original primary contact | [optional] 
**IsPrimaryContactChanged** | **bool** | Is primary contact changed | [optional] [default to false]
**NewPrimaryContact** | [**ElectionContact**](ElectionContact.md) | New primary contact | [optional] 
**IsSecondaryContactDeactived** | **bool** | Is secondary contact deactived | [optional] [default to false]
**OriginalSecondaryContact** | [**ElectionContact**](ElectionContact.md) | Original secondary contact | [optional] 
**IsSecondaryContactChanged** | **bool** | Is secondary contact changed | [optional] [default to false]
**NewSecondaryContact** | [**ElectionContact**](ElectionContact.md) | New secondary contact | [optional] 
**TaskLink** | **string** | Link of task  &lt;sample&gt;abc&lt;/sample&gt; | [optional] 
**ObjectTitle** | **string** | Name of the workspace | [optional] 
**ObjectType** | **string** | Type of the workspace | [optional] 
**ObjectTypeEnum** | **string** | Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer | [optional] 
**GroupEmail** | **string** | E-mail address of the workspace | [optional] 
**TriggerType** | **TriggerType** | Event type that being triggered, available values and corresponding messages:    RequestSubmitted,RequestCompleted,RequestCancelled - -- -&gt; RequestHookMessage  TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped - -- -&gt; TaskHookMessage  RenewalSuccess RenewalException,RenewalOverdue - -- -&gt; RenewalTaskHookMessage  FullyAutoImportSuccess,ConfirmDetailSuccess - -- -&gt; AutoImportProcessHookMessage  ElectionCompleted,ElectionOverdue - --&gt; ElectionHookMessage  LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated - -- -&gt; ElectionOverdue | [optional] 
**TriggerTime** | **DateTime** | Time that the webhook is triggered | [optional] 
**ObjectUrl** | **string** | URL of the workspace | [optional] 
**ObjectId** | **Guid?** | The unique ID of the workspace | [optional] 
**Summary** | **string** | Request or task summary | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

