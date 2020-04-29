# CreateGroupService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**EnableTeams** | **Boolean** |  | [optional] [default to null]
**IsPrivate** | **Boolean** |  | [optional] [default to null]
**EnableSubscribe** | **Boolean** |  | [optional] [default to null]
**EnableApplySiteDesign** | **Boolean** |  | [optional] [default to null]
**EnableOutsideSender** | **Boolean** |  | [optional] [default to null]
**EnableHideGroupMembership** | **Boolean** |  | [optional] [default to null]
**EnableClassification** | **Boolean** |  | [optional] [default to null]
**AllowConfigureLeasePeriod** | **Boolean** |  | [optional] [default to null]
**ShowNotebookLink** | **Boolean** |  | [optional] [default to null]
**ShowConversationsLink** | **Boolean** |  | [optional] [default to null]
**ShowFilesLink** | **Boolean** |  | [optional] [default to null]
**ShowTeamSiteLink** | **Boolean** |  | [optional] [default to null]
**ShowPlannerLink** | **Boolean** |  | [optional] [default to null]
**Classifications** | **String[]** |  | [optional] [default to null]
**SiteDesigns** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]
**AddGroupMemberType** | [**AddGroupMemberType**](AddGroupMemberType.md) |  | [optional] [default to null]
**SelectedPolicies** | [**BriefGroupPolicy[]**](BriefGroupPolicy.md) |  | [optional] [default to null]
**SelectedLanguages** | [**StringModel[]**](StringModel.md) |  | [optional] [default to null]
**TeamsSettings** | [**ServiceTeamsSettings**](ServiceTeamsSettings.md) |  | [optional] [default to null]
**GroupNameConstructureSettings** | [**GroupNameConstructureSettings**](GroupNameConstructureSettings.md) |  | [optional] [default to null]
**GroupIdConstructureSettings** | [**GroupIdConstructureSettings**](GroupIdConstructureSettings.md) |  | [optional] [default to null]
**EnableInstallApp** | **Boolean** |  | [optional] [default to null]
**EnableInstallPanel** | **Boolean** |  | [optional] [default to null]
**TemplateSettings** | [**TeamsTemplateServiceSettings**](TeamsTemplateServiceSettings.md) |  | [optional] [default to null]
**DefaultPrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**DefaultSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**DefaultOwners** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**DefaultMembers** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**DefaultPolicy** | [**UUID**](UUID.md) |  | [optional] [default to null]
**DefaultClassification** | **String** |  | [optional] [default to null]
**DefaultLanguage** | **String** |  | [optional] [default to null]
**DefaultSiteDesign** | [**UUID**](UUID.md) |  | [optional] [default to null]
**DefaultOwnersReal** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**DefaultMembersReal** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**MemberAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**OwnerAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**PrivacyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**SubscribeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**OutsideSenderAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**ClassificationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**LanguageAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**SecondaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**PrimaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**EnableDynamicMembership** | **Boolean** |  | [optional] [default to null]
**HideGroupMembershipAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**PolicyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**SiteDesignAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**HubSiteAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**MultiGeoSetting** | [**MultiGeoSetting**](MultiGeoSetting.md) |  | [optional] [default to null]
**IsShowHubSiteSection** | **Boolean** |  | [optional] [readonly] [default to null]
**HubSiteSettings** | [**HubSiteSettings**](HubSiteSettings.md) |  | [optional] [default to null]
**HasImpernastionUsers** | **Boolean** |  | [optional] [default to null]
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
New-Cloud.Governance.ClientCreateGroupService  -TenantId null `
 -EnableTeams null `
 -IsPrivate null `
 -EnableSubscribe null `
 -EnableApplySiteDesign null `
 -EnableOutsideSender null `
 -EnableHideGroupMembership null `
 -EnableClassification null `
 -AllowConfigureLeasePeriod null `
 -ShowNotebookLink null `
 -ShowConversationsLink null `
 -ShowFilesLink null `
 -ShowTeamSiteLink null `
 -ShowPlannerLink null `
 -Classifications null `
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
 -DefaultLanguage null `
 -DefaultSiteDesign null `
 -DefaultOwnersReal null `
 -DefaultMembersReal null `
 -MemberAssignBy null `
 -OwnerAssignBy null `
 -PrivacyAssignBy null `
 -SubscribeAssignBy null `
 -OutsideSenderAssignBy null `
 -ClassificationAssignBy null `
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

