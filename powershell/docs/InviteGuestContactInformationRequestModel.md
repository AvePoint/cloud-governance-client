# InviteGuestContactInformationRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessPhone** | **String** |  | [optional] 
**FaxNumber** | **String** |  | [optional] 
**MobilePhone** | **String** |  | [optional] 
**Street** | **String** |  | [optional] 
**City** | **String** |  | [optional] 
**Zip** | **String** |  | [optional] 
**Country** | **String** |  | [optional] 
**State** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$InviteGuestContactInformationRequestModel = New-Cloud.Governance.ClientInviteGuestContactInformationRequestModel  -BusinessPhone null `
 -FaxNumber null `
 -MobilePhone null `
 -Street null `
 -City null `
 -Zip null `
 -Country null `
 -State null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$InviteGuestContactInformationRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

