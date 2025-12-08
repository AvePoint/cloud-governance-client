# GuestLifecycleValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GuestId** | **String** |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GuestLifecycleValidationParameter = New-Cloud.Governance.ClientGuestLifecycleValidationParameter  -GuestId null `
 -OfficeTenantId null
```

- Convert the resource to JSON
```powershell
$GuestLifecycleValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

