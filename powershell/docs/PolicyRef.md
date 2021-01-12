# PolicyRef
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Category** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$PolicyRef = New-Cloud.Governance.ClientPolicyRef  -Id null `
 -Name null `
 -Description null `
 -Category null `
 -TenantId null `
 -Status null
```

- Convert the resource to JSON
```powershell
$PolicyRef | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

