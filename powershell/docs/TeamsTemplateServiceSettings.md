# TeamsTemplateServiceSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableCreateTeamFromScratch** | **Boolean** |  | [optional] 
**EnableCreateTeamFromExistTeam** | **Boolean** |  | [optional] 
**EnableCreateTeamFromIT** | **Boolean** |  | [optional] 
**EnableCreateTeamFromOwned** | **Boolean** |  | [optional] 
**TemplateTeams** | [**GuidModel[]**](GuidModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TeamsTemplateServiceSettings = New-Cloud.Governance.ClientTeamsTemplateServiceSettings  -EnableCreateTeamFromScratch null `
 -EnableCreateTeamFromExistTeam null `
 -EnableCreateTeamFromIT null `
 -EnableCreateTeamFromOwned null `
 -TemplateTeams null
```

- Convert the resource to JSON
```powershell
$TeamsTemplateServiceSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

