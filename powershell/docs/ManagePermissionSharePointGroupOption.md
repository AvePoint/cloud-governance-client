# ManagePermissionSharePointGroupOption
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnableCreateSPGroup** | **Boolean** |  | [optional] 
**IsEnableDeleteSPGroup** | **Boolean** |  | [optional] 
**IsEnableManageGroupSettings** | **Boolean** |  | [optional] 
**IsEnableManageGroupMembers** | **Boolean** |  | [optional] 
**GroupOwner** | [**ApiUser**](ApiUser.md) |  | [optional] 
**GroupOwnerAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SpGroupViewType** | [**SPGroupViewOption**](SPGroupViewOption.md) |  | [optional] 
**SpGroupEditType** | [**SPGroupEditOption**](SPGroupEditOption.md) |  | [optional] 
**SpGroupOptionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**IsAllowJoinOrLeaveRequest** | **Boolean** |  | [optional] 
**IsAutoAcceptRequest** | **Boolean** |  | [optional] 
**SendMembershipRequestEmailAddress** | **String** |  | [optional] 
**GroupRequestAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManagePermissionSharePointGroupOption = New-Cloud.Governance.ClientManagePermissionSharePointGroupOption  -IsEnableCreateSPGroup null `
 -IsEnableDeleteSPGroup null `
 -IsEnableManageGroupSettings null `
 -IsEnableManageGroupMembers null `
 -GroupOwner null `
 -GroupOwnerAssignBy null `
 -SpGroupViewType null `
 -SpGroupEditType null `
 -SpGroupOptionAssignBy null `
 -IsAllowJoinOrLeaveRequest null `
 -IsAutoAcceptRequest null `
 -SendMembershipRequestEmailAddress null `
 -GroupRequestAssignBy null
```

- Convert the resource to JSON
```powershell
$ManagePermissionSharePointGroupOption | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

