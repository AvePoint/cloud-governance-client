# GroupPolicyLifecycleSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultProcess** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**Deletion** | [**DeleteGroupSetting**](DeleteGroupSetting.md) |  | [optional] [default to null]
**Extension** | [**ExtendGroupSetting**](ExtendGroupSetting.md) |  | [optional] [default to null]
**ChangePolicy** | [**ChangeGroupSetting**](ChangeGroupSetting.md) |  | [optional] [default to null]
**Quota** | [**ChangeGroupQuotaSetting**](ChangeGroupQuotaSetting.md) |  | [optional] [default to null]
**TeamArchive** | [**GroupLifecycleSetting**](GroupLifecycleSetting.md) |  | [optional] [default to null]
**TeamUnArchive** | [**GroupLifecycleSetting**](GroupLifecycleSetting.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGroupPolicyLifecycleSetting  -DefaultProcess null `
 -Deletion null `
 -Extension null `
 -ChangePolicy null `
 -Quota null `
 -TeamArchive null `
 -TeamUnArchive null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

