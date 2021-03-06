# Cloud.Governance.Client.Model.ChangePermissionService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelectedNodes** | [**List&lt;TreeNode&gt;**](TreeNode.md) |  | [optional] 
**UncheckedNodes** | [**List&lt;TreeNode&gt;**](TreeNode.md) |  | [optional] 
**UserRestrictionType** | **UserLevelRestrictionType** |  | [optional] 
**PermissionChangedType** | **PermissionChangedType** |  | [optional] 
**PermissionChangedTypeAssignBy** | **AssignBy** |  | [optional] 
**EnabledExcludePermissions** | **bool** |  | [optional] [default to false]
**ExcludedPermissions** | [**List&lt;PermissionLevel&gt;**](PermissionLevel.md) |  | [optional] 
**ReviewTaskEmailTemplate** | [**GuidModel**](GuidModel.md) |  | [optional] 
**ScopeSettings** | [**ServiceScopeSettings**](ServiceScopeSettings.md) |  | [optional] 
**StageCount** | **int** |  | [optional] [default to 0]
**RequestTemplate** | [**ChangePermissionRequest**](ChangePermissionRequest.md) |  | [optional] 
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

