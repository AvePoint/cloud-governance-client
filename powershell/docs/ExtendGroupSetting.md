# ExtendGroupSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExtendType** | [**ExtendType**](ExtendType.md) |  | [optional] [default to null]
**ConstantDuration** | **Int32** |  | [optional] [default to null]
**ConstantDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**MaxDuration** | **Int32** |  | [optional] [default to null]
**MaxDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**Enabled** | **Boolean** |  | [optional] [default to null]
**ApprovalProcess** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**IsUsedDefaultProcess** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientExtendGroupSetting  -ExtendType null `
 -ConstantDuration null `
 -ConstantDurationType null `
 -MaxDuration null `
 -MaxDurationType null `
 -Enabled null `
 -ApprovalProcess null `
 -IsUsedDefaultProcess null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

