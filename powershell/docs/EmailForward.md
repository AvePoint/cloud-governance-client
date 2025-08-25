# EmailForward
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableEmailForwarding** | **Boolean** |  | [optional] [default to $false]
**ConvertEmailForward** | [**ConvertEmail**](ConvertEmail.md) |  | [optional] 
**ForwardInternalEmailAddress** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**ForwardExternalEmailAddress** | **String** |  | [optional] 
**EnableDeliverMessage** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$EmailForward = New-Cloud.Governance.ClientEmailForward  -EnableEmailForwarding null `
 -ConvertEmailForward null `
 -ForwardInternalEmailAddress null `
 -ForwardExternalEmailAddress null `
 -EnableDeliverMessage null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$EmailForward | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

