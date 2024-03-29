# SiteLifecycleValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**ApprovalProcessHasManagerRole** | **Boolean** |  | [optional] [default to $false]
**ChangeQuotaSetting** | [**ChangeSiteQuotaSettings**](ChangeSiteQuotaSettings.md) |  | [optional] 
**ExtendSetting** | [**ExtendSiteSetting**](ExtendSiteSetting.md) |  | [optional] 
**UnlockSetting** | [**UnlockSiteSetting**](UnlockSiteSetting.md) |  | [optional] 
**ChangePolicySetting** | [**ChangeSitePolicySetting**](ChangeSitePolicySetting.md) |  | [optional] 
**LockSetting** | [**LockSiteSetting**](LockSiteSetting.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SiteLifecycleValidateResult = New-Cloud.Governance.ClientSiteLifecycleValidateResult  -SiteId null `
 -SiteUrl null `
 -ApprovalProcessHasManagerRole null `
 -ChangeQuotaSetting null `
 -ExtendSetting null `
 -UnlockSetting null `
 -ChangePolicySetting null `
 -LockSetting null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$SiteLifecycleValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

