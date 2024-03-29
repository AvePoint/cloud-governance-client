# Cloud.Governance.Client.Model.SPGroupManagementModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] [default to 0]
**Name** | [**StringChangedProperty**](StringChangedProperty.md) |  | [optional] 
**Description** | **string** |  | [optional] 
**Owner** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**Members** | [**List&lt;SPUserManagementModel&gt;**](SPUserManagementModel.md) |  | [optional] 
**SpGroupViewType** | **SPGroupViewOption** |  | [optional] 
**SpGroupEditType** | **SPGroupEditOption** |  | [optional] 
**Permissions** | **List&lt;string&gt;** |  | [optional] 
**Action** | **ManagePermissionAction** |  | [optional] 
**IsAllowJoinOrLeaveRequest** | **bool** |  | [optional] [default to false]
**IsAutoAcceptRequest** | **bool** |  | [optional] [default to false]
**SendMembershipRequestEmailAddress** | **string** |  | [optional] 
**IsTemporaryGroup** | **bool** |  | [optional] [default to false]
**RoleID** | **List&lt;string&gt;** |  | [optional] 
**IsEnabelSPMemberWelcomeEmail** | **bool** |  | [optional] [default to false]
**SpMemberWelcomeEmailTemplateId** | **Guid** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

