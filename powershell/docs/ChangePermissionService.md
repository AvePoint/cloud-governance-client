# ChangePermissionService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelectedNodes** | [**TreeNode[]**](TreeNode.md) |  | [optional] 
**UncheckedNodes** | [**TreeNode[]**](TreeNode.md) |  | [optional] 
**UserRestrictionType** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] 
**PermissionChangedType** | [**PermissionChangedType**](PermissionChangedType.md) |  | [optional] 
**PermissionChangedTypeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**EnabledExcludePermissions** | **Boolean** |  | [optional] 
**ExcludedPermissions** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] 
**ReviewTaskEmailTemplate** | [**GuidModel**](GuidModel.md) |  | [optional] 
**ScopeSettings** | [**ServiceScopeSettings**](ServiceScopeSettings.md) |  | [optional] 
**StageCount** | **Int32** |  | [optional] 
**RequestTemplate** | [**ChangePermissionRequest**](ChangePermissionRequest.md) |  | [optional] 
**DepartmentAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**HideRequestSummary** | **Boolean** |  | [optional] 
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] 
**Department** | **String** |  | [optional] 
**LoadDepartmentFromUps** | **Boolean** |  | [optional] 
**Departments** | **String[]** |  | [optional] 
**ServiceContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**ServiceAdminContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**ApproversContainManagerRole** | **Boolean** |  | [optional] 
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] 
**ShowServiceInCatalog** | **Boolean** |  | [optional] 
**CustomActions** | [**CustomActionSettings**](CustomActionSettings.md) |  | [optional] 
**ApprovalProcessId** | **String** |  | [optional] 
**LanguageId** | **Int32** |  | [optional] 
**CategoryId** | **String** |  | [optional] 
**Details** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangePermissionService = New-Cloud.Governance.ClientChangePermissionService  -SelectedNodes null `
 -UncheckedNodes null `
 -UserRestrictionType null `
 -PermissionChangedType null `
 -PermissionChangedTypeAssignBy null `
 -EnabledExcludePermissions null `
 -ExcludedPermissions null `
 -ReviewTaskEmailTemplate null `
 -ScopeSettings null `
 -StageCount null `
 -RequestTemplate null `
 -DepartmentAssignBy null `
 -Metadatas null `
 -HideRequestSummary null `
 -Id null `
 -Name null `
 -Description null `
 -Type null `
 -Department null `
 -LoadDepartmentFromUps null `
 -Departments null `
 -ServiceContact null `
 -ServiceAdminContact null `
 -ApproversContainManagerRole null `
 -Status null `
 -ShowServiceInCatalog null `
 -CustomActions null `
 -ApprovalProcessId null `
 -LanguageId null `
 -CategoryId null `
 -Details null
```

- Convert the resource to JSON
```powershell
$ChangePermissionService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

