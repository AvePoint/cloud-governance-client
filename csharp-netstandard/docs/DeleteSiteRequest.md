# Cloud.Governance.Client.Model.DeleteSiteRequest
Delete site collection request model
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **SiteLifecycleActionType** | Lifecycle management action type | [optional] 
**ActionDescription** | **string** | Description of lifecycle management actions. You can get all available description of lifecycle management actions by invoking the GetSiteLifecycleService api. | [optional] [readonly] 
**SiteId** | **Guid** | Site collection ID | [optional] 
**SiteUrl** | **string** | Site collection URL | [optional] 
**SiteTitle** | **string** | Site Title | [optional] 
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

