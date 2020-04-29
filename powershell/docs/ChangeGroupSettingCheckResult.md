# ChangeGroupSettingCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**GroupId** | **String** |  | [optional] [default to null]
**GroupName** | **String** |  | [optional] [default to null]
**GroupEmail** | **String** |  | [optional] [default to null]
**GroupDescription** | **String** |  | [optional] [default to null]
**IsEnableSubscribeMembers** | **Boolean** |  | [optional] [default to null]
**IsEnableOutsideSender** | **Boolean** |  | [optional] [default to null]
**Classification** | **String** |  | [optional] [default to null]
**IsTeamsEnabled** | **Boolean** |  | [optional] [default to null]
**EnableManageGroupSharing** | **Boolean** |  | [optional] [default to null]
**EnableInviteAuthorizedGuestUser** | **Boolean** |  | [optional] [default to null]
**EnableInviteGuestUser** | **Boolean** |  | [optional] [default to null]
**EnableDynamicMembership** | **Boolean** |  | [optional] [default to null]
**IsHubSite** | **Boolean** |  | [optional] [default to null]
**AssociatedHubSiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**DynamicMembershipRules** | [**DynamicGroupRuleInfo[]**](DynamicGroupRuleInfo.md) |  | [optional] [default to null]
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] [default to null]
**IsValid** | **Boolean** |  | [optional] [readonly] [default to null]
**ErrorMessage** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangeGroupSettingCheckResult  -PrimaryContact null `
 -SecondaryContact null `
 -GroupId null `
 -GroupName null `
 -GroupEmail null `
 -GroupDescription null `
 -IsEnableSubscribeMembers null `
 -IsEnableOutsideSender null `
 -Classification null `
 -IsTeamsEnabled null `
 -EnableManageGroupSharing null `
 -EnableInviteAuthorizedGuestUser null `
 -EnableInviteGuestUser null `
 -EnableDynamicMembership null `
 -IsHubSite null `
 -AssociatedHubSiteId null `
 -DynamicMembershipRules null `
 -Metadatas null `
 -IsValid null `
 -ErrorMessage null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

