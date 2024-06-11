# DeliveryManagement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SpecifiedSenders** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PredefinedSpecifiedSenders** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**SenderOptions** | [**SenderOptions**](SenderOptions.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$DeliveryManagement = New-Cloud.Governance.ClientDeliveryManagement  -SpecifiedSenders null `
 -PredefinedSpecifiedSenders null `
 -SenderOptions null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$DeliveryManagement | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

