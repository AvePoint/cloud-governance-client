# DynamicChangeContactModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NewPrimaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**NewSecondaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**OriginalPrimaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**OriginalSecondaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$DynamicChangeContactModel = New-Cloud.Governance.ClientDynamicChangeContactModel  -NewPrimaryContact null `
 -NewSecondaryContact null `
 -OriginalPrimaryContact null `
 -OriginalSecondaryContact null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$DynamicChangeContactModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

