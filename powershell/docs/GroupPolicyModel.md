# GroupPolicyModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsOverwriteLifecycleStartTime** | **Boolean** |  | [optional] [default to null]
**QuotaSize** | **Int32** |  | [optional] [default to null]
**SharingSettings** | [**GroupSharingSetting**](GroupSharingSetting.md) |  | [optional] [default to null]
**LifecycleSettings** | [**GroupPolicyLifecycleSetting**](GroupPolicyLifecycleSetting.md) |  | [optional] [default to null]
**InactivityThresholdSettings** | [**GroupThresholdSetting**](GroupThresholdSetting.md) |  | [optional] [default to null]
**LeaseThresholdSettings** | [**GroupThresholdSetting**](GroupThresholdSetting.md) |  | [optional] [default to null]
**QuotaThresholdSettings** | [**GroupQuotaThresholdSetting**](GroupQuotaThresholdSetting.md) |  | [optional] [default to null]
**RecertificationSettings** | [**PolicyRecertificationSetting**](PolicyRecertificationSetting.md) |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Category** | **String** |  | [optional] [default to null]
**TenantId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGroupPolicyModel  -IsOverwriteLifecycleStartTime null `
 -QuotaSize null `
 -SharingSettings null `
 -LifecycleSettings null `
 -InactivityThresholdSettings null `
 -LeaseThresholdSettings null `
 -QuotaThresholdSettings null `
 -RecertificationSettings null `
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

