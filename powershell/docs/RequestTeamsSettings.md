# RequestTeamsSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowMembersCreateUpdateChannels** | **Boolean** |  | [optional] 
**AllowMembersCreatePrivateChannels** | **Boolean** |  | [optional] 
**AllowMemberDeleteRestoreChannels** | **Boolean** |  | [optional] 
**AllowMembersAddRemoveApps** | **Boolean** |  | [optional] 
**AllowMembersCreateUpdateRemoveTabs** | **Boolean** |  | [optional] 
**AllowMembersCreateUpdateRemoveConnections** | **Boolean** |  | [optional] 
**AllowMembersDeleteMessages** | **Boolean** |  | [optional] 
**AllowMembersEditMessages** | **Boolean** |  | [optional] 
**AllowGuestsCreateUpdateChannels** | **Boolean** |  | [optional] 
**AllowGuestsDeleteChannels** | **Boolean** |  | [optional] 
**AllowMentionsTeam** | **Boolean** |  | [optional] 
**AllowMentionsChannel** | **Boolean** |  | [optional] 
**EnableGiphy** | **Boolean** |  | [optional] 
**EnableStickersAndMemes** | **Boolean** |  | [optional] 
**EnableCustomMemes** | **Boolean** |  | [optional] 
**GiphyRatingType** | [**GiphyRatingType**](GiphyRatingType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RequestTeamsSettings = New-Cloud.Governance.ClientRequestTeamsSettings  -AllowMembersCreateUpdateChannels null `
 -AllowMembersCreatePrivateChannels null `
 -AllowMemberDeleteRestoreChannels null `
 -AllowMembersAddRemoveApps null `
 -AllowMembersCreateUpdateRemoveTabs null `
 -AllowMembersCreateUpdateRemoveConnections null `
 -AllowMembersDeleteMessages null `
 -AllowMembersEditMessages null `
 -AllowGuestsCreateUpdateChannels null `
 -AllowGuestsDeleteChannels null `
 -AllowMentionsTeam null `
 -AllowMentionsChannel null `
 -EnableGiphy null `
 -EnableStickersAndMemes null `
 -EnableCustomMemes null `
 -GiphyRatingType null
```

- Convert the resource to JSON
```powershell
$RequestTeamsSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

