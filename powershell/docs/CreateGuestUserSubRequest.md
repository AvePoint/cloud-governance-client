# CreateGuestUserSubRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] [readonly] 
**UserProperties** | [**GuestUserPropertyModel**](GuestUserPropertyModel.md) |  | [optional] 
**WelcomeEmailMessage** | **String** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**InviteGroups** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**OneTimeSettings** | [**GuestUserRequestOneTimeRenewalSettingModel**](GuestUserRequestOneTimeRenewalSettingModel.md) |  | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**ProcessStatus** | [**ApiRequestProgressStatus**](ApiRequestProgressStatus.md) |  | [optional] [readonly] 
**AssignTo** | [**ApiUser[]**](ApiUser.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateGuestUserSubRequest = New-Cloud.Governance.ClientCreateGuestUserSubRequest  -Id null `
 -UserProperties null `
 -WelcomeEmailMessage null `
 -PrimaryContact null `
 -SecondaryContact null `
 -InviteGroups null `
 -OneTimeSettings null `
 -Metadatas null `
 -ProcessStatus null `
 -AssignTo null
```

- Convert the resource to JSON
```powershell
$CreateGuestUserSubRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

