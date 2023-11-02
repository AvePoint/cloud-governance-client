# DynamicExchangeResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **String** |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**GroupName** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**ExchangeResourceType** | [**ExchangeResourceType**](ExchangeResourceType.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$DynamicExchangeResource = New-Cloud.Governance.ClientDynamicExchangeResource  -GroupId null `
 -OfficeTenantId null `
 -GroupName null `
 -Email null `
 -ExchangeResourceType null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$DynamicExchangeResource | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

