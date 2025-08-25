# SiteLifecycleServiceChangePolicySetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDateType** | **Int32** |  | [optional] [default to 0]
**SpecifyDateTicks** | **Int64** |  | [optional] [default to 0]
**ChangePolicyConfig** | **Int32** |  | [optional] [default to 0]
**IsAllowAutoCancel** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$SiteLifecycleServiceChangePolicySetting = New-Cloud.Governance.ClientSiteLifecycleServiceChangePolicySetting  -StartDateType null `
 -SpecifyDateTicks null `
 -ChangePolicyConfig null `
 -IsAllowAutoCancel null
```

- Convert the resource to JSON
```powershell
$SiteLifecycleServiceChangePolicySetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

