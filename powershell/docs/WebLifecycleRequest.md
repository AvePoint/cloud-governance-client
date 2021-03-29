# WebLifecycleRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebId** | **String** |  | [optional] 
**WebUrl** | **String** |  | [optional] 
**WebRelativeUrl** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**Action** | [**WebLifecycleActionType**](WebLifecycleActionType.md) |  | [optional] 
**ActionDescription** | **String** |  | [optional] [readonly] 
**Id** | **String** | Id of request. | [optional] 
**ServiceId** | **String** | Id of service. | [optional] 
**Department** | **String** | Department of requester. | [optional] 
**Summary** | **String** | Summary of request. | [optional] 
**NotesToApprovers** | **String** | Notes to approvers. | [optional] 
**QuestionnaireId** | **String** | Id of questionnaire | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) | Metadata of request. | [optional] 
**TicketNumber** | **Int32** | Ticket number of request. | [optional] [readonly] [default to 0]
**Type** | [**ServiceType**](ServiceType.md) | Service type of request. | [optional] [readonly] 
**TypeDescription** | **String** | Service type description of request. | [optional] [readonly] 
**Requester** | **String** | Requester display name. | [optional] [readonly] 
**RequesterLoginName** | **String** | Requester login name. | [optional] [readonly] 
**Status** | [**RequestStatus**](RequestStatus.md) | Status of request. | [optional] [readonly] 
**ProgressStatus** | **Int32** | Progress status of request. | [optional] [readonly] [default to 0]
**ProgressStatusDescription** | **String** | Progress status description of request. | [optional] [readonly] 
**SubmittedTime** | **System.DateTime** | Submitted time of request. | [optional] [readonly] 
**LastUpdated** | **System.DateTime** | Last updated time of request. | [optional] [readonly] 
**CreatedTime** | **System.DateTime** | Created time of request. | [optional] [readonly] 
**AssignTo** | **String** | Task assignee of request. | [optional] [readonly] 
**FullPath** | **String** | Object full path of request. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$WebLifecycleRequest = New-Cloud.Governance.ClientWebLifecycleRequest  -WebId null `
 -WebUrl null `
 -WebRelativeUrl null `
 -SiteId null `
 -SiteUrl null `
 -Action null `
 -ActionDescription null `
 -Id null `
 -ServiceId null `
 -Department null `
 -Summary null `
 -NotesToApprovers null `
 -QuestionnaireId null `
 -Metadatas null `
 -TicketNumber null `
 -Type null `
 -TypeDescription null `
 -Requester null `
 -RequesterLoginName null `
 -Status null `
 -ProgressStatus null `
 -ProgressStatusDescription null `
 -SubmittedTime null `
 -LastUpdated null `
 -CreatedTime null `
 -AssignTo null `
 -FullPath null
```

- Convert the resource to JSON
```powershell
$WebLifecycleRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

