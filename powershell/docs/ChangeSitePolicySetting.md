# ChangeSitePolicySetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentPolicy** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**AllPolicies** | [**GuidModel[]**](GuidModel.md) |  | [optional] 
**ChangePolicyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**StartDateType** | [**StartDateType**](StartDateType.md) |  | [optional] 
**ServiceSpecifyDate** | **System.DateTime** |  | [optional] 
**IsEnableLeaseExpired** | **Boolean** |  | [optional] [default to $false]
**LeaseDuration** | **Int32** |  | [optional] [default to 0]
**LeaseDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**CurrentStartDate** | **System.DateTime** |  | [optional] 
**IsAllowAutoCancel** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$ChangeSitePolicySetting = New-Cloud.Governance.ClientChangeSitePolicySetting  -CurrentPolicy null `
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
$ChangeSitePolicySetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

