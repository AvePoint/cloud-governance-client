# CloneTeam
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CloneTeamId** | **String** |  | [optional] 
**CloneTeamTitle** | **String** |  | [optional] 
**EnableCloneChannels** | **Boolean** |  | [optional] [default to $false]
**EnableCloneApps** | **Boolean** |  | [optional] [default to $false]
**EnableCloneTabs** | **Boolean** |  | [optional] [default to $false]
**EnableCloneMembers** | **Boolean** |  | [optional] [default to $false]
**EnableCloneTeamSetting** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CloneTeam = New-Cloud.Governance.ClientCloneTeam  -CloneTeamId null `
 -CloneTeamTitle null `
 -EnableCloneChannels null `
 -EnableCloneApps null `
 -EnableCloneTabs null `
 -EnableCloneMembers null `
 -EnableCloneTeamSetting null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CloneTeam | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

