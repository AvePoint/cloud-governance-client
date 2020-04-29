# BriefGroupPolicy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**EnableLeaseExpiration** | **Boolean** |  | [optional] [default to null]
**LeaseExpiredInterval** | **Int32** |  | [optional] [default to null]
**LeaseExpiredIntervalType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**EnableManageGroupSharing** | **Boolean** |  | [optional] [default to null]
**EnableInviteAuthorizedGuestUser** | **Boolean** |  | [optional] [default to null]
**EnableInviteGuestUser** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientBriefGroupPolicy  -Id null `
 -Name null `
 -Description null `
 -EnableLeaseExpiration null `
 -LeaseExpiredInterval null `
 -LeaseExpiredIntervalType null `
 -EnableManageGroupSharing null `
 -EnableInviteAuthorizedGuestUser null `
 -EnableInviteGuestUser null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

