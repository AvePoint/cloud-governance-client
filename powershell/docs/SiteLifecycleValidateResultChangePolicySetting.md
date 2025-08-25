# SiteLifecycleValidateResultChangePolicySetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentPolicy** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
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
$SiteLifecycleValidateResultChangePolicySetting = New-Cloud.Governance.ClientSiteLifecycleValidateResultChangePolicySetting  -CurrentPolicy null `
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
$SiteLifecycleValidateResultChangePolicySetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

