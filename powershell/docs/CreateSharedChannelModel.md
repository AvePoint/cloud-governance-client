# CreateSharedChannelModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeamId** | **String** |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**TeamName** | **String** |  | [optional] 
**TeamEmail** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSharedChannelModel = New-Cloud.Governance.ClientCreateSharedChannelModel  -TeamId null `
 -OfficeTenantId null `
 -TeamName null `
 -TeamEmail null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateSharedChannelModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

