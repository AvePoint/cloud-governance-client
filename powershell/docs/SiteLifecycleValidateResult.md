# SiteLifecycleValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SiteUrl** | **String** |  | [optional] [default to null]
**ChangeQuotaSetting** | [**ChangeSiteQuotaSettings**](ChangeSiteQuotaSettings.md) |  | [optional] [default to null]
**ExtendSetting** | [**ExtendSiteSetting**](ExtendSiteSetting.md) |  | [optional] [default to null]
**UnlockSetting** | [**UnlockSiteSetting**](UnlockSiteSetting.md) |  | [optional] [default to null]
**ChangePolicySetting** | [**ChangeSitePolicySetting**](ChangeSitePolicySetting.md) |  | [optional] [default to null]
**LockSetting** | [**LockSiteSetting**](LockSiteSetting.md) |  | [optional] [default to null]
**IsValid** | **Boolean** |  | [optional] [readonly] [default to null]
**ErrorMessage** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSiteLifecycleValidateResult  -SiteId null `
 -SiteUrl null `
 -ChangeQuotaSetting null `
 -ExtendSetting null `
 -UnlockSetting null `
 -ChangePolicySetting null `
 -LockSetting null `
 -IsValid null `
 -ErrorMessage null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

