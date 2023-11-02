# EmailAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Prefix** | **String** |  | [optional] 
**GroupEmailAddress** | **String** |  | [optional] 
**Suffix** | **String** |  | [optional] 
**Domain** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$EmailAddress = New-Cloud.Governance.ClientEmailAddress  -Prefix null `
 -GroupEmailAddress null `
 -Suffix null `
 -Domain null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$EmailAddress | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

