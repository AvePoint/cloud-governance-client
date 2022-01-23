# Cloud.Governance.Client.Model.ChangeGroupSettingCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**GroupId** | **string** |  | [optional] 
**GroupName** | **string** |  | [optional] 
**GroupEmail** | **string** |  | [optional] 
**GroupDescription** | **string** |  | [optional] 
**IsEnableSubscribeMembers** | **bool** |  | [optional] [default to false]
**IsEnableOutsideSender** | **bool** |  | [optional] [default to false]
**Classification** | **string** |  | [optional] 
**Sensitivity** | [**StringModel**](StringModel.md) | StringModel model | [optional] 
**IsTeamsEnabled** | **bool** |  | [optional] [default to false]
**EnableManageGroupSharing** | **bool** |  | [optional] [default to false]
**EnableInviteAuthorizedGuestUser** | **bool** |  | [optional] [default to false]
**EnableInviteGuestUser** | **bool** |  | [optional] [default to false]
**EnableDynamicMembership** | **bool** |  | [optional] [default to false]
**EnableTeamCollaboration** | **bool** |  | [optional] [default to false]
**IsHubSite** | **bool** |  | [optional] [default to false]
**AssociatedHubSiteId** | **Guid?** |  | [optional] 
**DynamicMembershipRules** | [**List&lt;DynamicGroupRuleInfo&gt;**](DynamicGroupRuleInfo.md) |  | [optional] 
**Metadatas** | [**List&lt;CustomMetadata&gt;**](CustomMetadata.md) |  | [optional] 
**EnableChangeMembershipType** | **bool** |  | [optional] [default to false]
**YammerGroupInfo** | **string** |  | [optional] 
**GroupObjectType** | **GroupObjectType** |  | [optional] 
**NetworkId** | **string** |  | [optional] 
**GroupObjectId** | **string** |  | [optional] 
**IsValid** | **bool** |  | [optional] [default to false]
**ErrorMessage** | **string** |  | [optional] 
**MessageCode** | **MessageCode** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

