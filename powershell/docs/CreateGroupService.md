# CreateGroupService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupType** | [**CreateGroupType**](CreateGroupType.md) |  | [optional] 
**TenantId** | **String** |  | [optional] 
**NetworkId** | **String** |  | [optional] 
**EnableTeams** | **Boolean** |  | [optional] 
**IsPrivate** | **Boolean** |  | [optional] 
**EnableSubscribe** | **Boolean** |  | [optional] 
**EnableApplySiteDesign** | **Boolean** |  | [optional] 
**EnableOutsideSender** | **Boolean** |  | [optional] 
**EnableHideGroupMembership** | **Boolean** |  | [optional] 
**EnableClassification** | **Boolean** |  | [optional] 
**EnableSensitivity** | **Boolean** |  | [optional] 
**AllowConfigureLeasePeriod** | **Boolean** |  | [optional] 
**ShowNotebookLink** | **Boolean** |  | [optional] 
**ShowConversationsLink** | **Boolean** |  | [optional] 
**ShowFilesLink** | **Boolean** |  | [optional] 
**ShowTeamSiteLink** | **Boolean** |  | [optional] 
**ShowPlannerLink** | **Boolean** |  | [optional] 
**ShowYammerGroupLink** | **Boolean** |  | [optional] 
**Classifications** | **String[]** |  | [optional] 
**Sensitivities** | **String[]** |  | [optional] 
**SiteDesigns** | [**GuidModel[]**](GuidModel.md) |  | [optional] 
**AddGroupMemberType** | [**AddGroupMemberType**](AddGroupMemberType.md) |  | [optional] 
**SelectedPolicies** | [**BriefGroupPolicy[]**](BriefGroupPolicy.md) |  | [optional] 
**SelectedLanguages** | [**StringModel[]**](StringModel.md) |  | [optional] 
**TeamsSettings** | [**ServiceTeamsSettings**](ServiceTeamsSettings.md) |  | [optional] 
**GroupNameConstructureSettings** | [**GroupNameConstructureSettings**](GroupNameConstructureSettings.md) |  | [optional] 
**GroupIdConstructureSettings** | [**GroupIdConstructureSettings**](GroupIdConstructureSettings.md) |  | [optional] 
**EnableInstallApp** | **Boolean** |  | [optional] 
**EnableInstallPanel** | **Boolean** |  | [optional] 
**TemplateSettings** | [**TeamsTemplateServiceSettings**](TeamsTemplateServiceSettings.md) |  | [optional] 
**DefaultPrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**DefaultSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**DefaultOwners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**DefaultMembers** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**DefaultPolicy** | **String** |  | [optional] 
**DefaultClassification** | **String** |  | [optional] 
**DefaultSensitivity** | **String** |  | [optional] 
**DefaultLanguage** | **String** |  | [optional] 
**DefaultSiteDesign** | **String** |  | [optional] 
**DefaultOwnersReal** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**DefaultMembersReal** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**DefaultPrimaryContactReal** | [**ApiUser**](ApiUser.md) |  | [optional] 
**DefaultSecondaryContactReal** | [**ApiUser**](ApiUser.md) |  | [optional] 
**MemberAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**OwnerAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**PrivacyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SubscribeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**OutsideSenderAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**ClassificationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SensitivityAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**LanguageAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SecondaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**PrimaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**EnableDynamicMembership** | **Boolean** |  | [optional] 
**HideGroupMembershipAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**PolicyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SiteDesignAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**HubSiteAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**MultiGeoSetting** | [**MultiGeoSetting**](MultiGeoSetting.md) |  | [optional] 
**IsShowHubSiteSection** | **Boolean** |  | [optional] [readonly] 
**HubSiteSettings** | [**HubSiteSettings**](HubSiteSettings.md) |  | [optional] 
**HasImpernastionUsers** | **Boolean** |  | [optional] 
**PeoplePickerFilterProfileId** | **String** |  | [optional] 
**RequestTemplate** | [**CreateGroupRequest**](CreateGroupRequest.md) |  | [optional] 
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
$CreateGroupService = New-Cloud.Governance.ClientCreateGroupService  -GroupType null `
 -TenantId null `
 -NetworkId null `
 -EnableTeams null `
 -IsPrivate null `
 -EnableSubscribe null `
 -EnableApplySiteDesign null `
 -EnableOutsideSender null `
 -EnableHideGroupMembership null `
 -EnableClassification null `
 -EnableSensitivity null `
 -AllowConfigureLeasePeriod null `
 -ShowNotebookLink null `
 -ShowConversationsLink null `
 -ShowFilesLink null `
 -ShowTeamSiteLink null `
 -ShowPlannerLink null `
 -ShowYammerGroupLink null `
 -Classifications null `
 -Sensitivities null `
 -SiteDesigns null `
 -AddGroupMemberType null `
 -SelectedPolicies null `
 -SelectedLanguages null `
 -TeamsSettings null `
 -GroupNameConstructureSettings null `
 -GroupIdConstructureSettings null `
 -EnableInstallApp null `
 -EnableInstallPanel null `
 -TemplateSettings null `
 -DefaultPrimaryContact null `
 -DefaultSecondaryContact null `
 -DefaultOwners null `
 -DefaultMembers null `
 -DefaultPolicy null `
 -DefaultClassification null `
 -DefaultSensitivity null `
 -DefaultLanguage null `
 -DefaultSiteDesign null `
 -DefaultOwnersReal null `
 -DefaultMembersReal null `
 -DefaultPrimaryContactReal null `
 -DefaultSecondaryContactReal null `
 -MemberAssignBy null `
 -OwnerAssignBy null `
 -PrivacyAssignBy null `
 -SubscribeAssignBy null `
 -OutsideSenderAssignBy null `
 -ClassificationAssignBy null `
 -SensitivityAssignBy null `
 -LanguageAssignBy null `
 -SecondaryContactAssignBy null `
 -PrimaryContactAssignBy null `
 -EnableDynamicMembership null `
 -HideGroupMembershipAssignBy null `
 -PolicyAssignBy null `
 -SiteDesignAssignBy null `
 -HubSiteAssignBy null `
 -MultiGeoSetting null `
 -IsShowHubSiteSection null `
 -HubSiteSettings null `
 -HasImpernastionUsers null `
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
$CreateGroupService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

