# CreateGroupRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **String** |  | [optional] [default to null]
**GroupIdWithoutPrefixSuffix** | **String** |  | [optional] [default to null]
**GroupName** | **String** |  | [optional] [default to null]
**GroupNameWithoutPrefixSuffix** | **String** |  | [optional] [default to null]
**GroupEmail** | **String** |  | [optional] [readonly] [default to null]
**Policy** | [**UUID**](UUID.md) |  | [optional] [default to null]
**GroupDescription** | **String** |  | [optional] [default to null]
**Owners** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**Members** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**Privacy** | **Boolean** |  | [optional] [default to null]
**Subscribe** | **Boolean** |  | [optional] [default to null]
**OutsideSender** | **Boolean** |  | [optional] [default to null]
**EnableTeamCollaboration** | **Boolean** |  | [optional] [default to null]
**Language** | **String** |  | [optional] [default to null]
**Classification** | **String** |  | [optional] [default to null]
**Links** | [**GroupLinks**](GroupLinks.md) |  | [optional] [readonly] [default to null]
**LeasePeriodSettings** | [**GroupLeasePeriodSettings**](GroupLeasePeriodSettings.md) |  | [optional] [default to null]
**TeamsSettings** | [**RequestTeamsSettings**](RequestTeamsSettings.md) |  | [optional] [default to null]
**AppliedSiteDesignId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**EnableGroupMembershipHidden** | **Boolean** |  | [optional] [default to null]
**EnableAssignedMembership** | **Boolean** |  | [optional] [default to null]
**EnableDynamicMembership** | **Boolean** |  | [optional] [default to null]
**TemplateSettings** | [**TeamsTemplateSettings**](TeamsTemplateSettings.md) |  | [optional] [default to null]
**DynamicMembershipRules** | [**DynamicGroupRuleInfo[]**](DynamicGroupRuleInfo.md) |  | [optional] [default to null]
**MultiGeoLocation** | [**GeoLocationBase**](GeoLocationBase.md) |  | [optional] [default to null]
**HubSiteSettings** | [**HubSiteSettings**](HubSiteSettings.md) |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ServiceId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Department** | **String** |  | [optional] [default to null]
**Summary** | **String** |  | [optional] [default to null]
**NotesToApprovers** | **String** |  | [optional] [default to null]
**QuestionnaireId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] [default to null]
**TicketNumber** | **Int32** |  | [optional] [readonly] [default to null]
**Type** | [**ServiceTypeNullable**](ServiceTypeNullable.md) |  | [optional] [readonly] [default to null]
**TypeDescription** | **String** |  | [optional] [readonly] [default to null]
**Requester** | **String** |  | [optional] [readonly] [default to null]
**Status** | [**RequestStatusNullable**](RequestStatusNullable.md) |  | [optional] [readonly] [default to null]
**ProgressStatus** | **Int32** |  | [optional] [readonly] [default to null]
**ProgressStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**SubmittedTime** | **System.DateTime** |  | [optional] [readonly] [default to null]
**LastUpdated** | **System.DateTime** |  | [optional] [readonly] [default to null]
**CreatedTime** | **System.DateTime** |  | [optional] [readonly] [default to null]
**AssignTo** | **String** |  | [optional] [readonly] [default to null]
**FullPath** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientCreateGroupRequest  -GroupId null `
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
 -Status null `
 -ProgressStatus null `
 -ProgressStatusDescription null `
 -SubmittedTime null `
 -LastUpdated null `
 -CreatedTime null `
 -AssignTo null `
 -FullPath null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

