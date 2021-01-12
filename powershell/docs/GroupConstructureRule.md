# GroupConstructureRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | [**ConstructureType**](ConstructureType.md) |  | [optional] 
**Value** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GroupConstructureRule = New-Cloud.Governance.ClientGroupConstructureRule  -Type null `
 -Value null
```

- Convert the resource to JSON
```powershell
$GroupConstructureRule | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

