# GroupIdConstructureSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleType** | [**GroupIdRuleType**](GroupIdRuleType.md) |  | [optional] 
**EnableAutoSequenceNumber** | **Boolean** |  | [optional] 
**AutoSequenceNumber** | **String** |  | [optional] 
**Enabled** | **Boolean** |  | [optional] 
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**Prefixs** | [**GroupConstructureRule[]**](GroupConstructureRule.md) |  | [optional] 
**Suffixs** | [**GroupConstructureRule[]**](GroupConstructureRule.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GroupIdConstructureSettings = New-Cloud.Governance.ClientGroupIdConstructureSettings  -RuleType null `
 -EnableAutoSequenceNumber null `
 -AutoSequenceNumber null `
 -Enabled null `
 -AssignBy null `
 -Prefixs null `
 -Suffixs null
```

- Convert the resource to JSON
```powershell
$GroupIdConstructureSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

