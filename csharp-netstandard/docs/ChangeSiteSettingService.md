# Cloud.Governance.Client.Model.ChangeSiteSettingService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableChangeTitle** | **bool** |  | [optional] [default to false]
**EnableChangeDescription** | **bool** |  | [optional] [default to false]
**ChangeMetadataSettings** | [**ChangeMetadataActionSetting**](ChangeMetadataActionSetting.md) |  | [optional] 
**DeploymentManagerPlanSettings** | [**DpmServiceSetting**](DpmServiceSetting.md) |  | [optional] 
**EnableChangeHubSite** | **bool** |  | [optional] [default to false]
**ScopeSettings** | [**ServiceScopeSettings**](ServiceScopeSettings.md) |  | [optional] 
**RequestTemplate** | [**ChangeSiteSettingRequest**](ChangeSiteSettingRequest.md) |  | [optional] 
**DepartmentAssignBy** | **AssignBy** |  | [optional] 
**Metadatas** | [**List&lt;CustomMetadata&gt;**](CustomMetadata.md) |  | [optional] 
**HideRequestSummary** | **bool** |  | [optional] [default to false]
**Id** | **Guid** |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Type** | **ServiceType** |  | [optional] 
**Department** | **string** |  | [optional] 
**LoadDepartmentFromUps** | **bool** |  | [optional] [default to false]
**Departments** | **List&lt;string&gt;** |  | [optional] 
**ServiceContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**ServiceAdminContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**ApproversContainManagerRole** | **bool** |  | [optional] [default to false]
**Status** | **CommonStatus** |  | [optional] 
**ShowServiceInCatalog** | **bool** |  | [optional] [default to false]
**CustomActions** | [**CustomActionSettings**](CustomActionSettings.md) |  | [optional] 
**ApprovalProcessId** | **Guid** |  | [optional] 
**LanguageId** | **int** |  | [optional] [default to 0]
**CategoryId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

