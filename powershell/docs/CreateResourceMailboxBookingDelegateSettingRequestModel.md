# CreateResourceMailboxBookingDelegateSettingRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestType** | [**BookingRequestType**](BookingRequestType.md) |  | [optional] 
**Members** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PredefinedMembers** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateResourceMailboxBookingDelegateSettingRequestModel = New-Cloud.Governance.ClientCreateResourceMailboxBookingDelegateSettingRequestModel  -RequestType null `
 -Members null `
 -PredefinedMembers null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateResourceMailboxBookingDelegateSettingRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

