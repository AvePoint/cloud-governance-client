# CreateGroupService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupType** | [**CreateGroupType**](CreateGroupType.md) |  | [optional] 
**TenantId** | **String** |  | [optional] 
**NetworkId** | **String** |  | [optional] 
**EnableTeams** | **Boolean** |  | [optional] [default to $false]
**IsPrivate** | **Boolean** |  | [optional] [default to $false]
**EnableSubscribe** | **Boolean** |  | [optional] [default to $false]
**EnableApplySiteDesign** | **Boolean** |  | [optional] [default to $false]
**EnableOutsideSender** | **Boolean** |  | [optional] [default to $false]
**EnableHideGroupMembership** | **Boolean** |  | [optional] [default to $false]
**EnableClassification** | **Boolean** |  | [optional] [default to $false]
**PreventDuplicateName** | **Boolean** |  | [optional] [default to $false]
**EnableSensitivity** | **Boolean** |  | [optional] [default to $false]
**AllSensitivities** | [**StringModel[]**](StringModel.md) |  | [optional] 
**AllowConfigureLeasePeriod** | **Boolean** |  | [optional] [default to $false]
**ShowNotebookLink** | **Boolean** |  | [optional] [default to $false]
**ShowConversationsLink** | **Boolean** |  | [optional] [default to $false]
**ShowFilesLink** | **Boolean** |  | [optional] [default to $false]
**ShowTeamSiteLink** | **Boolean** |  | [optional] [default to $false]
**ShowPlannerLink** | **Boolean** |  | [optional] [default to $false]
**ShowYammerGroupLink** | **Boolean** |  | [optional] [default to $false]
**ShowTeamLink** | **Boolean** |  | [optional] [default to $false]
**ShowTeamUrl** | **Boolean** |  | [optional] [default to $false]
**Classifications** | **String[]** |  | [optional] 
**Sensitivities** | [**StringModel[]**](StringModel.md) |  | [optional] 
**SiteDesigns** | [**GuidModel[]**](GuidModel.md) |  | [optional] 
**AddGroupMemberType** | [**AddGroupMemberType**](AddGroupMemberType.md) |  | [optional] 
**SelectedPolicies** | [**BriefGroupPolicy[]**](BriefGroupPolicy.md) |  | [optional] 
**SelectedLanguages** | [**StringModel[]**](StringModel.md) |  | [optional] 
**TeamsSettings** | [**CreateGroupServiceTeamsSettings**](CreateGroupServiceTeamsSettings.md) |  | [optional] 
**GroupNameConstructureSettings** | [**CreateGroupServiceGroupNameConstructureSettings**](CreateGroupServiceGroupNameConstructureSettings.md) |  | [optional] 
**GroupIdConstructureSettings** | [**CreateGroupServiceGroupIdConstructureSettings**](CreateGroupServiceGroupIdConstructureSettings.md) |  | [optional] 
**EnableInstallApp** | **Boolean** |  | [optional] [default to $false]
**EnableInstallPanel** | **Boolean** |  | [optional] [default to $false]
**TemplateSettings** | [**CreateGroupServiceTemplateSettings**](CreateGroupServiceTemplateSettings.md) |  | [optional] 
**DefaultPrimaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**DefaultSecondaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**DefaultOwners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**DefaultMembers** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**DisableAddRemoveDynamicMembershipRules** | **Boolean** |  | [optional] [default to $false]
**EnableRestrictDynamicMembershipRules** | **Boolean** |  | [optional] [default to $false]
**DynamicMembershipRules** | [**DynamicGroupRuleInfo[]**](DynamicGroupRuleInfo.md) |  | [optional] 
**DefaultPolicy** | **String** |  | [optional] 
**DefaultClassification** | **String** |  | [optional] 
**DefaultSensitivity** | **String** |  | [optional] 
**DefaultLanguage** | **String** |  | [optional] 
**DefaultSiteDesign** | **String** |  | [optional] 
**DefaultOwnersReal** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**DefaultMembersReal** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**DefaultPrimaryContactReal** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**DefaultSecondaryContactReal** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
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
**EnableDynamicMembership** | **Boolean** |  | [optional] [default to $false]
**HideGroupMembershipAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**PolicyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SiteDesignAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**HubSiteAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**TimeZoneAssignBy** | [**AssignBy**](AssignBy.md) | TimeZoneAssignBy | [optional] 
**LocaleAssignBy** | [**AssignBy**](AssignBy.md) | LocaleAssignBy | [optional] 
**MultiGeoSetting** | [**CreateGroupServiceMultiGeoSetting**](CreateGroupServiceMultiGeoSetting.md) |  | [optional] 
**IsShowHubSiteSection** | **Boolean** |  | [optional] [readonly] [default to $false]
**HubSiteSettings** | [**CreateGroupServiceHubSiteSettings**](CreateGroupServiceHubSiteSettings.md) |  | [optional] 
**TimeZoneSettings** | [**ChangeGroupSettingRequestTimeZoneSettings**](ChangeGroupSettingRequestTimeZoneSettings.md) |  | [optional] 
**LocaleSettings** | [**ChangeGroupSettingRequestLocaleSettings**](ChangeGroupSettingRequestLocaleSettings.md) |  | [optional] 
**HasImpernastionUsers** | **Boolean** |  | [optional] [default to $false]
**PeoplePickerFilterProfileId** | **String** |  | [optional] 
**RequestTemplate** | [**CreateGroupServiceRequestTemplate**](CreateGroupServiceRequestTemplate.md) |  | [optional] 
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
 -PreventDuplicateName null `
 -EnableSensitivity null `
 -AllSensitivities null `
 -AllowConfigureLeasePeriod null `
 -ShowNotebookLink null `
 -ShowConversationsLink null `
 -ShowFilesLink null `
 -ShowTeamSiteLink null `
 -ShowPlannerLink null `
 -ShowYammerGroupLink null `
 -ShowTeamLink null `
 -ShowTeamUrl null `
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
 -DisableAddRemoveDynamicMembershipRules null `
 -EnableRestrictDynamicMembershipRules null `
 -DynamicMembershipRules null `
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
 -TimeZoneAssignBy null `
 -LocaleAssignBy null `
 -MultiGeoSetting null `
 -IsShowHubSiteSection null `
 -HubSiteSettings null `
 -TimeZoneSettings null `
 -LocaleSettings null `
 -HasImpernastionUsers null `
 -PeoplePickerFilterProfileId null `
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
$CreateGroupService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

