# CreateGuestUserSubRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] [readonly] 
**UserProperties** | [**CreateGuestUserRequestUserProperties**](CreateGuestUserRequestUserProperties.md) |  | [optional] 
**WelcomeEmailMessage** | **String** |  | [optional] 
**PrimaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**SecondaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**InviteGroups** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**OneTimeSettings** | [**CreateGuestUserRequestOneTimeSettings**](CreateGuestUserRequestOneTimeSettings.md) |  | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**ProcessStatus** | [**ApiRequestProgressStatus**](ApiRequestProgressStatus.md) |  | [optional] [readonly] 
**AssignTo** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**ModifiedBy** | **String** |  | [optional] 
**ModifiedByDisplayName** | **String** |  | [optional] 
**ModifiedDate** | **System.DateTime** |  | [optional] 

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
 -AssignTo null `
 -ModifiedBy null `
 -ModifiedByDisplayName null `
 -ModifiedDate null
```

- Convert the resource to JSON
```powershell
$CreateGuestUserSubRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

