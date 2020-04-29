# ServiceTeamsSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemberPermissionsAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**GuestPermissionsAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**MentionsAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**FunStuffAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**AllowMembersCreateUpdateChannels** | **Boolean** |  | [optional] [default to null]
**AllowMembersCreatePrivateChannels** | **Boolean** |  | [optional] [default to null]
**AllowMemberDeleteRestoreChannels** | **Boolean** |  | [optional] [default to null]
**AllowMembersAddRemoveApps** | **Boolean** |  | [optional] [default to null]
**AllowMembersCreateUpdateRemoveTabs** | **Boolean** |  | [optional] [default to null]
**AllowMembersCreateUpdateRemoveConnections** | **Boolean** |  | [optional] [default to null]
**AllowMembersDeleteMessages** | **Boolean** |  | [optional] [default to null]
**AllowMembersEditMessages** | **Boolean** |  | [optional] [default to null]
**AllowGuestsCreateUpdateChannels** | **Boolean** |  | [optional] [default to null]
**AllowGuestsDeleteChannels** | **Boolean** |  | [optional] [default to null]
**AllowMentionsTeam** | **Boolean** |  | [optional] [default to null]
**AllowMentionsChannel** | **Boolean** |  | [optional] [default to null]
**EnableGiphy** | **Boolean** |  | [optional] [default to null]
**EnableStickersAndMemes** | **Boolean** |  | [optional] [default to null]
**EnableCustomMemes** | **Boolean** |  | [optional] [default to null]
**GiphyRatingType** | [**GiphyRatingType**](GiphyRatingType.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientServiceTeamsSettings  -MemberPermissionsAssignBy null `
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

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

