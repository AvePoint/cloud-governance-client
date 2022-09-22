# ChangeWebSettingRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | [**ChangeWebSPObject**](ChangeWebSPObject.md) |  | [optional] 
**ChangedTitle** | [**StringChangedProperty**](StringChangedProperty.md) |  | [optional] 
**ChangedDescription** | [**StringChangedProperty**](StringChangedProperty.md) |  | [optional] 
**ChangedMetadata** | [**RequestMetadataListChangedProperty**](RequestMetadataListChangedProperty.md) |  | [optional] 
**DeploymentPlanName** | **String** |  | [optional] 
**Id** | **String** | Id of request. | [optional] 
**ServiceId** | **String** | Id of service. | [optional] 
**Summary** | **String** | Summary of request. | [optional] 
**NotesToApprovers** | **String** | Notes to approvers. | [optional] 
**QuestionnaireId** | **String** | Id of questionnaire | [optional] 
**QuestionnaireResponse** | [**QuestionAnswerResponse[]**](QuestionAnswerResponse.md) | Questionnaire question and answer of request. | [optional] 
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
**HasSubRequest** | **Boolean** | HasSubRequest | [optional] [default to $false]
**ModifiedBy** | **String** | ModifiedBy | [optional] 
**ModifiedByDisplayName** | **String** | ModifiedByDisplayName | [optional] 
**ModifiedDate** | **System.DateTime** | ModifiedDate | [optional] 
**AssignTo** | **String** | Task assignee of request. | [optional] [readonly] 
**FullPath** | **String** | Object full path of request. | [optional] [readonly] 
**ApprovalStageName** | **String** | Approval stage name of request. | [optional] [readonly] 
**Participants** | **String** | Participants of request. | [optional] [readonly] 
**ObjectID** | **String** | Object full path/email/private channel of request. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ChangeWebSettingRequest = New-Cloud.Governance.ClientChangeWebSettingRequest  -Url null `
 -ChangedTitle null `
 -ChangedDescription null `
 -ChangedMetadata null `
 -DeploymentPlanName null `
 -Id null `
 -ServiceId null `
 -Summary null `
 -NotesToApprovers null `
 -QuestionnaireId null `
 -QuestionnaireResponse null `
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
 -HasSubRequest null `
 -ModifiedBy null `
 -ModifiedByDisplayName null `
 -ModifiedDate null `
 -AssignTo null `
 -FullPath null `
 -ApprovalStageName null `
 -Participants null `
 -ObjectID null
```

- Convert the resource to JSON
```powershell
$ChangeWebSettingRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

