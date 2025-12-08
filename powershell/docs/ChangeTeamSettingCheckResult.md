# ChangeTeamSettingCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeamId** | **String** |  | [optional] 
**TeamName** | **String** |  | [optional] 
**Template** | **String** |  | [optional] 
**TeamDescription** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**Sensitivity** | [**StringModel**](StringModel.md) | StringModel model | [optional] 
**TeamGlobalAddress** | **Boolean** |  | [optional] [default to $false]
**TeamOutlookClient** | **Boolean** |  | [optional] [default to $false]
**TeamPrivacy** | **Boolean** |  | [optional] [default to $false]
**TenantId** | **String** |  | [optional] 
**IsSiteLocked** | **Boolean** |  | [optional] [default to $false]
**IsEnableHiddenMembership** | **Boolean** |  | [optional] [default to $false]
**IsEnableSensivityLabel** | **Boolean** |  | [optional] [default to $false]
**FunStuffSettings** | [**FunStuffSettingResult**](FunStuffSettingResult.md) |  | [optional] 
**TeamMentionsResult** | [**TeamMentionsResult**](TeamMentionsResult.md) |  | [optional] 
**MemberPermissionResult** | [**MemberPermissionResult**](MemberPermissionResult.md) |  | [optional] 
**GuestPermissionResult** | [**GuestPermissionResult**](GuestPermissionResult.md) |  | [optional] 
**PictureUri** | **String** |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeTeamSettingCheckResult = New-Cloud.Governance.ClientChangeTeamSettingCheckResult  -TeamId null `
 -TeamName null `
 -Template null `
 -TeamDescription null `
 -Classification null `
 -SiteUrl null `
 -Sensitivity null `
 -TeamGlobalAddress null `
 -TeamOutlookClient null `
 -TeamPrivacy null `
 -TenantId null `
 -IsSiteLocked null `
 -IsEnableHiddenMembership null `
 -IsEnableSensivityLabel null `
 -FunStuffSettings null `
 -TeamMentionsResult null `
 -MemberPermissionResult null `
 -GuestPermissionResult null `
 -PictureUri null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeTeamSettingCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

