# ApplyGroupPolicyModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubType** | [**GroupPolicySubType**](GroupPolicySubType.md) |  | [optional] 
**PolicyId** | **String** |  | [optional] 
**IsApplyAllSetting** | **Boolean** |  | [optional] [default to $false]
**IsApplyQuota** | **Boolean** |  | [optional] [default to $false]
**IsApplySharing** | **Boolean** |  | [optional] [default to $false]
**IsApplyQuotaThreshold** | **Boolean** |  | [optional] [default to $false]
**IsApplyDeactivatedElection** | **Boolean** |  | [optional] [default to $false]
**IsApplyLifecycle** | **Boolean** |  | [optional] [default to $false]
**LifecycleRenewalSetting** | [**LifecycleRenewalSetting**](LifecycleRenewalSetting.md) |  | [optional] 
**VarFilter** | **String** |  | [optional] 
**Search** | **String** |  | [optional] 
**SelectedObjects** | **String[]** |  | [optional] 
**HasOngoingTasks** | **Boolean** |  | [optional] [default to $false]
**IsApplyUniqueAccess** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$ApplyGroupPolicyModel = New-Cloud.Governance.ClientApplyGroupPolicyModel  -SubType null `
 -PolicyId null `
 -IsApplyAllSetting null `
 -IsApplyQuota null `
 -IsApplySharing null `
 -IsApplyQuotaThreshold null `
 -IsApplyDeactivatedElection null `
 -IsApplyLifecycle null `
 -LifecycleRenewalSetting null `
 -VarFilter null `
 -Search null `
 -SelectedObjects null `
 -HasOngoingTasks null `
 -IsApplyUniqueAccess null
```

- Convert the resource to JSON
```powershell
$ApplyGroupPolicyModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

