# TextValidationRuleModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [default to null]
**Description** | **String** |  | [optional] [default to null]
**RegularExpression** | **String** |  | [default to null]
**ErrorMessage** | **String** |  | [default to null]
**ValidationTestText** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientTextValidationRuleModel  -Id null `
 -Name null `
 -Description null `
 -RegularExpression null `
 -ErrorMessage null `
 -ValidationTestText null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

