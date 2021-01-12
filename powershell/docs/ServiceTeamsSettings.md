# ServiceTeamsSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemberPermissionsAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**GuestPermissionsAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**MentionsAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**FunStuffAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
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

