# SitePolicyInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuotaSetting** | [**PolicyQuotaSetting**](PolicyQuotaSetting.md) |  | [optional] [default to null]
**SharingSetting** | [**PolicySharingSetting**](PolicySharingSetting.md) |  | [optional] [default to null]
**IsDesignerEnabled** | **Boolean** |  | [optional] [default to null]
**SiteMaxDepth** | **Int32** |  | [optional] [default to null]
**IconSetting** | [**PolicyIconSetting**](PolicyIconSetting.md) |  | [optional] [default to null]
**DaoSetting** | [**PolicyDaoSetting**](PolicyDaoSetting.md) |  | [optional] [default to null]
**LeasePeriodSetting** | [**PolicyExpirationSetting**](PolicyExpirationSetting.md) |  | [optional] [default to null]
**InactivitySetting** | [**PolicyExpirationSetting**](PolicyExpirationSetting.md) |  | [optional] [default to null]
**LifecycleSetting** | [**PolicyLifecycleSetting**](PolicyLifecycleSetting.md) |  | [optional] [default to null]
**RecertificationSetting** | [**PolicyRecertificationSetting**](PolicyRecertificationSetting.md) |  | [optional] [default to null]
**RenewalSetting** | [**PolicyRecertificationSetting**](PolicyRecertificationSetting.md) |  | [optional] [default to null]
**ElectionSetting** | [**PolicyElectionSetting**](PolicyElectionSetting.md) |  | [optional] [default to null]
**QuotaThresholdSetting** | [**PolicyQuotaThresholdSetting**](PolicyQuotaThresholdSetting.md) |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Category** | **String** |  | [optional] [default to null]
**Detail** | **String** |  | [optional] [default to null]
**Type** | [**PolicyType**](PolicyType.md) |  | [optional] [default to null]
**FarmId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**CreatedTime** | **System.DateTime** |  | [optional] [default to null]
**CreatedBy** | **String** |  | [optional] [default to null]
**IsDeleted** | **Boolean** |  | [optional] [default to null]
**ModifiedTime** | **System.DateTime** |  | [optional] [default to null]
**ModifiedBy** | **String** |  | [optional] [default to null]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] [default to null]
**IsReferenced** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSitePolicyInfo  -QuotaSetting null `
 -SharingSetting null `
 -IsDesignerEnabled null `
 -SiteMaxDepth null `
 -IconSetting null `
 -DaoSetting null `
 -LeasePeriodSetting null `
 -InactivitySetting null `
 -LifecycleSetting null `
 -RecertificationSetting null `
 -RenewalSetting null `
 -ElectionSetting null `
 -QuotaThresholdSetting null `
 -Id null `
 -Name null `
 -Description null `
 -Category null `
 -Detail null `
 -Type null `
 -FarmId null `
 -CreatedTime null `
 -CreatedBy null `
 -IsDeleted null `
 -ModifiedTime null `
 -ModifiedBy null `
 -Status null `
 -IsReferenced null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

