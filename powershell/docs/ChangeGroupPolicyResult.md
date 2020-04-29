# ChangeGroupPolicyResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentPolicy** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**AllPolicies** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]
**ChangePolicyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**StartDateType** | [**StartDateType**](StartDateType.md) |  | [optional] [default to null]
**ServiceSpecifyDate** | **System.DateTime** |  | [optional] [default to null]
**IsEnableLeaseExpired** | **Boolean** |  | [optional] [default to null]
**LeaseDuration** | **Int32** |  | [optional] [default to null]
**LeaseDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**CurrentStartDate** | **System.DateTime** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangeGroupPolicyResult  -CurrentPolicy null `
 -AllPolicies null `
 -ChangePolicyAssignBy null `
 -StartDateType null `
 -ServiceSpecifyDate null `
 -IsEnableLeaseExpired null `
 -LeaseDuration null `
 -LeaseDurationType null `
 -CurrentStartDate null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

