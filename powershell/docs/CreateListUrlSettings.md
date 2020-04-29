# CreateListUrlSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableContructUrl** | **Boolean** |  | [optional] [default to null]
**ContructUrlSetting** | [**ContructUrlSetting**](ContructUrlSetting.md) |  | [optional] [default to null]
**EnableUrlValidation** | **Boolean** |  | [optional] [default to null]
**TextValidationRule** | [**TextValidationRuleRef**](TextValidationRuleRef.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientCreateListUrlSettings  -EnableContructUrl null `
 -ContructUrlSetting null `
 -EnableUrlValidation null `
 -TextValidationRule null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

