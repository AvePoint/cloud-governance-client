# ClonePermissionService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelectedNodes** | [**TreeNode[]**](TreeNode.md) |  | [optional] 
**UncheckedNodes** | [**TreeNode[]**](TreeNode.md) |  | [optional] 
**SourceUserRestrictionType** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] 
**TargetUserRestrictionType** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] 
**CloneOption** | [**ClonePermissionOption**](ClonePermissionOption.md) |  | [optional] 
**ClonePermissionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**AdditionalCloneOption** | [**ClonePermissionAdditionalOption**](ClonePermissionAdditionalOption.md) |  | [optional] 
**CloneAdditionalOptionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**EnabledRemoveExplicitPermission** | **Boolean** |  | [optional] 
**EnabledRemoveUserFromSPGroup** | **Boolean** |  | [optional] 
**EnabledDeleteUserPermission** | **Boolean** |  | [optional] 
**TransferOptionValueAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**IsHideTree** | **Boolean** |  | [optional] 
**ScopeSettings** | [**ServiceScopeSettings**](ServiceScopeSettings.md) |  | [optional] 
**RequestTemplate** | [**ClonePermissionRequest**](ClonePermissionRequest.md) |  | [optional] 
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
$ClonePermissionService = New-Cloud.Governance.ClientClonePermissionService  -SelectedNodes null `
 -UncheckedNodes null `
 -SourceUserRestrictionType null `
 -TargetUserRestrictionType null `
 -CloneOption null `
 -ClonePermissionAssignBy null `
 -AdditionalCloneOption null `
 -CloneAdditionalOptionAssignBy null `
 -EnabledRemoveExplicitPermission null `
 -EnabledRemoveUserFromSPGroup null `
 -EnabledDeleteUserPermission null `
 -TransferOptionValueAssignBy null `
 -IsHideTree null `
 -ScopeSettings null `
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
$ClonePermissionService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

