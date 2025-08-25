# ApplyGroupPolicyModelLifecycleRenewalSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeaseDateType** | [**LeaseDateType**](LeaseDateType.md) |  | [optional] 
**StartDateType** | [**LeaseStartDateType**](LeaseStartDateType.md) |  | [optional] 
**SpecifyStartDate** | **System.DateTime** |  | [optional] 
**HandleOngoingType** | [**HandleOngoingType**](HandleOngoingType.md) |  | [optional] 
**IsSendCancelEmail** | **Boolean** |  | [optional] [default to $false]
**CancelEmailTemplateId** | **String** |  | [optional] 
**CancelEmailTemplateName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplyGroupPolicyModelLifecycleRenewalSetting = New-Cloud.Governance.ClientApplyGroupPolicyModelLifecycleRenewalSetting  -LeaseDateType null `
 -StartDateType null `
 -SpecifyStartDate null `
 -HandleOngoingType null `
 -IsSendCancelEmail null `
 -CancelEmailTemplateId null `
 -CancelEmailTemplateName null
```

- Convert the resource to JSON
```powershell
$ApplyGroupPolicyModelLifecycleRenewalSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

