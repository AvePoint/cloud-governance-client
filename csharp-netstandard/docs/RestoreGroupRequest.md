# Cloud.Governance.Client.Model.RestoreGroupRequest
Restore group request model
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **Guid** | Object ID | [optional] 
**GroupName** | **string** | Group name | [optional] [readonly] 
**GroupEmail** | **string** | Group e-mail address | [optional] [readonly] 
**GroupObjectType** | **GroupObjectType** | Group type | [optional] 
**LifecycleType** | **ServiceType** | Lifecycle type | [optional] 
**GenerateFromRenewal** | **bool** | If generate from renewal | [optional] [default to false]
**GenerateFromElection** | **bool** | If generate from election | [optional] [default to false]
**Id** | **Guid?** | Id of request. | [optional] 
**ServiceId** | **Guid** | Id of service. | [optional] 
**Summary** | **string** | Summary of request. | [optional] 
**NotesToApprovers** | **string** | Notes to approvers. | [optional] 
**QuestionnaireId** | **Guid?** | Id of questionnaire | [optional] 
**QuestionnaireResponse** | [**List&lt;QuestionAnswerResponse&gt;**](QuestionAnswerResponse.md) | Questionnaire question and answer of request. | [optional] 
**Metadatas** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) | Metadata of request. | [optional] 
**TicketNumber** | **int?** | Ticket number of request. | [optional] [readonly] [default to 0]
**Type** | **ServiceType** | Service type of request. | [optional] [readonly] 
**TypeDescription** | **string** | Service type description of request. | [optional] [readonly] 
**Requester** | **string** | Requester display name. | [optional] [readonly] 
**RequesterLoginName** | **string** | Requester login name. | [optional] [readonly] 
**Status** | **RequestStatus** | Status of request. | [optional] [readonly] 
**ProgressStatus** | **int** | Progress status of request. | [optional] [readonly] [default to 0]
**ProgressStatusDescription** | **string** | Progress status description of request. | [optional] [readonly] 
**SubmittedTime** | **DateTime?** | Submitted time of request. | [optional] [readonly] 
**LastUpdated** | **DateTime?** | Last updated time of request. | [optional] [readonly] 
**CreatedTime** | **DateTime?** | Created time of request. | [optional] [readonly] 
**HasSubRequest** | **bool** | HasSubRequest | [optional] [default to false]
**IsEnabledPassback** | **bool** |  | [optional] [default to false]
**RequestResourceType** | **RequestResourceType** | RequestResourceType | [optional] 
**ModifiedBy** | **string** | ModifiedBy | [optional] 
**ModifiedByDisplayName** | **string** | ModifiedByDisplayName | [optional] 
**ModifiedDate** | **DateTime?** | ModifiedDate | [optional] 
**AssignTo** | **string** | Task assignee of request. | [optional] [readonly] 
**FullPath** | **string** | Object full path of request. | [optional] [readonly] 
**ApprovalStageName** | **string** | Approval stage name of request. | [optional] [readonly] 
**Participants** | **string** | Participants of request. | [optional] [readonly] 
**ObjectID** | **string** | Object full path/email/private channel of request. | [optional] [readonly] 
**CreatedSource** | **int** |  | [optional] [readonly] [default to 0]
**SubRequestType** | **SubRequestType** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

