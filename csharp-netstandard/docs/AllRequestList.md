# Cloud.Governance.Client.Model.AllRequestList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**ServiceId** | **Guid** |  | [optional] 
**ServiceName** | **string** |  | [optional] 
**ServiceType** | **ServiceType** |  | [optional] 
**ServiceTypeDescription** | **string** |  | [optional] 
**Category** | **Guid** |  | [optional] 
**CategoryName** | **string** |  | [optional] 
**ApprovalStageName** | **string** |  | [optional] 
**Participants** | **string** |  | [optional] 
**ParticipantDisplayName** | **string** |  | [optional] 
**TicketNumber** | **int** |  | [optional] [default to 0]
**Summary** | **string** |  | [optional] 
**Requester** | **string** |  | [optional] 
**RequesterDisplayName** | **string** |  | [optional] 
**DetailStatus** | **RequestProgressStatus** |  | [optional] 
**DetailStatusDescription** | **string** |  | [optional] 
**ProgressStatus** | **ApiRequestProgressStatus** |  | [optional] 
**ProgressStatusDescription** | **string** |  | [optional] 
**Modified** | **DateTime** |  | [optional] 
**ModifiedBy** | **string** |  | [optional] 
**ModifiedByDisplayName** | **string** |  | [optional] 
**ModifiedDate** | **DateTime?** |  | [optional] 
**AssignTo** | **string** |  | [optional] 
**AssignToDisplayName** | **string** |  | [optional] 
**Assignees** | [**List&lt;ApiUser&gt;**](ApiUser.md) |  | [optional] 
**ServiceAdmin** | **string** |  | [optional] 
**ServiceAdminDisplayName** | **string** |  | [optional] 
**ObjectUrl** | **string** |  | [optional] 
**ObjectID** | **string** |  | [optional] 
**CreatedTime** | **DateTime** |  | [optional] 
**HasSubRequest** | **bool** |  | [optional] [default to false]
**IsEnabledPassback** | **bool** |  | [optional] [default to false]
**RequestResourceType** | **RequestResourceType** |  | [optional] 
**RequestResourceTypeDescription** | **string** |  | [optional] 
**SubRequestType** | **SubRequestType** |  | [optional] 
**Metadata** | [**List&lt;ReportMetadata&gt;**](ReportMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

