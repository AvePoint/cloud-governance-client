# Cloud.Governance.Client.Model.CreateGuestUserService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **Guid** |  | [optional] 
**EnableInviteOwnersGroup** | **bool** |  | [optional] [default to false]
**EnableInviteContactGroup** | **bool** |  | [optional] [default to false]
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**PrimaryContactAssignBy** | **AssignBy** |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContactAssignBy** | **AssignBy** |  | [optional] 
**EnableOnTimeRenewal** | **bool** |  | [optional] [default to false]
**OneTimeDuration** | **int** |  | [optional] [default to 0]
**OneTimeDurationType** | **ApiDurationType** |  | [optional] 
**RequestTemplate** | [**CreateGuestUserRequest**](CreateGuestUserRequest.md) |  | [optional] 
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

