# Cloud.Governance.Client.Model.ClonePermissionRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Urls** | **List&lt;string&gt;** |  | [optional] 
**SourceUser** | [**ApiUser**](ApiUser.md) |  | [optional] 
**TargetUser** | [**ApiUser**](ApiUser.md) |  | [optional] 
**CloneOption** | **ClonePermissionOption** |  | [optional] 
**AdditionalCloneOption** | **ClonePermissionAdditionalOption** |  | [optional] 
**EnabledRemoveExplicitPermission** | **bool** |  | [optional] 
**EnabledRemoveUserFromSPGroup** | **bool** |  | [optional] 
**EnabledDeleteUserPermission** | **bool** |  | [optional] 
**Id** | **Guid?** |  | [optional] 
**ServiceId** | **Guid** |  | [optional] 
**Department** | **string** |  | [optional] 
**Summary** | **string** |  | [optional] 
**NotesToApprovers** | **string** |  | [optional] 
**QuestionnaireId** | **Guid?** |  | [optional] 
**Metadatas** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) |  | [optional] 
**TicketNumber** | **int?** |  | [optional] [readonly] 
**Type** | **ServiceTypeNullable** |  | [optional] [readonly] 
**TypeDescription** | **string** |  | [optional] [readonly] 
**Requester** | **string** |  | [optional] [readonly] 
**Status** | **RequestStatusNullable** |  | [optional] [readonly] 
**ProgressStatus** | **int** |  | [optional] [readonly] 
**ProgressStatusDescription** | **string** |  | [optional] [readonly] 
**SubmittedTime** | **DateTime?** |  | [optional] [readonly] 
**LastUpdated** | **DateTime?** |  | [optional] [readonly] 
**CreatedTime** | **DateTime?** |  | [optional] [readonly] 
**AssignTo** | **string** |  | [optional] [readonly] 
**FullPath** | **string** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

