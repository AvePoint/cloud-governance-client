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
**EnabledRemoveExplicitPermission** | **Boolean** |  | [optional] [default to $false]
**EnabledRemoveUserFromSPGroup** | **Boolean** |  | [optional] [default to $false]
**EnabledDeleteUserPermission** | **Boolean** |  | [optional] [default to $false]
**TransferOptionValueAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**IsHideTree** | **Boolean** |  | [optional] [default to $false]
**ScopeSettings** | [**ChangePermissionServiceScopeSettings**](ChangePermissionServiceScopeSettings.md) |  | [optional] 
**RequestTemplate** | [**ClonePermissionServiceRequestTemplate**](ClonePermissionServiceRequestTemplate.md) |  | [optional] 
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**HideRequestSummary** | **Boolean** |  | [optional] [default to $false]
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**ServiceAdminContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**ApproversContainManagerRole** | **Boolean** |  | [optional] [default to $false]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] 
**ShowServiceInCatalog** | **Boolean** |  | [optional] [default to $false]
**CustomActions** | [**ChangeGroupSettingServiceCustomActions**](ChangeGroupSettingServiceCustomActions.md) |  | [optional] 
**ApprovalProcessId** | **String** |  | [optional] 
**LanguageId** | **Int32** |  | [optional] [default to 0]
**CategoryId** | **String** |  | [optional] 

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
 -Metadatas null `
 -HideRequestSummary null `
 -Id null `
 -Name null `
 -Description null `
 -Type null `
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

- Convert the resource to JSON
```powershell
$ClonePermissionService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

