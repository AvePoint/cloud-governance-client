# SiteProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Department** | **String** |  | [optional] [default to null]
**Policy** | [**SitePolicyInfo**](SitePolicyInfo.md) |  | [optional] [default to null]
**CustomMetadatas** | [**RequestMetadataInfo[]**](RequestMetadataInfo.md) |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**SiteMaxDepth** | **Int32** |  | [optional] [default to null]
**WarningExpiredTimeDate** | **Int32** |  | [optional] [default to null]
**WarningExpiredTimeDateType** | **Int32** |  | [optional] [default to null]
**ExpiredTimeDate** | **Int32** |  | [optional] [default to null]
**ExpiredTimeDateType** | **Int32** |  | [optional] [default to null]
**ExpiredTimeDateWorkflowTemplate** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ExpirationPeriodWorkflowStage** | [**ApprovalProcessStageCollection**](ApprovalProcessStageCollection.md) |  | [optional] [default to null]
**QuotaSize** | **Int64** |  | [optional] [default to null]
**ServerResourceQuota** | **Double** |  | [optional] [default to null]
**CaOrAdminCenterUrl** | **String** |  | [optional] [default to null]
**ApplyPolicy** | [**ApplyPolicyInfo**](ApplyPolicyInfo.md) |  | [optional] [default to null]
**AppliedDeploymentPlans** | **String** |  | [optional] [default to null]
**AdditionalActionTime** | **System.DateTime** |  | [optional] [default to null]
**QuotaThresholdWarningTimes** | **Int32** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSiteProperty  -Department null `
 -Policy null `
 -CustomMetadatas null `
 -Title null `
 -Description null `
 -SiteMaxDepth null `
 -WarningExpiredTimeDate null `
 -WarningExpiredTimeDateType null `
 -ExpiredTimeDate null `
 -ExpiredTimeDateType null `
 -ExpiredTimeDateWorkflowTemplate null `
 -ExpirationPeriodWorkflowStage null `
 -QuotaSize null `
 -ServerResourceQuota null `
 -CaOrAdminCenterUrl null `
 -ApplyPolicy null `
 -AppliedDeploymentPlans null `
 -AdditionalActionTime null `
 -QuotaThresholdWarningTimes null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

