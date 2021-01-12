# ChangeGroupSettingCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**GroupId** | **String** |  | [optional] 
**GroupName** | **String** |  | [optional] 
**GroupEmail** | **String** |  | [optional] 
**GroupDescription** | **String** |  | [optional] 
**IsEnableSubscribeMembers** | **Boolean** |  | [optional] 
**IsEnableOutsideSender** | **Boolean** |  | [optional] 
**Classification** | **String** |  | [optional] 
**IsTeamsEnabled** | **Boolean** |  | [optional] 
**EnableManageGroupSharing** | **Boolean** |  | [optional] 
**EnableInviteAuthorizedGuestUser** | **Boolean** |  | [optional] 
**EnableInviteGuestUser** | **Boolean** |  | [optional] 
**EnableDynamicMembership** | **Boolean** |  | [optional] 
**EnableTeamCollaboration** | **Boolean** |  | [optional] 
**IsHubSite** | **Boolean** |  | [optional] 
**AssociatedHubSiteId** | **String** |  | [optional] 
**DynamicMembershipRules** | [**DynamicGroupRuleInfo[]**](DynamicGroupRuleInfo.md) |  | [optional] 
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**EnableChangeMembershipType** | **Boolean** |  | [optional] 
**YammerGroupInfo** | **String** |  | [optional] 
**GroupObjectType** | [**GroupObjectType**](GroupObjectType.md) |  | [optional] 
**NetworkId** | **String** |  | [optional] 
**GroupObjectId** | **String** |  | [optional] 
**IsValid** | **Boolean** |  | [optional] 
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeGroupSettingCheckResult = New-Cloud.Governance.ClientChangeGroupSettingCheckResult  -PrimaryContact null `
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
 -EnableTeamCollaboration null `
 -IsHubSite null `
 -AssociatedHubSiteId null `
 -DynamicMembershipRules null `
 -Metadatas null `
 -EnableChangeMembershipType null `
 -YammerGroupInfo null `
 -GroupObjectType null `
 -NetworkId null `
 -GroupObjectId null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeGroupSettingCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

