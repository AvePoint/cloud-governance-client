# ChangePolicyActionSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDateType** | **Int32** |  | [optional] 
**SpecifyDateTicks** | **Int64** |  | [optional] 
**ChangePolicyConfig** | **Int32** |  | [optional] 
**IsAllowAutoCancel** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangePolicyActionSetting = New-Cloud.Governance.ClientChangePolicyActionSetting  -StartDateType null `
 -SpecifyDateTicks null `
 -ChangePolicyConfig null `
 -IsAllowAutoCancel null
```

- Convert the resource to JSON
```powershell
$ChangePolicyActionSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

