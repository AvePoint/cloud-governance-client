# PolicyQuotaThresholdSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableQuotaThreshold** | **Boolean** |  | [optional] [default to null]
**QuotaThreshold** | **Int32** |  | [optional] [default to null]
**QuotaThresholdNotifyUsers** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientPolicyQuotaThresholdSetting  -EnableQuotaThreshold null `
 -QuotaThreshold null `
 -QuotaThresholdNotifyUsers null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

