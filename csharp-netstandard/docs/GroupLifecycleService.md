# Cloud.Governance.Client.Model.GroupLifecycleService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **Guid** |  | [optional] 
**Action** | **GroupLifecycleActionType** |  | [optional] 
**GroupObjectType** | **GroupObjectType** |  | [optional] 
**NetworkId** | **string** |  | [optional] 
**ScopePeoplePickerFilterProfileId** | **Guid?** |  | [optional] 
**RequestTemplate** | [**GroupLifecycleRequest**](GroupLifecycleRequest.md) |  | [optional] 
**ChangePolicyAssignBy** | **AssignBy** |  | [optional] 
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

