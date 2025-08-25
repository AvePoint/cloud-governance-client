# CreateGuestUserRequestOneTimeSettings
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
$CreateGuestUserRequestOneTimeSettings = New-Cloud.Governance.ClientCreateGuestUserRequestOneTimeSettings  -Option null `
 -Duration null `
 -DurationType null `
 -StartTime null
```

- Convert the resource to JSON
```powershell
$CreateGuestUserRequestOneTimeSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

