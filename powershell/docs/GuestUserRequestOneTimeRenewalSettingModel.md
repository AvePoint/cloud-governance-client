# GuestUserRequestOneTimeRenewalSettingModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Option** | [**OneTimeRenewalOption**](OneTimeRenewalOption.md) |  | [optional] 
**Duration** | **Int32** |  | [optional] [default to 0]
**DurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**StartTime** | **System.DateTime** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GuestUserRequestOneTimeRenewalSettingModel = New-Cloud.Governance.ClientGuestUserRequestOneTimeRenewalSettingModel  -Option null `
 -Duration null `
 -DurationType null `
 -StartTime null
```

- Convert the resource to JSON
```powershell
$GuestUserRequestOneTimeRenewalSettingModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

