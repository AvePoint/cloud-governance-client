# SitePolicyModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServerResourceQuota** | **Double** |  | [optional] [default to null]
**StorageQuota** | **Int64** |  | [optional] [default to null]
**SharingSetting** | [**SitePolicySharingSetting**](SitePolicySharingSetting.md) |  | [optional] [default to null]
**IsDesignerEnabled** | **Boolean** |  | [optional] [default to null]
**SiteMaxDepth** | **Int32** |  | [optional] [default to null]
**SiteMaxDepthType** | **Int32** |  | [optional] [default to null]
**IsDisplayPolicyIcon** | **Boolean** |  | [optional] [default to null]
**PolicyIconAddress** | **String** |  | [optional] [default to null]
**PolicyDetailReferenceURL** | **String** |  | [optional] [default to null]
**AosSettings** | [**SitePolicyAosSetting**](SitePolicyAosSetting.md) |  | [optional] [default to null]
**LifecycleSettings** | [**SitePolicyLifecycleSetting**](SitePolicyLifecycleSetting.md) |  | [optional] [default to null]
**RecertificationSettings** | [**PolicyRecertificationSetting**](PolicyRecertificationSetting.md) |  | [optional] [default to null]
**InactivitySettings** | [**SitePolicyExpirationSetting**](SitePolicyExpirationSetting.md) |  | [optional] [default to null]
**LeasePeriodSettings** | [**SitePolicyExpirationSetting**](SitePolicyExpirationSetting.md) |  | [optional] [default to null]
**ElectionSettings** | [**SitePolicyElectionSetting**](SitePolicyElectionSetting.md) |  | [optional] [default to null]
**IsOverwriteLifecycleStartTime** | **Boolean** |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Category** | **String** |  | [optional] [default to null]
**TenantId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSitePolicyModel  -ServerResourceQuota null `
 -StorageQuota null `
 -SharingSetting null `
 -IsDesignerEnabled null `
 -SiteMaxDepth null `
 -SiteMaxDepthType null `
 -IsDisplayPolicyIcon null `
 -PolicyIconAddress null `
 -PolicyDetailReferenceURL null `
 -AosSettings null `
 -LifecycleSettings null `
 -RecertificationSettings null `
 -InactivitySettings null `
 -LeasePeriodSettings null `
 -ElectionSettings null `
 -IsOverwriteLifecycleStartTime null `
 -Id null `
 -Name null `
 -Description null `
 -Category null `
 -TenantId null `
 -Status null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

