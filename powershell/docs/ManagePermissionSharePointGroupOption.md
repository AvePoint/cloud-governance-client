# ManagePermissionSharePointGroupOption
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnableCreateSPGroup** | **Boolean** |  | [optional] [default to null]
**IsEnableDeleteSPGroup** | **Boolean** |  | [optional] [default to null]
**IsEnableManageGroupSettings** | **Boolean** |  | [optional] [default to null]
**IsEnableManageGroupMembers** | **Boolean** |  | [optional] [default to null]
**GroupOwner** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**GroupOwnerAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**SpGroupViewType** | [**SPGroupViewOption**](SPGroupViewOption.md) |  | [optional] [default to null]
**SpGroupEditType** | [**SPGroupEditOption**](SPGroupEditOption.md) |  | [optional] [default to null]
**SpGroupOptionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**IsAllowJoinOrLeaveRequest** | **Boolean** |  | [optional] [default to null]
**IsAutoAcceptRequest** | **Boolean** |  | [optional] [default to null]
**SendMembershipRequestEmailAddress** | **String** |  | [optional] [default to null]
**GroupRequestAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientManagePermissionSharePointGroupOption  -IsEnableCreateSPGroup null `
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

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

