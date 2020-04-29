# GroupLifecycleValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExtendSetting** | [**ExtendGroupResult**](ExtendGroupResult.md) |  | [optional] [default to null]
**ChangePolicySetting** | [**ChangeGroupPolicyResult**](ChangeGroupPolicyResult.md) |  | [optional] [default to null]
**ChangeQuotaSetting** | [**ChangeGroupQuotaResult**](ChangeGroupQuotaResult.md) |  | [optional] [default to null]
**IsValid** | **Boolean** |  | [optional] [readonly] [default to null]
**ErrorMessage** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGroupLifecycleValidateResult  -ExtendSetting null `
 -ChangePolicySetting null `
 -ChangeQuotaSetting null `
 -IsValid null `
 -ErrorMessage null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

