# BriefGroupPolicy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**EnableLeaseExpiration** | **Boolean** |  | [optional] [default to $false]
**LeaseExpiredInterval** | **Int32** |  | [optional] [default to 0]
**LeaseExpiredIntervalType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**EnableManageGroupSharing** | **Boolean** |  | [optional] [default to $false]
**EnableInviteAuthorizedGuestUser** | **Boolean** |  | [optional] [default to $false]
**EnableInviteGuestUser** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$BriefGroupPolicy = New-Cloud.Governance.ClientBriefGroupPolicy  -Id null `
 -Name null `
 -Description null `
 -EnableLeaseExpiration null `
 -LeaseExpiredInterval null `
 -LeaseExpiredIntervalType null `
 -EnableManageGroupSharing null `
 -EnableInviteAuthorizedGuestUser null `
 -EnableInviteGuestUser null
```

- Convert the resource to JSON
```powershell
$BriefGroupPolicy | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

