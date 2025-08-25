# CreateGroupServiceRequestTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupType** | [**CreateGroupType**](CreateGroupType.md) | Group type | [optional] 
**GroupId** | **String** | An entire group ID | [optional] 
**GroupIdWithoutPrefixSuffix** | **String** | Group ID (without prefix and suffix) | [optional] 
**GroupName** | **String** | An entire group name | [optional] 
**GroupNameWithoutPrefixSuffix** | **String** | Group name (without prefix and suffix) | [optional] 
**GroupEmail** | **String** | Group e-mail address | [optional] [readonly] 
**Policy** | **String** | The ID of a group policy. You can get IDs and names of all available policies by invoking the GetCreateGroupServiceApi. | [optional] 
**GroupDescription** | **String** | Group description | [optional] 
**Owners** | [**ApiUser[]**](ApiUser.md) | Group owners | [optional] 
**Members** | [**ApiUser[]**](ApiUser.md) | Group members | [optional] 
**Privacy** | **Boolean** | The privacy settings of a group. Whether to allow anyone can see group content or only allow members to see group content. | [optional] [default to $false]
**Subscribe** | **Boolean** | Whether to allow group members to receive copies of group conversations and events. | [optional] [default to $false]
**OutsideSender** | **Boolean** | Whether to allow users outside the organization to send e-mails to groups. | [optional] [default to $false]
**EnableTeamCollaboration** | **Boolean** | Enable a team for the group. | [optional] [default to $false]
**Language** | **String** | The language of a group. You can get IDs and names of all available languages by invoking the GetCreateGroupServiceApi. | [optional] 
**Classification** | **String** | Group classification | [optional] 
**Sensitivity** | **String** | Group sensitive lable id | [optional] 
**SensitivityName** | **String** | Group sensitive lable name | [optional] 
**Links** | [**CreateGroupRequestLinks**](CreateGroupRequestLinks.md) |  | [optional] 
**LeasePeriodSettings** | [**CreateGroupRequestLeasePeriodSettings**](CreateGroupRequestLeasePeriodSettings.md) |  | [optional] 
**TeamsSettings** | [**CreateGroupRequestTeamsSettings**](CreateGroupRequestTeamsSettings.md) |  | [optional] 
**AppliedSiteDesignId** | **String** | The ID of the group team site design. You can get IDs and names of all group team sites by invoking the GetCreateGroupServiceApi. | [optional] 
**PrimaryContact** | [**CreateGroupRequestPrimaryContact**](CreateGroupRequestPrimaryContact.md) |  | [optional] 
**SecondaryContact** | [**CreateGroupRequestSecondaryContact**](CreateGroupRequestSecondaryContact.md) |  | [optional] 
**EnableGroupMembershipHidden** | **Boolean** | Whether to hide the group members from users who are not members of the group. | [optional] [default to $false]
**EnableAssignedMembership** | **Boolean** | Whether to allow to copy team members from existing teams. | [optional] [default to $false]
**EnableDynamicMembership** | **Boolean** | Whether to use dynamic membership rules to get group members. | [optional] [default to $false]
**TemplateSettings** | [**CreateGroupRequestTemplateSettings**](CreateGroupRequestTemplateSettings.md) |  | [optional] 
**DynamicMembershipRules** | [**DynamicGroupRuleInfo[]**](DynamicGroupRuleInfo.md) | Dynamic group membership rules | [optional] 
**MultiGeoLocation** | [**CreateGroupRequestMultiGeoLocation**](CreateGroupRequestMultiGeoLocation.md) |  | [optional] 
**HubSiteSettings** | [**CreateGroupRequestHubSiteSettings**](CreateGroupRequestHubSiteSettings.md) |  | [optional] 
**TimeZoneSettings** | [**CreateGroupRequestTimeZoneSettings**](CreateGroupRequestTimeZoneSettings.md) |  | [optional] 
**LocaleSettings** | [**CreateGroupRequestLocaleSettings**](CreateGroupRequestLocaleSettings.md) |  | [optional] 
**YammerGroupInfo** | **String** | Yammer community info | [optional] 
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
$CreateGroupServiceRequestTemplate = New-Cloud.Governance.ClientCreateGroupServiceRequestTemplate  -GroupType null `
 -GroupId null `
 -GroupIdWithoutPrefixSuffix null `
 -GroupName null `
 -GroupNameWithoutPrefixSuffix null `
 -GroupEmail null `
 -Policy null `
 -GroupDescription null `
 -Owners null `
 -Members null `
 -Privacy null `
 -Subscribe null `
 -OutsideSender null `
 -EnableTeamCollaboration null `
 -Language null `
 -Classification null `
 -Sensitivity null `
 -SensitivityName null `
 -Links null `
 -LeasePeriodSettings null `
 -TeamsSettings null `
 -AppliedSiteDesignId null `
 -PrimaryContact null `
 -SecondaryContact null `
 -EnableGroupMembershipHidden null `
 -EnableAssignedMembership null `
 -EnableDynamicMembership null `
 -TemplateSettings null `
 -DynamicMembershipRules null `
 -MultiGeoLocation null `
 -HubSiteSettings null `
 -TimeZoneSettings null `
 -LocaleSettings null `
 -YammerGroupInfo null `
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
$CreateGroupServiceRequestTemplate | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

