# DynamicRuleElement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Type** | [**MetadataFieldType**](MetadataFieldType.md) |  | [optional] 
**ChoiceItems** | [**StringModel[]**](StringModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$DynamicRuleElement = New-Cloud.Governance.ClientDynamicRuleElement  -Id null `
 -Name null `
 -Type null `
 -ChoiceItems null
```

- Convert the resource to JSON
```powershell
$DynamicRuleElement | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

