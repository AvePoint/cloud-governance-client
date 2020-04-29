# TeamsTemplateServiceSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableCreateTeamFromScratch** | **Boolean** |  | [optional] [default to null]
**EnableCreateTeamFromExistTeam** | **Boolean** |  | [optional] [default to null]
**EnableCreateTeamFromIT** | **Boolean** |  | [optional] [default to null]
**EnableCreateTeamFromOwned** | **Boolean** |  | [optional] [default to null]
**TemplateTeams** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientTeamsTemplateServiceSettings  -EnableCreateTeamFromScratch null `
 -EnableCreateTeamFromExistTeam null `
 -EnableCreateTeamFromIT null `
 -EnableCreateTeamFromOwned null `
 -TemplateTeams null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

