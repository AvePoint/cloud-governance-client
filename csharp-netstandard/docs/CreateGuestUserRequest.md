# Cloud.Governance.Client.Model.CreateGuestUserRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserProperties** | [**GuestUserPropertyModel**](GuestUserPropertyModel.md) |  | [optional] 
**WelcomeEmailMessage** | **string** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**InviteGroups** | [**List&lt;ApiUser&gt;**](ApiUser.md) |  | [optional] 
**OneTimeSettings** | [**GuestUserRequestOneTimeRenewalSettingModel**](GuestUserRequestOneTimeRenewalSettingModel.md) |  | [optional] 
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
