# ServiceTeamsSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemberPermissionsAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**GuestPermissionsAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**MentionsAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**FunStuffAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**AllowMembersCreateUpdateChannels** | **Boolean** | Whether to allow team members to create and update channels. | [optional] [default to $false]
**AllowMembersCreatePrivateChannels** | **Boolean** | Whether to allow members to create private channels. | [optional] [default to $false]
**AllowMemberDeleteRestoreChannels** | **Boolean** | Whether to allow members to delete and restore channels. | [optional] [default to $false]
**AllowMembersAddRemoveApps** | **Boolean** | Whether to allow members to add and remove apps. | [optional] [default to $false]
**AllowMembersCreateUpdateRemoveTabs** | **Boolean** | Whether to allow members to create, update, and remove tabs. | [optional] [default to $false]
**AllowMembersCreateUpdateRemoveConnections** | **Boolean** | Whether to allow members to create, update, and remove connectors. | [optional] [default to $false]
**AllowMembersDeleteMessages** | **Boolean** | Whether to allow members to delete their messages. | [optional] [default to $false]
**AllowMembersEditMessages** | **Boolean** | Whether to allow members to edit their messages. | [optional] [default to $false]
**AllowGuestsCreateUpdateChannels** | **Boolean** | Whether to allow guests to create and update channels. | [optional] [default to $false]
**AllowGuestsDeleteChannels** | **Boolean** | Whether to allow guests to delete channels. | [optional] [default to $false]
**AllowMentionsTeam** | **Boolean** | Whether to show members the option to @team or @[team name] (this will send a notification to everyone on the team). | [optional] [default to $false]
**AllowMentionsChannel** | **Boolean** | Whether to show members the option to @channel or @[channel name] (this will send a notification to everyone who has favorited the channel being mentioned). | [optional] [default to $false]
**EnableGiphy** | **Boolean** | Whether to enable giphy for the team. | [optional] [default to $false]
**EnableStickersAndMemes** | **Boolean** | Whether to enable stickers and memes. | [optional] [default to $false]
**EnableCustomMemes** | **Boolean** | Whether to allow memes to be uploaded. | [optional] [default to $false]
**GiphyRatingType** | [**GiphyRatingType**](GiphyRatingType.md) | Set the gihpy type settings. | [optional] 

## Examples

- Prepare the resource
```powershell
$ServiceTeamsSettings = New-Cloud.Governance.ClientServiceTeamsSettings  -MemberPermissionsAssignBy null `
 -GuestPermissionsAssignBy null `
 -MentionsAssignBy null `
 -FunStuffAssignBy null `
 -AllowMembersCreateUpdateChannels null `
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
$ServiceTeamsSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

