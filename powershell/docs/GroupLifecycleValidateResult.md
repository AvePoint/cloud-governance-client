# GroupLifecycleValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApprovalProcessHasManagerRole** | **Boolean** |  | [optional] [default to $false]
**ExtendSetting** | [**GroupLifecycleValidateResultExtendSetting**](GroupLifecycleValidateResultExtendSetting.md) |  | [optional] 
**ChangePolicySetting** | [**GroupLifecycleValidateResultChangePolicySetting**](GroupLifecycleValidateResultChangePolicySetting.md) |  | [optional] 
**ChangeQuotaSetting** | [**GroupLifecycleValidateResultChangeQuotaSetting**](GroupLifecycleValidateResultChangeQuotaSetting.md) |  | [optional] 
**EnableTeamCollaboration** | **Boolean** |  | [optional] [default to $false]
**GroupObjectType** | [**GroupObjectType**](GroupObjectType.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GroupLifecycleValidateResult = New-Cloud.Governance.ClientGroupLifecycleValidateResult  -ApprovalProcessHasManagerRole null `
 -ExtendSetting null `
 -ChangePolicySetting null `
 -ChangeQuotaSetting null `
 -EnableTeamCollaboration null `
 -GroupObjectType null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$GroupLifecycleValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

