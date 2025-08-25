# SiteLifecycleValidateResultLockSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableLockAsNoAccess** | **Boolean** |  | [optional] [default to $false]
**EnableLockAsReadonly** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$SiteLifecycleValidateResultLockSetting = New-Cloud.Governance.ClientSiteLifecycleValidateResultLockSetting  -EnableLockAsNoAccess null `
 -EnableLockAsReadonly null
```

- Convert the resource to JSON
```powershell
$SiteLifecycleValidateResultLockSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

