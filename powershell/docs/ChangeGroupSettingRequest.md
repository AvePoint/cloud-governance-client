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
**PrimaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**OriginalPrimaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**SecondaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**OriginalSecondaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
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
**TimeZoneSettings** | [**ChangeGroupSettingRequestTimeZoneSettings**](ChangeGroupSettingRequestTimeZoneSettings.md) |  | [optional] 
**OriginalTimeZoneSettings** | [**ChangeGroupSettingRequestOriginalTimeZoneSettings**](ChangeGroupSettingRequestOriginalTimeZoneSettings.md) |  | [optional] 
**LocaleSettings** | [**ChangeGroupSettingRequestLocaleSettings**](ChangeGroupSettingRequestLocaleSettings.md) |  | [optional] 
**OriginalLocaleSettings** | [**ChangeGroupSettingRequestOriginalLocaleSettings**](ChangeGroupSettingRequestOriginalLocaleSettings.md) |  | [optional] 
**Id** | **String** | Id of request. | [optional] 
**ServiceId** | **String** | Id of service. | [optional] 
**Summary** | **String** | Summary of request. | [optional] 
**NotesToApprovers** | **String** | Notes to approvers. | [optional] 
**QuestionnaireId** | **String** | Id of questionnaire | [optional] 
**QuestionnaireResponse** | [**QuestionAnswerResponse[]**](QuestionAnswerResponse.md) | Questionnaire question and answer of request. | [optional] 
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
**HasSubRequest** | **Boolean** | HasSubRequest | [optional] [default to $false]
**IsEnabledPassback** | **Boolean** |  | [optional] [default to $false]
**RequestResourceType** | [**RequestResourceType**](RequestResourceType.md) | RequestResourceType | [optional] 
**ModifiedBy** | **String** | ModifiedBy | [optional] 
**ModifiedByDisplayName** | **String** | ModifiedByDisplayName | [optional] 
**ModifiedDate** | **System.DateTime** | ModifiedDate | [optional] 
**AssignTo** | **String** | Task assignee of request. | [optional] [readonly] 
**FullPath** | **String** | Object full path of request. | [optional] [readonly] 
**ApprovalStageName** | **String** | Approval stage name of request. | [optional] [readonly] 
**Participants** | **String** | Participants of request. | [optional] [readonly] 
**ObjectID** | **String** | Object full path/email/private channel of request. | [optional] [readonly] 
**CreatedSource** | **Int32** |  | [optional] [readonly] [default to 0]
**SubRequestType** | [**SubRequestType**](SubRequestType.md) |  | [optional] [readonly] 

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
 -TimeZoneSettings null `
 -OriginalTimeZoneSettings null `
 -LocaleSettings null `
 -OriginalLocaleSettings null `
 -Id null `
 -ServiceId null `
 -Summary null `
 -NotesToApprovers null `
 -QuestionnaireId null `
 -QuestionnaireResponse null `
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
 -HasSubRequest null `
 -IsEnabledPassback null `
 -RequestResourceType null `
 -ModifiedBy null `
 -ModifiedByDisplayName null `
 -ModifiedDate null `
 -AssignTo null `
 -FullPath null `
 -ApprovalStageName null `
 -Participants null `
 -ObjectID null `
 -CreatedSource null `
 -SubRequestType null
```

- Convert the resource to JSON
```powershell
$ChangeGroupSettingRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

