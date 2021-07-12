# Cloud.Governance.Client.Model.CreateGuestUserService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **Guid** |  | [optional] 
**EnableInviteOwnersGroup** | **bool** |  | [optional] [default to false]
**EnableInviteContactGroup** | **bool** |  | [optional] [default to false]
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**PrimaryContactAssignBy** | **AssignBy** |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContactAssignBy** | **AssignBy** |  | [optional] 
**Manager** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ManagerAssignBy** | **AssignBy** |  | [optional] 
**EnableOnTimeRenewal** | **bool** |  | [optional] [default to false]
**OneTimeDuration** | **int** |  | [optional] [default to 0]
**OneTimeDurationType** | **ApiDurationType** |  | [optional] 
**RequestTemplate** | [**CreateGuestUserRequest**](CreateGuestUserRequest.md) |  | [optional] 
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

