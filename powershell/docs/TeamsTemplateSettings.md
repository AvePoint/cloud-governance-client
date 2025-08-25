# TeamsTemplateSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableCreateTeamFromScratch** | **Boolean** | Whether to allow business users to create a team from scratch. | [optional] [default to $false]
**EnableCreateTeamFromExistTeam** | **Boolean** | Whether to allow business users to create a team from an existing team. | [optional] [default to $false]
**EnableCreateTeamFromTeamTemplate** | **Boolean** | Whether to allow business users to create a team using a team template. | [optional] [default to $false]
**SelectedTemplate** | [**TeamsTemplateSettingsSelectedTemplate**](TeamsTemplateSettingsSelectedTemplate.md) |  | [optional] 
**SelectedMSTemplate** | [**TeamsTemplateSettingsSelectedMSTemplate**](TeamsTemplateSettingsSelectedMSTemplate.md) |  | [optional] 
**TeamTemplates** | [**TextModel[]**](TextModel.md) | All team templates | [optional] 
**EnableCloneChannels** | **Boolean** | Set whether copying channels from the team is enabled. | [optional] [default to $false]
**EnableCloneApps** | **Boolean** | Set whether copying apps from the team is enabled. | [optional] [default to $false]
**EnableCloneTabs** | **Boolean** | Set whether copying tabs from the team is enabled. | [optional] [default to $false]
**EnableCloneMembers** | **Boolean** | Set whether copying members from the team is enabled. | [optional] [default to $false]
**EnableCloneTeamSetting** | **Boolean** | Set whether copying team settings from the team is enabled. | [optional] [default to $false]
**EnableCloneTeamPrivacy** | **Boolean** | Whether to enable the team privacy. (Currently not supported) | [optional] [default to $false]
**EnableCloneTeamClassification** | **Boolean** | Whether to enable the team classification. (Currently not supported) | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$TeamsTemplateSettings = New-Cloud.Governance.ClientTeamsTemplateSettings  -EnableCreateTeamFromScratch null `
 -EnableCreateTeamFromExistTeam null `
 -EnableCreateTeamFromTeamTemplate null `
 -SelectedTemplate null `
 -SelectedMSTemplate null `
 -TeamTemplates null `
 -EnableCloneChannels null `
 -EnableCloneApps null `
 -EnableCloneTabs null `
 -EnableCloneMembers null `
 -EnableCloneTeamSetting null `
 -EnableCloneTeamPrivacy null `
 -EnableCloneTeamClassification null
```

- Convert the resource to JSON
```powershell
$TeamsTemplateSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

