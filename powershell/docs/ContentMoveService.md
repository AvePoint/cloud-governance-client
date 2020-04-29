# ContentMoveService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | [**ContentMoveMethod**](ContentMoveMethod.md) |  | [optional] [default to null]
**Action** | [**ContentMoveAction**](ContentMoveAction.md) |  | [optional] [default to null]
**CopySettings** | [**CopyMoveSetting**](CopyMoveSetting.md) |  | [optional] [default to null]
**MoveSettings** | [**CopyMoveSetting**](CopyMoveSetting.md) |  | [optional] [default to null]
**CommonSettings** | [**ContentMoveCommonSetting**](ContentMoveCommonSetting.md) |  | [optional] [default to null]
**ConflictResolutionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**DeleteTypeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**DeleteCheckedFilesAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**FilterPolicyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**MethodAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**ActionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**CopySettingAssignBy** | [**CopyMoveSettingAssignBy**](CopyMoveSettingAssignBy.md) |  | [optional] [default to null]
**MoveSettingAssignBy** | [**CopyMoveSettingAssignBy**](CopyMoveSettingAssignBy.md) |  | [optional] [default to null]
**VersionsAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**WorkflowAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**InformationRightsManagementAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**NullColumnValueAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**ModifiedByAndModifiedTimeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**MappingSettingAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**BackupEnvironmentAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
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
New-Cloud.Governance.ClientContentMoveService  -Method null `
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

