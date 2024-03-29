# ElectionHookMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceType** | **String** | Type enum of election, available values: Group Deactivated Contact Election, Site Collection Deactivated Contact Election             , Elect Contact, Specify contact | [optional] 
**IsPrimaryContactDeactived** | **Boolean** | Is primary contact deactived | [optional] [default to $false]
**OriginalPrimaryContact** | [**ElectionContact**](ElectionContact.md) | Original primary contact | [optional] 
**IsPrimaryContactChanged** | **Boolean** | Is primary contact changed | [optional] [default to $false]
**NewPrimaryContact** | [**ElectionContact**](ElectionContact.md) | New primary contact | [optional] 
**IsSecondaryContactDeactived** | **Boolean** | Is secondary contact deactived | [optional] [default to $false]
**OriginalSecondaryContact** | [**ElectionContact**](ElectionContact.md) | Original secondary contact | [optional] 
**IsSecondaryContactChanged** | **Boolean** | Is secondary contact changed | [optional] [default to $false]
**NewSecondaryContact** | [**ElectionContact**](ElectionContact.md) | New secondary contact | [optional] 
**TaskLink** | **String** | Link of task | [optional] 
**ObjectTitle** | **String** | Name of the workspace | [optional] 
**ObjectType** | **String** | Type of the workspace | [optional] 
**ObjectTypeEnum** | [**HookMessageObjectType**](HookMessageObjectType.md) | Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer | [optional] 
**GroupEmail** | **String** | E-mail address of the workspace | [optional] 
**TriggerType** | [**TriggerType**](TriggerType.md) | Event type that being triggered, available values and corresponding messages:                          RequestSubmitted,RequestCompleted,RequestCancelled ----&gt; RequestHookMessage             TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped ----&gt; TaskHookMessage             RenewalSuccess RenewalException,RenewalOverdue ----&gt; RenewalTaskHookMessage             FullyAutoImportSuccess,ConfirmDetailSuccess ----&gt; AutoImportProcessHookMessage             ElectionCompleted,ElectionOverdue ---&gt; ElectionHookMessage             LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated ----&gt; ElectionOverdue | [optional] 
**TriggerTime** | **System.DateTime** | Time that the webhook is triggered | [optional] 
**ObjectUrl** | **String** | URL of the workspace | [optional] 
**ObjectId** | **String** | The unique ID of the workspace | [optional] 
**Summary** | **String** | Request or task summary | [optional] 

## Examples

- Prepare the resource
```powershell
$ElectionHookMessage = New-Cloud.Governance.ClientElectionHookMessage  -ServiceType null `
 -IsPrimaryContactDeactived null `
 -OriginalPrimaryContact null `
 -IsPrimaryContactChanged null `
 -NewPrimaryContact null `
 -IsSecondaryContactDeactived null `
 -OriginalSecondaryContact null `
 -IsSecondaryContactChanged null `
 -NewSecondaryContact null `
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
$ElectionHookMessage | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

