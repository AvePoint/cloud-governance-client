# GetDynamicMembershipRuleItems200Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Contact** | [**DynamicRuleElement[]**](DynamicRuleElement.md) |  | [optional] 
**License** | [**DynamicRuleElement[]**](DynamicRuleElement.md) |  | [optional] 
**Organization** | [**DynamicRuleElement[]**](DynamicRuleElement.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GetDynamicMembershipRuleItems200Response = New-Cloud.Governance.ClientGetDynamicMembershipRuleItems200Response  -Contact null `
 -License null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$GetDynamicMembershipRuleItems200Response | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

