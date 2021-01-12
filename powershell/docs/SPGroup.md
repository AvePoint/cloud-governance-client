# SPGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Owner** | [**SPPrincipal**](SPPrincipal.md) |  | [optional] 
**Members** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PermissionLevels** | **String[]** |  | [optional] 
**SpGroupViewType** | [**SPGroupViewOption**](SPGroupViewOption.md) |  | [optional] 
**SpGroupEditType** | [**SPGroupEditOption**](SPGroupEditOption.md) |  | [optional] 
**IsAllowJoinOrLeaveRequest** | **Boolean** |  | [optional] 
**AutoAcceptRequestToJoinLeave** | **Boolean** |  | [optional] 
**RequestToJoinLeaveEmailSetting** | **String** |  | [optional] 
**IsTemporaryGroup** | **Boolean** |  | [optional] 
**RoleID** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SPGroup = New-Cloud.Governance.ClientSPGroup  -Id null `
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
 -IsTemporaryGroup null `
 -RoleID null
```

- Convert the resource to JSON
```powershell
$SPGroup | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

