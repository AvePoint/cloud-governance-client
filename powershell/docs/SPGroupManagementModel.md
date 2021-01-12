# SPGroupManagementModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] 
**Name** | [**StringChangedProperty**](StringChangedProperty.md) |  | [optional] 
**Description** | **String** |  | [optional] 
**Owner** | [**ApiUser**](ApiUser.md) |  | [optional] 
**Members** | [**SPUserManagementModel[]**](SPUserManagementModel.md) |  | [optional] 
**SpGroupViewType** | [**SPGroupViewOption**](SPGroupViewOption.md) |  | [optional] 
**SpGroupEditType** | [**SPGroupEditOption**](SPGroupEditOption.md) |  | [optional] 
**Permissions** | **String[]** |  | [optional] 
**Action** | [**ManagePermissionAction**](ManagePermissionAction.md) |  | [optional] 
**IsAllowJoinOrLeaveRequest** | **Boolean** |  | [optional] 
**IsAutoAcceptRequest** | **Boolean** |  | [optional] 
**SendMembershipRequestEmailAddress** | **String** |  | [optional] 
**IsTemporaryGroup** | **Boolean** |  | [optional] 
**RoleID** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SPGroupManagementModel = New-Cloud.Governance.ClientSPGroupManagementModel  -Id null `
 -Name null `
 -Description null `
 -Owner null `
 -Members null `
 -SpGroupViewType null `
 -SpGroupEditType null `
 -Permissions null `
 -Action null `
 -IsAllowJoinOrLeaveRequest null `
 -IsAutoAcceptRequest null `
 -SendMembershipRequestEmailAddress null `
 -IsTemporaryGroup null `
 -RoleID null
```

- Convert the resource to JSON
```powershell
$SPGroupManagementModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

