# Cloud.Governance.Client.Model.CreateGuestUserService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **Guid** |  | [optional] 
**EnableInviteOwnersGroup** | **bool** |  | [optional] 
**EnableInviteContactGroup** | **bool** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**PrimaryContactAssignBy** | **AssignBy** |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContactAssignBy** | **AssignBy** |  | [optional] 
**EnableOnTimeRenewal** | **bool** |  | [optional] 
**OneTimeDuration** | **int** |  | [optional] 
**OneTimeDurationType** | **ApiDurationType** |  | [optional] 
**DepartmentAssignBy** | **AssignBy** |  | [optional] 
**Metadatas** | [**List&lt;CustomMetadata&gt;**](CustomMetadata.md) |  | [optional] 
**HideRequestSummary** | **bool** |  | [optional] 
**Id** | **Guid** |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Type** | **ServiceType** |  | [optional] 
**Department** | **string** |  | [optional] 
**LoadDepartmentFromUps** | **bool** |  | [optional] 
**Departments** | **List&lt;string&gt;** |  | [optional] 
**ServiceContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**ServiceAdminContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**ApproversContainManagerRole** | **bool** |  | [optional] 
**Status** | **CommonStatus** |  | [optional] 
**ShowServiceInCatalog** | **bool** |  | [optional] 
**CustomActions** | [**CustomActionSettings**](CustomActionSettings.md) |  | [optional] 
**ApprovalProcessId** | **Guid** |  | [optional] 
**LanguageId** | **int** |  | [optional] 
**CategoryId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

