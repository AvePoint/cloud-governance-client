# RequestHookMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceName** | **String** |  | [optional] 
**ServiceId** | **String** |  | [optional] 
**RequestId** | **Int32** | Ticket number of the request | [optional] [default to 0]
**RequestGuid** | **String** | Unique ID of the request | [optional] 
**RequesterIdentityName** | **String** | User principal name of the requester | [optional] 
**Requester** | **String** | Display name of the requester | [optional] 
**ServiceType** | **String** | Type of service that is used to submit this request | [optional] 
**ServiceTypeEnum** | [**ServiceType**](ServiceType.md) | Type enum of service that is used to submit this request | [optional] 
**TriggerType** | [**TriggerType**](TriggerType.md) | Event type that being triggered, available values and corresponding messages:                            RequestSubmitted,RequestCompleted,RequestCancelled ----&gt; RequestHookMessage              TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped ----&gt; TaskHookMessage              RenewalSuccess RenewalException,RenewalOverdue ----&gt; RenewalTaskHookMessage              FullyAutoImportSuccess,ConfirmDetailSuccess ----&gt; AutoImportProcessHookMessage              ElectionCompleted,ElectionOverdue ---&gt; ElectionHookMessage              LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated ----&gt; ElectionOverdue | [optional] 
**TriggerTime** | **System.DateTime** | Time that the webhook is triggered | [optional] 
**ObjectUrl** | **String** | URL of the workspace | [optional] 
**ObjectId** | **String** | The unique ID of the workspace | [optional] 
**Summary** | **String** | Request or task summary | [optional] 

## Examples

- Prepare the resource
```powershell
$RequestHookMessage = New-Cloud.Governance.ClientRequestHookMessage  -ServiceName null `
 -ServiceId null `
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
$RequestHookMessage | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

