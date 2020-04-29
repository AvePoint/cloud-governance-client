# ChangePermissionService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelectedNodes** | [**TreeNode[]**](TreeNode.md) |  | [optional] [default to null]
**UncheckedNodes** | [**TreeNode[]**](TreeNode.md) |  | [optional] [default to null]
**UserRestrictionType** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] [default to null]
**PermissionChangedType** | [**PermissionChangedType**](PermissionChangedType.md) |  | [optional] [default to null]
**PermissionChangedTypeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**EnabledExcludePermissions** | **Boolean** |  | [optional] [default to null]
**ExcludedPermissions** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] [default to null]
**ReviewTaskEmailTemplate** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**ScopeSettings** | [**ServiceScopeSettings**](ServiceScopeSettings.md) |  | [optional] [default to null]
**StageCount** | **Int32** |  | [optional] [default to null]
**DepartmentAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] [default to null]
**HideRequestSummary** | **Boolean** |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] [default to null]
**Department** | **String** |  | [optional] [default to null]
**LoadDepartmentFromUps** | **Boolean** |  | [optional] [default to null]
**Departments** | **String[]** |  | [optional] [default to null]
**ServiceContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**ServiceAdminContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**ApproversContainManagerRole** | **Boolean** |  | [optional] [default to null]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] [default to null]
**ShowServiceInCatalog** | **Boolean** |  | [optional] [default to null]
**CustomActions** | [**CustomActionSettings**](CustomActionSettings.md) |  | [optional] [default to null]
**ApprovalProcessId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**LanguageId** | **Int32** |  | [optional] [default to null]
**CategoryId** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangePermissionService  -SelectedNodes null `
 -UncheckedNodes null `
 -UserRestrictionType null `
 -PermissionChangedType null `
 -PermissionChangedTypeAssignBy null `
 -EnabledExcludePermissions null `
 -ExcludedPermissions null `
 -ReviewTaskEmailTemplate null `
 -ScopeSettings null `
 -StageCount null `
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
 -CategoryId null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

