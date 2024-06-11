# CreateResourceMailboxContactInformationRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Location** | **String** |  | [optional] 
**Phone** | **String** |  | [optional] 
**Street** | **String** |  | [optional] 
**City** | **String** |  | [optional] 
**Zip** | **String** |  | [optional] 
**Country** | [**StringModel**](StringModel.md) |  | [optional] 
**Notes** | **String** |  | [optional] 
**State** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateResourceMailboxContactInformationRequestModel = New-Cloud.Governance.ClientCreateResourceMailboxContactInformationRequestModel  -Location null `
 -Phone null `
 -Street null `
 -City null `
 -Zip null `
 -Country null `
 -Notes null `
 -State null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateResourceMailboxContactInformationRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

