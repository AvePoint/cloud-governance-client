# Cloud.Governance.Client.Model.CreateListRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ListTitle** | **string** |  | [optional] 
**ListName** | **string** |  | [optional] 
**ListDescription** | **string** |  | [optional] 
**ParentObject** | [**CreateListSPObject**](CreateListSPObject.md) |  | [optional] 
**ListTemplate** | **string** |  | [optional] 
**EnableNavigation** | **bool** |  | [optional] 
**ListType** | **ListType** |  | [optional] 
**VersionSettings** | [**ListVersionSettings**](ListVersionSettings.md) |  | [optional] 
**PermissionSettings** | [**ListPermissionSettings**](ListPermissionSettings.md) |  | [optional] 
**Id** | **Guid?** |  | [optional] 
**ServiceId** | **Guid** |  | [optional] 
**Department** | **string** |  | [optional] 
**Summary** | **string** |  | [optional] 
**NotesToApprovers** | **string** |  | [optional] 
**QuestionnaireId** | **Guid?** |  | [optional] 
**Metadatas** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) |  | [optional] 
**TicketNumber** | **int?** |  | [optional] [readonly] 
**Type** | **ServiceType** |  | [optional] [readonly] 
**TypeDescription** | **string** |  | [optional] [readonly] 
**Requester** | **string** |  | [optional] [readonly] 
**RequesterLoginName** | **string** |  | [optional] [readonly] 
**Status** | **RequestStatus** |  | [optional] [readonly] 
**ProgressStatus** | **int** |  | [optional] [readonly] 
**ProgressStatusDescription** | **string** |  | [optional] [readonly] 
**SubmittedTime** | **DateTime?** |  | [optional] [readonly] 
**LastUpdated** | **DateTime?** |  | [optional] [readonly] 
**CreatedTime** | **DateTime?** |  | [optional] [readonly] 
**AssignTo** | **string** |  | [optional] [readonly] 
**FullPath** | **string** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

