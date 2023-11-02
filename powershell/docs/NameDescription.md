# NameDescription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** |  | [optional] 
**Prefix** | **String** |  | [optional] 
**Suffix** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$NameDescription = New-Cloud.Governance.ClientNameDescription  -Name null `
 -Prefix null `
 -Suffix null `
 -Description null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$NameDescription | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

