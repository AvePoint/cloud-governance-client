# ChangeGroupSettingRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **String** |  | [optional] 
**GroupEmail** | **String** |  | [optional] 
**GroupName** | **String** |  | [optional] 
**OriginalGroupName** | **String** |  | [optional] 
**GroupDescription** | **String** |  | [optional] 
**OriginalGroupDescription** | **String** |  | [optional] 
**OriginalYammerGroupInfo** | **String** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**OriginalPrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**OriginalSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**GroupOwners** | [**GroupMembershipItem[]**](GroupMembershipItem.md) |  | [optional] 
**GroupMembers** | [**GroupMembershipItem[]**](GroupMembershipItem.md) |  | [optional] 
**IsDynamicMembership** | **Boolean** |  | [optional] 
**DynamicMembershipRules** | [**DynamicGroupRuleInfo[]**](DynamicGroupRuleInfo.md) |  | [optional] 
**EnabledSubscribe** | **Boolean** |  | [optional] 
**OriginalEnabledSubscribe** | **Boolean** |  | [optional] 
**EnabledOutsideSender** | **Boolean** |  | [optional] 
**OriginalEnabledOutsideSender** | **Boolean** |  | [optional] 
**HubSiteActionType** | [**ChangeHubsiteActionType**](ChangeHubsiteActionType.md) |  | [optional] 
**AssociateHubSiteId** | **String** |  | [optional] 
**AssociateHubSiteTitle** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**OriginalClassification** | **String** |  | [optional] 
**Sensitivity** | **String** |  | [optional] 
**OriginalSensitivity** | **String** |  | [optional] 
**EnableTeams** | **Boolean** |  | [optional] 
**OriginalEnableTeams** | **Boolean** |  | [optional] 
**GroupMetadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**OriginalGroupMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**ChangedDynamicGroupType** | [**AddGroupMemberType**](AddGroupMemberType.md) |  | [optional] 
**YammerGroupInfo** | **String** |  | [optional] 
**GroupObjectType** | [**GroupObjectType**](GroupObjectType.md) |  | [optional] 
**NetworkId** | **String** |  | [optional] 
**GroupObjectId** | **String** |  | [optional] 
**EnableTeamCollaboration** | **Boolean** |  | [optional] 
**Id** | **String** |  | [optional] 
**ServiceId** | **String** |  | [optional] 
**Department** | **String** |  | [optional] 
**Summary** | **String** |  | [optional] 
**NotesToApprovers** | **String** |  | [optional] 
**QuestionnaireId** | **String** |  | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**TicketNumber** | **Int32** |  | [optional] [readonly] 
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] [readonly] 
**TypeDescription** | **String** |  | [optional] [readonly] 
**Requester** | **String** |  | [optional] [readonly] 
**RequesterLoginName** | **String** |  | [optional] [readonly] 
**Status** | [**RequestStatus**](RequestStatus.md) |  | [optional] [readonly] 
**ProgressStatus** | **Int32** |  | [optional] [readonly] 
**ProgressStatusDescription** | **String** |  | [optional] [readonly] 
**SubmittedTime** | **System.DateTime** |  | [optional] [readonly] 
**LastUpdated** | **System.DateTime** |  | [optional] [readonly] 
**CreatedTime** | **System.DateTime** |  | [optional] [readonly] 
**AssignTo** | **String** |  | [optional] [readonly] 
**FullPath** | **String** |  | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ChangeGroupSettingRequest = New-Cloud.Governance.ClientChangeGroupSettingRequest  -GroupId null `
 -GroupEmail null `
 -GroupName null `
 -OriginalGroupName null `
 -GroupDescription null `
 -OriginalGroupDescription null `
 -OriginalYammerGroupInfo null `
 -PrimaryContact null `
 -OriginalPrimaryContact null `
 -SecondaryContact null `
 -OriginalSecondaryContact null `
 -GroupOwners null `
 -GroupMembers null `
 -IsDynamicMembership null `
 -DynamicMembershipRules null `
 -EnabledSubscribe null `
 -OriginalEnabledSubscribe null `
 -EnabledOutsideSender null `
 -OriginalEnabledOutsideSender null `
 -HubSiteActionType null `
 -AssociateHubSiteId null `
 -AssociateHubSiteTitle null `
 -Classification null `
 -OriginalClassification null `
 -Sensitivity null `
 -OriginalSensitivity null `
 -EnableTeams null `
 -OriginalEnableTeams null `
 -GroupMetadatas null `
 -OriginalGroupMetadata null `
 -ChangedDynamicGroupType null `
 -YammerGroupInfo null `
 -GroupObjectType null `
 -NetworkId null `
 -GroupObjectId null `
 -EnableTeamCollaboration null `
 -Id null `
 -ServiceId null `
 -Department null `
 -Summary null `
 -NotesToApprovers null `
 -QuestionnaireId null `
 -Metadatas null `
 -TicketNumber null `
 -Type null `
 -TypeDescription null `
 -Requester null `
 -RequesterLoginName null `
 -Status null `
 -ProgressStatus null `
 -ProgressStatusDescription null `
 -SubmittedTime null `
 -LastUpdated null `
 -CreatedTime null `
 -AssignTo null `
 -FullPath null
```

- Convert the resource to JSON
```powershell
$ChangeGroupSettingRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

