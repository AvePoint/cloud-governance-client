# ExtendGroupResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExtendType** | [**ExtendType**](ExtendType.md) |  | [optional] 
**Duration** | **Int32** |  | [optional] 
**DurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ExtendGroupResult = New-Cloud.Governance.ClientExtendGroupResult  -ExtendType null `
 -Duration null `
 -DurationType null
```

- Convert the resource to JSON
```powershell
$ExtendGroupResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

