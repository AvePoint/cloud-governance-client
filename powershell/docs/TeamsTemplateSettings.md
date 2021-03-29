# TeamsTemplateSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableCreateTeamFromScratch** | **Boolean** |  | [optional] [default to $false]
**EnableCreateTeamFromExistTeam** | **Boolean** |  | [optional] [default to $false]
**EnableCreateTeamFromTeamTemplate** | **Boolean** |  | [optional] [default to $false]
**SelectedTemplate** | [**GuidModel**](GuidModel.md) |  | [optional] 
**SelectedMSTemplate** | [**StringModel**](StringModel.md) |  | [optional] 
**TeamTemplates** | [**TextModel[]**](TextModel.md) |  | [optional] 
**EnableCloneChannels** | **Boolean** |  | [optional] [default to $false]
**EnableCloneApps** | **Boolean** |  | [optional] [default to $false]
**EnableCloneTabs** | **Boolean** |  | [optional] [default to $false]
**EnableCloneMembers** | **Boolean** |  | [optional] [default to $false]
**EnableCloneTeamSetting** | **Boolean** |  | [optional] [default to $false]
**EnableCloneTeamPrivacy** | **Boolean** |  | [optional] [default to $false]
**EnableCloneTeamClassification** | **Boolean** |  | [optional] [default to $false]

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

