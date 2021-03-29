# Cloud.Governance.Client.Model.ClonePermissionService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelectedNodes** | [**List&lt;TreeNode&gt;**](TreeNode.md) |  | [optional] 
**UncheckedNodes** | [**List&lt;TreeNode&gt;**](TreeNode.md) |  | [optional] 
**SourceUserRestrictionType** | **UserLevelRestrictionType** |  | [optional] 
**TargetUserRestrictionType** | **UserLevelRestrictionType** |  | [optional] 
**CloneOption** | **ClonePermissionOption** |  | [optional] 
**ClonePermissionAssignBy** | **AssignBy** |  | [optional] 
**AdditionalCloneOption** | **ClonePermissionAdditionalOption** |  | [optional] 
**CloneAdditionalOptionAssignBy** | **AssignBy** |  | [optional] 
**EnabledRemoveExplicitPermission** | **bool** |  | [optional] [default to false]
**EnabledRemoveUserFromSPGroup** | **bool** |  | [optional] [default to false]
**EnabledDeleteUserPermission** | **bool** |  | [optional] [default to false]
**TransferOptionValueAssignBy** | **AssignBy** |  | [optional] 
**IsHideTree** | **bool** |  | [optional] [default to false]
**ScopeSettings** | [**ServiceScopeSettings**](ServiceScopeSettings.md) |  | [optional] 
**RequestTemplate** | [**ClonePermissionRequest**](ClonePermissionRequest.md) |  | [optional] 
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

