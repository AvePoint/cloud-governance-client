# ContentMoveService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | [**ContentMoveMethod**](ContentMoveMethod.md) |  | [optional] 
**Action** | [**ContentMoveAction**](ContentMoveAction.md) |  | [optional] 
**CopySettings** | [**ContentMoveRequestCopySettings**](ContentMoveRequestCopySettings.md) |  | [optional] 
**MoveSettings** | [**ContentMoveRequestCopySettings**](ContentMoveRequestCopySettings.md) |  | [optional] 
**CommonSettings** | [**ContentMoveRequestCommonSettings**](ContentMoveRequestCommonSettings.md) |  | [optional] 
**ConflictResolutionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**DeleteTypeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**DeleteCheckedFilesAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**FilterPolicyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**MethodAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**ActionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**CopySettingAssignBy** | [**ContentMoveServiceCopySettingAssignBy**](ContentMoveServiceCopySettingAssignBy.md) |  | [optional] 
**MoveSettingAssignBy** | [**ContentMoveServiceCopySettingAssignBy**](ContentMoveServiceCopySettingAssignBy.md) |  | [optional] 
**VersionsAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**WorkflowAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**InformationRightsManagementAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**NullColumnValueAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**ModifiedByAndModifiedTimeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**MappingSettingAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**BackupEnvironmentAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**RequestTemplate** | [**ContentMoveServiceRequestTemplate**](ContentMoveServiceRequestTemplate.md) |  | [optional] 
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
$ContentMoveService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

