# Cloud.Governance.Client.Model.ChangeWebContactRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangedMethod** | **ChangeContactMethod** |  | [optional] 
**ChangedByUserSetting** | [**ChangeContactByUserSetting**](ChangeContactByUserSetting.md) |  | [optional] 
**ChangedByUrlItems** | [**List&lt;ChangeWebContactByUrlSetting&gt;**](ChangeWebContactByUrlSetting.md) |  | [optional] 
**SubRequests** | [**List&lt;ChangeWebContactSubRequest&gt;**](ChangeWebContactSubRequest.md) |  | [optional] [readonly] 
**Id** | **Guid?** |  | [optional] 
**ServiceId** | **Guid** |  | [optional] 
**Department** | **string** |  | [optional] 
**Summary** | **string** |  | [optional] 
**NotesToApprovers** | **string** |  | [optional] 
**QuestionnaireId** | **Guid?** |  | [optional] 
**Metadatas** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) |  | [optional] 
**TicketNumber** | **int?** |  | [optional] [readonly] 
**Type** | **ServiceType** |  | [optional] 
**TypeDescription** | **string** |  | [optional] 
**Requester** | **string** |  | [optional] [readonly] 
**RequesterLoginName** | **string** |  | [optional] [readonly] 
**Status** | **RequestStatus** |  | [optional] 
**ProgressStatus** | **int** |  | [optional] 
**ProgressStatusDescription** | **string** |  | [optional] 
**SubmittedTime** | **DateTime?** |  | [optional] [readonly] 
**LastUpdated** | **DateTime?** |  | [optional] [readonly] 
**CreatedTime** | **DateTime?** |  | [optional] [readonly] 
**AssignTo** | **string** |  | [optional] [readonly] 
**FullPath** | **string** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

