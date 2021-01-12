# InlineResponse200
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Contact** | [**DynamicRuleElement[]**](DynamicRuleElement.md) |  | [optional] 
**License** | [**DynamicRuleElement[]**](DynamicRuleElement.md) |  | [optional] 
**Organization** | [**DynamicRuleElement[]**](DynamicRuleElement.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$InlineResponse200 = New-Cloud.Governance.ClientInlineResponse200  -Contact null `
 -License null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$InlineResponse200 | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

