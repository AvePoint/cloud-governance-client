# SPGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Owner** | [**SPPrincipal**](SPPrincipal.md) |  | [optional] [default to null]
**Members** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**PermissionLevels** | **String[]** |  | [optional] [default to null]
**SpGroupViewType** | [**SPGroupViewOption**](SPGroupViewOption.md) |  | [optional] [default to null]
**SpGroupEditType** | [**SPGroupEditOption**](SPGroupEditOption.md) |  | [optional] [default to null]
**IsAllowJoinOrLeaveRequest** | **Boolean** |  | [optional] [default to null]
**AutoAcceptRequestToJoinLeave** | **Boolean** |  | [optional] [default to null]
**RequestToJoinLeaveEmailSetting** | **String** |  | [optional] [default to null]
**IsTemporaryGroup** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSPGroup  -Id null `
 -Name null `
 -Description null `
 -Owner null `
 -Members null `
 -PermissionLevels null `
 -SpGroupViewType null `
 -SpGroupEditType null `
 -IsAllowJoinOrLeaveRequest null `
 -AutoAcceptRequestToJoinLeave null `
 -RequestToJoinLeaveEmailSetting null `
 -IsTemporaryGroup null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

