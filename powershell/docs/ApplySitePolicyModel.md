# ApplySitePolicyModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsApplyDesigner** | **Boolean** |  | [optional] 
**IsApplySiteMaxDepth** | **Boolean** |  | [optional] 
**IsApplyPolicyIcon** | **Boolean** |  | [optional] 
**IsApplyAosPlans** | **Boolean** |  | [optional] 
**PolicyId** | **String** |  | [optional] 
**IsApplyAllSetting** | **Boolean** |  | [optional] 
**IsApplyQuota** | **Boolean** |  | [optional] 
**IsApplySharing** | **Boolean** |  | [optional] 
**IsApplyQuotaThreshold** | **Boolean** |  | [optional] 
**IsApplyDeactivatedElection** | **Boolean** |  | [optional] 
**IsApplyLifecycle** | **Boolean** |  | [optional] 
**LifecycleRenewalSetting** | [**LifecycleRenewalSetting**](LifecycleRenewalSetting.md) |  | [optional] 
**VarFilter** | **String** |  | [optional] 
**SelectedObjects** | **String[]** |  | [optional] 
**HasOngoingTasks** | **Boolean** |  | [optional] 

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

