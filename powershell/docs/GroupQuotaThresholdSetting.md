# GroupQuotaThresholdSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [default to null]
**Percentage** | **Int32** |  | [optional] [default to null]
**NotifiedUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGroupQuotaThresholdSetting  -Enabled null `
 -Percentage null `
 -NotifiedUsers null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

