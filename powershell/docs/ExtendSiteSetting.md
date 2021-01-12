# ExtendSiteSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] 
**ExtendType** | [**ExtendType**](ExtendType.md) |  | [optional] 
**Duration** | **Int32** |  | [optional] 
**DurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**ConstantDuration** | **Int32** |  | [optional] 
**ConstantDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**ExtendBasedTime** | **System.DateTime** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ExtendSiteSetting = New-Cloud.Governance.ClientExtendSiteSetting  -IsEnabled null `
 -ExtendType null `
 -Duration null `
 -DurationType null `
 -ConstantDuration null `
 -ConstantDurationType null `
 -ExtendBasedTime null
```

- Convert the resource to JSON
```powershell
$ExtendSiteSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

