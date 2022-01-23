# Cloud.Governance.Client.Model.ChangeGroupPolicyRequest
Change group policy request model
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalPolicy** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] [readonly] 
**IsLeaseEnabled** | **bool** | Whether to enable the group/team lease extension. | [optional] [default to false]
**ChangePolicyConfig** | **AssignBy** | Set how to assign the group policy. | [optional] 
**StartDateType** | **StartDateType** | Group lease start date configuration after a policy change | [optional] 
**SpecifyStartDate** | **DateTime?** | New lease start date | [optional] 
**GroupId** | **Guid** | Object ID | [optional] 
**GroupName** | **string** | Group name | [optional] [readonly] 
**GroupEmail** | **string** | Group e-mail address | [optional] [readonly] 
**GroupObjectType** | **GroupObjectType** | Group type | [optional] 
**Id** | **Guid?** | Id of request. | [optional] 
**ServiceId** | **Guid** | Id of service. | [optional] 
**Summary** | **string** | Summary of request. | [optional] 
**NotesToApprovers** | **string** | Notes to approvers. | [optional] 
**QuestionnaireId** | **Guid?** | Id of questionnaire | [optional] 
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
**AssignTo** | **string** | Task assignee of request. | [optional] [readonly] 
**FullPath** | **string** | Object full path of request. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

