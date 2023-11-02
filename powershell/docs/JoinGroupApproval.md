# JoinGroupApproval
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JoinGroupRule** | [**GroupInOutRuleType**](GroupInOutRuleType.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$JoinGroupApproval = New-Cloud.Governance.ClientJoinGroupApproval  -JoinGroupRule null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$JoinGroupApproval | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

