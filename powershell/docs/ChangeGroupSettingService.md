# ChangeGroupSettingService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**NetworkId** | **String** |  | [optional] 
**GroupRestriction** | [**GroupRestrictionType**](GroupRestrictionType.md) |  | [optional] 
**EnableChangeName** | **Boolean** |  | [optional] 
**EnableChangeDescription** | **Boolean** |  | [optional] 
**EnableChangeMemberSubscription** | **Boolean** |  | [optional] 
**EnableChangeOutsideSenders** | **Boolean** |  | [optional] 
**EnableChangePrimaryContact** | **Boolean** |  | [optional] 
**EnableChangeSecondaryContact** | **Boolean** |  | [optional] 
**EnableAddOwners** | **Boolean** |  | [optional] 
**AddOwnerRestriction** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] 
**EnableRemoveOwners** | **Boolean** |  | [optional] 
**EnableAddMembers** | **Boolean** |  | [optional] 
**AddMemberRestriction** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] 
**EnableRemoveMembers** | **Boolean** |  | [optional] 
**EnableChangeDynamicMembershipRules** | **Boolean** |  | [optional] 
**EnableChangeTeamCollaboration** | **Boolean** |  | [optional] 
**EnableChangeHubSite** | **Boolean** |  | [optional] 
**EnableChangeClassification** | **Boolean** |  | [optional] 
**ClassificationList** | **String[]** |  | [optional] 
**EnableChangeSensitivity** | **Boolean** |  | [optional] 
**SensitivityList** | **String[]** |  | [optional] 
**EnableChangeMetadata** | **Boolean** |  | [optional] 
**EnableAddOrDeleteMetadata** | **Boolean** |  | [optional] 
**MetadataList** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**EnableChangeMembershipType** | **Boolean** |  | [optional] 
**GroupObjectType** | [**GroupObjectType**](GroupObjectType.md) |  | [optional] 
**EnableChangeYammerGroupInfo** | **Boolean** |  | [optional] 
**ScopePeoplePickerFilterProfileId** | **String** |  | [optional] 
**PeoplePickerFilterProfileId** | **String** |  | [optional] 
**RequestTemplate** | [**ChangeGroupSettingRequest**](ChangeGroupSettingRequest.md) |  | [optional] 
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
$ChangeGroupSettingService = New-Cloud.Governance.ClientChangeGroupSettingService  -TenantId null `
 -NetworkId null `
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
 -EnableChangeSensitivity null `
 -SensitivityList null `
 -EnableChangeMetadata null `
 -EnableAddOrDeleteMetadata null `
 -MetadataList null `
 -EnableChangeMembershipType null `
 -GroupObjectType null `
 -EnableChangeYammerGroupInfo null `
 -ScopePeoplePickerFilterProfileId null `
 -PeoplePickerFilterProfileId null `
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
$ChangeGroupSettingService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

