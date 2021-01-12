# ApiCredential
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientSecret** | **String** |  | [optional] 
**UserPrincipalName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApiCredential = New-Cloud.Governance.ClientApiCredential  -ClientSecret null `
 -UserPrincipalName null
```

- Convert the resource to JSON
```powershell
$ApiCredential | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

