# ContentMoveService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | [**ContentMoveMethod**](ContentMoveMethod.md) |  | [optional] 
**Action** | [**ContentMoveAction**](ContentMoveAction.md) |  | [optional] 
**CopySettings** | [**CopyMoveSetting**](CopyMoveSetting.md) |  | [optional] 
**MoveSettings** | [**CopyMoveSetting**](CopyMoveSetting.md) |  | [optional] 
**CommonSettings** | [**ContentMoveCommonSetting**](ContentMoveCommonSetting.md) |  | [optional] 
**ConflictResolutionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**DeleteTypeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**DeleteCheckedFilesAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**FilterPolicyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**MethodAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**ActionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**CopySettingAssignBy** | [**CopyMoveSettingAssignBy**](CopyMoveSettingAssignBy.md) |  | [optional] 
**MoveSettingAssignBy** | [**CopyMoveSettingAssignBy**](CopyMoveSettingAssignBy.md) |  | [optional] 
**VersionsAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**WorkflowAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**InformationRightsManagementAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**NullColumnValueAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**ModifiedByAndModifiedTimeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**MappingSettingAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**BackupEnvironmentAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**RequestTemplate** | [**ContentMoveRequest**](ContentMoveRequest.md) |  | [optional] 
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
$ContentMoveService = New-Cloud.Governance.ClientContentMoveService  -Method null `
 -Action null `
 -CopySettings null `
 -MoveSettings null `
 -CommonSettings null `
 -ConflictResolutionAssignBy null `
 -DeleteTypeAssignBy null `
 -DeleteCheckedFilesAssignBy null `
 -FilterPolicyAssignBy null `
 -MethodAssignBy null `
 -ActionAssignBy null `
 -CopySettingAssignBy null `
 -MoveSettingAssignBy null `
 -VersionsAssignBy null `
 -WorkflowAssignBy null `
 -InformationRightsManagementAssignBy null `
 -NullColumnValueAssignBy null `
 -ModifiedByAndModifiedTimeAssignBy null `
 -MappingSettingAssignBy null `
 -BackupEnvironmentAssignBy null `
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
$ContentMoveService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

