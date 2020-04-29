# ChangeGroupSettingService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**GroupRestriction** | [**GroupRestrictionType**](GroupRestrictionType.md) |  | [optional] [default to null]
**EnableChangeName** | **Boolean** |  | [optional] [default to null]
**EnableChangeDescription** | **Boolean** |  | [optional] [default to null]
**EnableChangeMemberSubscription** | **Boolean** |  | [optional] [default to null]
**EnableChangeOutsideSenders** | **Boolean** |  | [optional] [default to null]
**EnableChangePrimaryContact** | **Boolean** |  | [optional] [default to null]
**EnableChangeSecondaryContact** | **Boolean** |  | [optional] [default to null]
**EnableAddOwners** | **Boolean** |  | [optional] [default to null]
**AddOwnerRestriction** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] [default to null]
**EnableRemoveOwners** | **Boolean** |  | [optional] [default to null]
**EnableAddMembers** | **Boolean** |  | [optional] [default to null]
**AddMemberRestriction** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] [default to null]
**EnableRemoveMembers** | **Boolean** |  | [optional] [default to null]
**EnableChangeDynamicMembershipRules** | **Boolean** |  | [optional] [default to null]
**EnableChangeTeamCollaboration** | **Boolean** |  | [optional] [default to null]
**EnableChangeHubSite** | **Boolean** |  | [optional] [default to null]
**EnableChangeClassification** | **Boolean** |  | [optional] [default to null]
**ClassificationList** | **String[]** |  | [optional] [default to null]
**EnableChangeMetadata** | **Boolean** |  | [optional] [default to null]
**EnableAddOrDeleteMetadata** | **Boolean** |  | [optional] [default to null]
**MetadataList** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] [default to null]
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
New-Cloud.Governance.ClientChangeGroupSettingService  -TenantId null `
 -GroupRestriction null `
 -EnableChangeName null `
 -EnableChangeDescription null `
 -EnableChangeMemberSubscription null `
 -EnableChangeOutsideSenders null `
 -EnableChangePrimaryContact null `
 -EnableChangeSecondaryContact null `
 -EnableAddOwners null `
 -AddOwnerRestriction null `
 -EnableRemoveOwners null `
 -EnableAddMembers null `
 -AddMemberRestriction null `
 -EnableRemoveMembers null `
 -EnableChangeDynamicMembershipRules null `
 -EnableChangeTeamCollaboration null `
 -EnableChangeHubSite null `
 -EnableChangeClassification null `
 -ClassificationList null `
 -EnableChangeMetadata null `
 -EnableAddOrDeleteMetadata null `
 -MetadataList null `
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

