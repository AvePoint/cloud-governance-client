# ApplySitePolicyModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsApplyDesigner** | **Boolean** |  | [optional] [default to $false]
**IsApplySiteMaxDepth** | **Boolean** |  | [optional] [default to $false]
**IsApplyPolicyIcon** | **Boolean** |  | [optional] [default to $false]
**IsApplyAosPlans** | **Boolean** |  | [optional] [default to $false]
**PolicyId** | **String** |  | [optional] 
**IsApplyAllSetting** | **Boolean** |  | [optional] [default to $false]
**IsApplyQuota** | **Boolean** |  | [optional] [default to $false]
**IsApplySharing** | **Boolean** |  | [optional] [default to $false]
**IsApplyQuotaThreshold** | **Boolean** |  | [optional] [default to $false]
**IsApplyDeactivatedElection** | **Boolean** |  | [optional] [default to $false]
**IsApplyLifecycle** | **Boolean** |  | [optional] [default to $false]
**LifecycleRenewalSetting** | [**LifecycleRenewalSetting**](LifecycleRenewalSetting.md) |  | [optional] 
**VarFilter** | **String** |  | [optional] 
**SelectedObjects** | **String[]** |  | [optional] 
**HasOngoingTasks** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$ApplySitePolicyModel = New-Cloud.Governance.ClientApplySitePolicyModel  -IsApplyDesigner null `
 -IsApplySiteMaxDepth null `
 -IsApplyPolicyIcon null `
 -IsApplyAosPlans null `
 -PolicyId null `
 -IsApplyAllSetting null `
 -IsApplyQuota null `
 -IsApplySharing null `
 -IsApplyQuotaThreshold null `
 -IsApplyDeactivatedElection null `
 -IsApplyLifecycle null `
 -LifecycleRenewalSetting null `
 -VarFilter null `
 -SelectedObjects null `
 -HasOngoingTasks null
```

- Convert the resource to JSON
```powershell
$ApplySitePolicyModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

