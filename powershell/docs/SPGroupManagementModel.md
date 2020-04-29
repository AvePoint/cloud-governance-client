# SPGroupManagementModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] [default to null]
**Name** | [**StringChangedProperty**](StringChangedProperty.md) |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Owner** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**Members** | [**SPUserManagementModel[]**](SPUserManagementModel.md) |  | [optional] [default to null]
**SpGroupViewType** | [**SPGroupViewOption**](SPGroupViewOption.md) |  | [optional] [default to null]
**SpGroupEditType** | [**SPGroupEditOption**](SPGroupEditOption.md) |  | [optional] [default to null]
**Permissions** | **String[]** |  | [optional] [default to null]
**Action** | [**ManagePermissionAction**](ManagePermissionAction.md) |  | [optional] [default to null]
**IsAllowJoinOrLeaveRequest** | **Boolean** |  | [optional] [default to null]
**IsAutoAcceptRequest** | **Boolean** |  | [optional] [default to null]
**SendMembershipRequestEmailAddress** | **String** |  | [optional] [default to null]
**IsTemporaryGroup** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSPGroupManagementModel  -Id null `
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
 -IsTemporaryGroup null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

