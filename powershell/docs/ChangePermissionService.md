# ChangePermissionService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelectedNodes** | [**TreeNode[]**](TreeNode.md) |  | [optional] 
**UncheckedNodes** | [**TreeNode[]**](TreeNode.md) |  | [optional] 
**UserRestrictionType** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] 
**PermissionChangedType** | [**PermissionChangedType**](PermissionChangedType.md) |  | [optional] 
**PermissionChangedTypeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**EnabledExcludePermissions** | **Boolean** |  | [optional] [default to $false]
**ExcludedPermissions** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] 
**ReviewTaskEmailTemplate** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
**ScopeSettings** | [**ChangePermissionServiceScopeSettings**](ChangePermissionServiceScopeSettings.md) |  | [optional] 
**StageCount** | **Int32** |  | [optional] [default to 0]
**RequestTemplate** | [**ChangePermissionServiceRequestTemplate**](ChangePermissionServiceRequestTemplate.md) |  | [optional] 
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
$ChangePermissionService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

