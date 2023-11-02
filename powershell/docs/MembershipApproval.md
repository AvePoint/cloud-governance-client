# MembershipApproval
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DepartGroupRule** | [**GroupInOutRuleType**](GroupInOutRuleType.md) |  | [optional] 
**JoinGroupRule** | [**GroupInOutRuleType**](GroupInOutRuleType.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$MembershipApproval = New-Cloud.Governance.ClientMembershipApproval  -DepartGroupRule null `
 -JoinGroupRule null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$MembershipApproval | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

