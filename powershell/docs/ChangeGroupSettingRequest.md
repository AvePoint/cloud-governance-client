# ChangeGroupSettingRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**GroupEmail** | **String** |  | [optional] [default to null]
**GroupName** | **String** |  | [optional] [default to null]
**OriginalGroupName** | **String** |  | [optional] [default to null]
**GroupDescription** | **String** |  | [optional] [default to null]
**OriginalGroupDescription** | **String** |  | [optional] [default to null]
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**OriginalPrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**OriginalSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**GroupOwners** | [**GroupMembershipItem[]**](GroupMembershipItem.md) |  | [optional] [default to null]
**GroupMembers** | [**GroupMembershipItem[]**](GroupMembershipItem.md) |  | [optional] [default to null]
**IsDynamicMembership** | **Boolean** |  | [optional] [default to null]
**DynamicMembershipRules** | [**DynamicGroupRuleInfo[]**](DynamicGroupRuleInfo.md) |  | [optional] [default to null]
**EnabledSubscribe** | **Boolean** |  | [optional] [default to null]
**OriginalEnabledSubscribe** | **Boolean** |  | [optional] [default to null]
**EnabledOutsideSender** | **Boolean** |  | [optional] [default to null]
**OriginalEnabledOutsideSender** | **Boolean** |  | [optional] [default to null]
**HubSiteActionType** | [**ChangeHubsiteActionType**](ChangeHubsiteActionType.md) |  | [optional] [default to null]
**AssociateHubSiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**AssociateHubSiteTitle** | **String** |  | [optional] [default to null]
**Classification** | **String** |  | [optional] [default to null]
**OriginalClassification** | **String** |  | [optional] [default to null]
**EnableTeams** | **Boolean** |  | [optional] [default to null]
**OriginalEnableTeams** | **Boolean** |  | [optional] [default to null]
**GroupMetadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] [default to null]
**OriginalGroupMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] [default to null]
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
New-Cloud.Governance.ClientChangeGroupSettingRequest  -GroupId null `
 -GroupEmail null `
 -GroupName null `
 -OriginalGroupName null `
 -GroupDescription null `
 -OriginalGroupDescription null `
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
 -EnableTeams null `
 -OriginalEnableTeams null `
 -GroupMetadatas null `
 -OriginalGroupMetadata null `
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

