# ExtendSiteSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExtendType** | [**ExtendType**](ExtendType.md) |  | [optional] [default to null]
**Duration** | **Int32** |  | [optional] [default to null]
**DurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**ConstantDuration** | **Int32** |  | [optional] [default to null]
**ConstantDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**ExtendBasedTime** | **System.DateTime** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientExtendSiteSetting  -ExtendType null `
 -Duration null `
 -DurationType null `
 -ConstantDuration null `
 -ConstantDurationType null `
 -ExtendBasedTime null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

