# TeamsTemplateSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableCreateTeamFromScratch** | **Boolean** |  | [optional] [default to null]
**EnableCreateTeamFromExistTeam** | **Boolean** |  | [optional] [default to null]
**SelectedTemplate** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**EnableCloneChannels** | **Boolean** |  | [optional] [default to null]
**EnableCloneApps** | **Boolean** |  | [optional] [default to null]
**EnableCloneTabs** | **Boolean** |  | [optional] [default to null]
**EnableCloneMembers** | **Boolean** |  | [optional] [default to null]
**EnableCloneTeamSetting** | **Boolean** |  | [optional] [default to null]
**EnableCloneTeamPrivacy** | **Boolean** |  | [optional] [default to null]
**EnableCloneTeamClassification** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientTeamsTemplateSettings  -EnableCreateTeamFromScratch null `
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

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

