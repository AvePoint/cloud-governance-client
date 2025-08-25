# CreateGroupServiceTemplateSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableCreateTeamFromScratch** | **Boolean** |  | [optional] [default to $false]
**EnableCreateTeamFromExistTeam** | **Boolean** |  | [optional] [default to $false]
**EnableCreateTeamFromTeamTemplate** | **Boolean** |  | [optional] [default to $false]
**EnableCreateTeamFromIT** | **Boolean** |  | [optional] [default to $false]
**EnableCreateTeamFromOwned** | **Boolean** |  | [optional] [default to $false]
**EnableCloneChannels** | **Boolean** |  | [optional] [default to $false]
**EnableCloneApps** | **Boolean** |  | [optional] [default to $false]
**EnableCloneTabs** | **Boolean** |  | [optional] [default to $false]
**EnableCloneMembers** | **Boolean** |  | [optional] [default to $false]
**EnableCloneTeamSetting** | **Boolean** |  | [optional] [default to $false]
**EnableCloneTeamPrivacy** | **Boolean** |  | [optional] [default to $false]
**EnableCloneTeamClassification** | **Boolean** |  | [optional] [default to $false]
**CloneTeamTemplateSettingValueAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**TemplateTeams** | [**GuidModel[]**](GuidModel.md) |  | [optional] 
**TeamTemplates** | [**TextModel[]**](TextModel.md) |  | [optional] 
**Hidden** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$CreateGroupServiceTemplateSettings = New-Cloud.Governance.ClientCreateGroupServiceTemplateSettings  -EnableCreateTeamFromScratch null `
 -EnableCreateTeamFromExistTeam null `
 -EnableCreateTeamFromTeamTemplate null `
 -EnableCreateTeamFromIT null `
 -EnableCreateTeamFromOwned null `
 -EnableCloneChannels null `
 -EnableCloneApps null `
 -EnableCloneTabs null `
 -EnableCloneMembers null `
 -EnableCloneTeamSetting null `
 -EnableCloneTeamPrivacy null `
 -EnableCloneTeamClassification null `
 -CloneTeamTemplateSettingValueAssignBy null `
 -TemplateTeams null `
 -TeamTemplates null `
 -Hidden null
```

- Convert the resource to JSON
```powershell
$CreateGroupServiceTemplateSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

