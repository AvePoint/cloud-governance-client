# Cloud.Governance.Client.Model.GrantPermissionService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowBreakPermissionInheritance** | **bool** |  | [optional] [default to false]
**ScopeSettings** | [**ServiceScopeSettings**](ServiceScopeSettings.md) |  | [optional] 
**UserLevelControlSettings** | [**UserLevelControlSettings**](UserLevelControlSettings.md) |  | [optional] 
**PermissionDurationSettings** | [**GrantPermissionServiceDurationSettings**](GrantPermissionServiceDurationSettings.md) |  | [optional] 
**PermissionSettings** | [**GrantPermissionServicePermissionSettings**](GrantPermissionServicePermissionSettings.md) |  | [optional] 
**DefaultWelcomeEmailSettings** | [**WelcomeEmailSettings**](WelcomeEmailSettings.md) |  | [optional] 
**WelcomeEmailAssignBy** | **AssignBy** |  | [optional] 
**RequestTemplate** | [**GrantPermissionRequest**](GrantPermissionRequest.md) |  | [optional] 
**Metadatas** | [**List&lt;CustomMetadata&gt;**](CustomMetadata.md) |  | [optional] 
**HideRequestSummary** | **bool** |  | [optional] [default to false]
**Id** | **Guid** |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Type** | **ServiceType** |  | [optional] 
**ServiceContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ServiceAdminContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ApproversContainManagerRole** | **bool** |  | [optional] [default to false]
**Status** | **CommonStatus** |  | [optional] 
**ShowServiceInCatalog** | **bool** |  | [optional] [default to false]
**CustomActions** | [**CustomActionSettings**](CustomActionSettings.md) |  | [optional] 
**ApprovalProcessId** | **Guid** |  | [optional] 
**LanguageId** | **int** |  | [optional] [default to 0]
**CategoryId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

