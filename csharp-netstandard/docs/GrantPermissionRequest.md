# Cloud.Governance.Client.Model.GrantPermissionRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | [**GrantPermissionSPObject**](GrantPermissionSPObject.md) |  | [optional] 
**PermissionSettings** | [**GrantPermissionRequestPermissionSettings**](GrantPermissionRequestPermissionSettings.md) |  | [optional] 
**PermissionDurationSettings** | [**GrantPermissionRequestDurationSettings**](GrantPermissionRequestDurationSettings.md) |  | [optional] 
**SelectedUsers** | [**List&lt;SharingEnabledUser&gt;**](SharingEnabledUser.md) |  | [optional] 
**ExternalUserSharingSettings** | [**ExternalUserSharingSettings**](ExternalUserSharingSettings.md) |  | [optional] 
**WelcomeEmailSettings** | [**WelcomeEmailSettings**](WelcomeEmailSettings.md) |  | [optional] 
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

