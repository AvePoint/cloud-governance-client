# RequestTeamsSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowMembersCreateUpdateChannels** | **Boolean** |  | [optional] [default to $false]
**AllowMembersCreatePrivateChannels** | **Boolean** |  | [optional] [default to $false]
**AllowMemberDeleteRestoreChannels** | **Boolean** |  | [optional] [default to $false]
**AllowMembersAddRemoveApps** | **Boolean** |  | [optional] [default to $false]
**AllowMembersCreateUpdateRemoveTabs** | **Boolean** |  | [optional] [default to $false]
**AllowMembersCreateUpdateRemoveConnections** | **Boolean** |  | [optional] [default to $false]
**AllowMembersDeleteMessages** | **Boolean** |  | [optional] [default to $false]
**AllowMembersEditMessages** | **Boolean** |  | [optional] [default to $false]
**AllowGuestsCreateUpdateChannels** | **Boolean** |  | [optional] [default to $false]
**AllowGuestsDeleteChannels** | **Boolean** |  | [optional] [default to $false]
**AllowMentionsTeam** | **Boolean** |  | [optional] [default to $false]
**AllowMentionsChannel** | **Boolean** |  | [optional] [default to $false]
**EnableGiphy** | **Boolean** |  | [optional] [default to $false]
**EnableStickersAndMemes** | **Boolean** |  | [optional] [default to $false]
**EnableCustomMemes** | **Boolean** |  | [optional] [default to $false]
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

