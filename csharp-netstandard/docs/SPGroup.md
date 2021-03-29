# Cloud.Governance.Client.Model.SPGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] [default to 0]
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Owner** | [**SPPrincipal**](SPPrincipal.md) |  | [optional] 
**Members** | [**List&lt;ApiUser&gt;**](ApiUser.md) |  | [optional] 
**PermissionLevels** | **List&lt;string&gt;** |  | [optional] 
**SpGroupViewType** | **SPGroupViewOption** |  | [optional] 
**SpGroupEditType** | **SPGroupEditOption** |  | [optional] 
**IsAllowJoinOrLeaveRequest** | **bool** |  | [optional] [default to false]
**AutoAcceptRequestToJoinLeave** | **bool** |  | [optional] [default to false]
**RequestToJoinLeaveEmailSetting** | **string** |  | [optional] 
**IsTemporaryGroup** | **bool** |  | [optional] [default to false]
**RoleID** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

