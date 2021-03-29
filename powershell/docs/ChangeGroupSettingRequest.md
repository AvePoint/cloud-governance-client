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
**IsDynamicMembership** | **Boolean** |  | [optional] [default to $false]
**DynamicMembershipRules** | [**DynamicGroupRuleInfo[]**](DynamicGroupRuleInfo.md) |  | [optional] 
**EnabledSubscribe** | **Boolean** |  | [optional] [default to $false]
**OriginalEnabledSubscribe** | **Boolean** |  | [optional] [default to $false]
**EnabledOutsideSender** | **Boolean** |  | [optional] [default to $false]
**OriginalEnabledOutsideSender** | **Boolean** |  | [optional] [default to $false]
**HubSiteActionType** | [**ChangeHubsiteActionType**](ChangeHubsiteActionType.md) |  | [optional] 
**AssociateHubSiteId** | **String** |  | [optional] 
**AssociateHubSiteTitle** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**OriginalClassification** | **String** |  | [optional] 
**Sensitivity** | **String** |  | [optional] 
**OriginalSensitivity** | **String** |  | [optional] 
**EnableTeams** | **Boolean** |  | [optional] [default to $false]
**OriginalEnableTeams** | **Boolean** |  | [optional] [default to $false]
**GroupMetadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**OriginalGroupMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**ChangedDynamicGroupType** | [**AddGroupMemberType**](AddGroupMemberType.md) |  | [optional] 
**YammerGroupInfo** | **String** |  | [optional] 
**GroupObjectType** | [**GroupObjectType**](GroupObjectType.md) |  | [optional] 
**NetworkId** | **String** |  | [optional] 
**GroupObjectId** | **String** |  | [optional] 
**EnableTeamCollaboration** | **Boolean** |  | [optional] [default to $false]
**Id** | **String** | Id of request. | [optional] 
**ServiceId** | **String** | Id of service. | [optional] 
**Department** | **String** | Department of requester. | [optional] 
**Summary** | **String** | Summary of request. | [optional] 
**NotesToApprovers** | **String** | Notes to approvers. | [optional] 
**QuestionnaireId** | **String** | Id of questionnaire | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) | Metadata of request. | [optional] 
**TicketNumber** | **Int32** | Ticket number of request. | [optional] [readonly] [default to 0]
**Type** | [**ServiceType**](ServiceType.md) | Service type of request. | [optional] [readonly] 
**TypeDescription** | **String** | Service type description of request. | [optional] [readonly] 
**Requester** | **String** | Requester display name. | [optional] [readonly] 
**RequesterLoginName** | **String** | Requester login name. | [optional] [readonly] 
**Status** | [**RequestStatus**](RequestStatus.md) | Status of request. | [optional] [readonly] 
**ProgressStatus** | **Int32** | Progress status of request. | [optional] [readonly] [default to 0]
**ProgressStatusDescription** | **String** | Progress status description of request. | [optional] [readonly] 
**SubmittedTime** | **System.DateTime** | Submitted time of request. | [optional] [readonly] 
**LastUpdated** | **System.DateTime** | Last updated time of request. | [optional] [readonly] 
**CreatedTime** | **System.DateTime** | Created time of request. | [optional] [readonly] 
**AssignTo** | **String** | Task assignee of request. | [optional] [readonly] 
**FullPath** | **String** | Object full path of request. | [optional] [readonly] 

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

