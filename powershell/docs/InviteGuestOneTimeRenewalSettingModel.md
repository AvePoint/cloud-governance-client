# InviteGuestOneTimeRenewalSettingModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Option** | [**OneTimeRenewalOption**](OneTimeRenewalOption.md) |  | [optional] 
**Duration** | **Int32** |  | [optional] [default to 0]
**DurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**StartTime** | **System.DateTime** |  | [optional] 
**IsEnabled** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$InviteGuestOneTimeRenewalSettingModel = New-Cloud.Governance.ClientInviteGuestOneTimeRenewalSettingModel  -Option null `
 -Duration null `
 -DurationType null `
 -StartTime null `
 -IsEnabled null
```

- Convert the resource to JSON
```powershell
$InviteGuestOneTimeRenewalSettingModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

