# TeamsTemplateSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableCreateTeamFromScratch** | **Boolean** |  | [optional] 
**EnableCreateTeamFromExistTeam** | **Boolean** |  | [optional] 
**SelectedTemplate** | [**GuidModel**](GuidModel.md) |  | [optional] 
**EnableCloneChannels** | **Boolean** |  | [optional] 
**EnableCloneApps** | **Boolean** |  | [optional] 
**EnableCloneTabs** | **Boolean** |  | [optional] 
**EnableCloneMembers** | **Boolean** |  | [optional] 
**EnableCloneTeamSetting** | **Boolean** |  | [optional] 
**EnableCloneTeamPrivacy** | **Boolean** |  | [optional] 
**EnableCloneTeamClassification** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TeamsTemplateSettings = New-Cloud.Governance.ClientTeamsTemplateSettings  -EnableCreateTeamFromScratch null `
 -EnableCreateTeamFromExistTeam null `
 -SelectedTemplate null `
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

