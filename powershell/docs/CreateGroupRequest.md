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
**Privacy** | **Boolean** |  | [optional] 
**Subscribe** | **Boolean** |  | [optional] 
**OutsideSender** | **Boolean** |  | [optional] 
**EnableTeamCollaboration** | **Boolean** |  | [optional] 
**Language** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**Sensitivity** | **String** |  | [optional] 
**Links** | [**GroupLinks**](GroupLinks.md) |  | [optional] [readonly] 
**LeasePeriodSettings** | [**GroupLeasePeriodSettings**](GroupLeasePeriodSettings.md) |  | [optional] 
**TeamsSettings** | [**RequestTeamsSettings**](RequestTeamsSettings.md) |  | [optional] 
**AppliedSiteDesignId** | **String** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**EnableGroupMembershipHidden** | **Boolean** |  | [optional] 
**EnableAssignedMembership** | **Boolean** |  | [optional] 
**EnableDynamicMembership** | **Boolean** |  | [optional] 
**TemplateSettings** | [**TeamsTemplateSettings**](TeamsTemplateSettings.md) |  | [optional] 
**DynamicMembershipRules** | [**DynamicGroupRuleInfo[]**](DynamicGroupRuleInfo.md) |  | [optional] 
**MultiGeoLocation** | [**GeoLocationBase**](GeoLocationBase.md) |  | [optional] 
**HubSiteSettings** | [**HubSiteSettings**](HubSiteSettings.md) |  | [optional] 
**YammerGroupInfo** | **String** |  | [optional] 
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

