# Cloud.Governance.Client.Model.ServiceGroupWithPermissions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UsersAssignBy** | **AssignBy** |  | [optional] 
**GroupOwnerAssignBy** | **AssignBy** |  | [optional] 
**AllowChangePermissionLevel** | **bool** |  | [optional] [default to false]
**Removable** | **bool** |  | [optional] [default to false]
**Name** | **string** | Group name | [optional] 
**Description** | **string** | Group description | [optional] 
**Users** | [**List&lt;GroupUser&gt;**](GroupUser.md) | The list of the group users | [optional] 
**PermissionLevels** | [**List&lt;PermissionLevel&gt;**](PermissionLevel.md) | The list of the group permission levels | [optional] 
**GroupOwner** | [**ApiUser**](ApiUser.md) | Group owner information | [optional] 
**GroupOwnerType** | **GroupOwnerType** | Group owner type | [optional] 
**BuildInGroupType** | **SharePointBuildInGroupType** | Built-in group type | [optional] 
**SpGroupViewType** | **SPGroupViewOptionType** |  | [optional] 
**SpGroupEditType** | **SPGroupEditOptionType** |  | [optional] 
**SpGroupEditOptionAssignBy** | **AssignBy** |  | [optional] 
**SpGroupViewOptionAssignBy** | **AssignBy** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

