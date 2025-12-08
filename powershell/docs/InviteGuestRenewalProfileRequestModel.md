# InviteGuestRenewalProfileRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OneTimeRenewalSetting** | [**InviteGuestOneTimeRenewalSettingModel**](InviteGuestOneTimeRenewalSettingModel.md) |  | [optional] 
**Value** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**ValueDisplayName** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$InviteGuestRenewalProfileRequestModel = New-Cloud.Governance.ClientInviteGuestRenewalProfileRequestModel  -OneTimeRenewalSetting null `
 -Value null `
 -Description null `
 -ValueDisplayName null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$InviteGuestRenewalProfileRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

