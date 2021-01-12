# ChangeGroupPolicyResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentPolicy** | [**GuidModel**](GuidModel.md) |  | [optional] 
**AllPolicies** | [**GuidModel[]**](GuidModel.md) |  | [optional] 
**ChangePolicyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**StartDateType** | [**StartDateType**](StartDateType.md) |  | [optional] 
**ServiceSpecifyDate** | **System.DateTime** |  | [optional] 
**IsEnableLeaseExpired** | **Boolean** |  | [optional] 
**LeaseDuration** | **Int32** |  | [optional] 
**LeaseDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**CurrentStartDate** | **System.DateTime** |  | [optional] 
**IsAllowAutoCancel** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeGroupPolicyResult = New-Cloud.Governance.ClientChangeGroupPolicyResult  -CurrentPolicy null `
 -AllPolicies null `
 -ChangePolicyAssignBy null `
 -StartDateType null `
 -ServiceSpecifyDate null `
 -IsEnableLeaseExpired null `
 -LeaseDuration null `
 -LeaseDurationType null `
 -CurrentStartDate null `
 -IsAllowAutoCancel null
```

- Convert the resource to JSON
```powershell
$ChangeGroupPolicyResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

