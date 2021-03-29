# CreateGroupRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupType** | [**CreateGroupType**](CreateGroupType.md) |  | [optional] 
**GroupId** | **String** |  | [optional] 
**GroupIdWithoutPrefixSuffix** | **String** |  | [optional] 
**GroupName** | **String** |  | [optional] 
**GroupNameWithoutPrefixSuffix** | **String** |  | [optional] 
**GroupEmail** | **String** |  | [optional] [readonly] 
**Policy** | **String** |  | [optional] 
**GroupDescription** | **String** |  | [optional] 
**Owners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Members** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Privacy** | **Boolean** |  | [optional] [default to $false]
**Subscribe** | **Boolean** |  | [optional] [default to $false]
**OutsideSender** | **Boolean** |  | [optional] [default to $false]
**EnableTeamCollaboration** | **Boolean** |  | [optional] [default to $false]
**Language** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**Sensitivity** | **String** |  | [optional] 
**Links** | [**GroupLinks**](GroupLinks.md) |  | [optional] [readonly] 
**LeasePeriodSettings** | [**GroupLeasePeriodSettings**](GroupLeasePeriodSettings.md) |  | [optional] 
**TeamsSettings** | [**RequestTeamsSettings**](RequestTeamsSettings.md) |  | [optional] 
**AppliedSiteDesignId** | **String** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**EnableGroupMembershipHidden** | **Boolean** |  | [optional] [default to $false]
**EnableAssignedMembership** | **Boolean** |  | [optional] [default to $false]
**EnableDynamicMembership** | **Boolean** |  | [optional] [default to $false]
**TemplateSettings** | [**TeamsTemplateSettings**](TeamsTemplateSettings.md) |  | [optional] 
**DynamicMembershipRules** | [**DynamicGroupRuleInfo[]**](DynamicGroupRuleInfo.md) |  | [optional] 
**MultiGeoLocation** | [**GeoLocationBase**](GeoLocationBase.md) |  | [optional] 
**HubSiteSettings** | [**HubSiteSettings**](HubSiteSettings.md) |  | [optional] 
**YammerGroupInfo** | **String** |  | [optional] 
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
$CreateGroupRequest = New-Cloud.Governance.ClientCreateGroupRequest  -GroupType null `
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
 -YammerGroupInfo null `
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
$CreateGroupRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

