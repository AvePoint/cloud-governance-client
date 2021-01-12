# SPPrincipal
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] 
**LoginName** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**PrincipalType** | [**SPPrincipalType**](SPPrincipalType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SPPrincipal = New-Cloud.Governance.ClientSPPrincipal  -Id null `
 -LoginName null `
 -Name null `
 -PrincipalType null
```

- Convert the resource to JSON
```powershell
$SPPrincipal | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

