# Cloud.Governance.Client.Model.RequestGroupWithPermissions
Group permissions model in request
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Group name | [optional] 
**Description** | **string** | Group description | [optional] 
**Users** | [**List&lt;GroupUser&gt;**](GroupUser.md) | The list of the group users | [optional] 
**PermissionLevels** | [**List&lt;PermissionLevel&gt;**](PermissionLevel.md) | The list of the group permission levels | [optional] 
**GroupOwner** | [**ApiUser**](ApiUser.md) | Group owner information | [optional] 
**GroupOwnerType** | **GroupOwnerType** | Group owner type | [optional] 
**BuildInGroupType** | **SharePointBuildInGroupType** | Built-in group type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

