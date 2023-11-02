# Office365Tenant
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**ActivityType** | **String** |  | [optional] 
**Type** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**RunAfter** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$Office365Tenant = New-Cloud.Governance.ClientOffice365Tenant  -Id null `
 -ActivityType null `
 -Type null `
 -Title null `
 -Description null `
 -RunAfter null
```

- Convert the resource to JSON
```powershell
$Office365Tenant | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

