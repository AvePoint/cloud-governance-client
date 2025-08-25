# SPGroupOwner
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] [default to 0]
**LoginName** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**PrincipalType** | [**SPPrincipalType**](SPPrincipalType.md) |  | [optional] 
**AzureUserType** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SPGroupOwner = New-Cloud.Governance.ClientSPGroupOwner  -Id null `
 -LoginName null `
 -Name null `
 -PrincipalType null `
 -AzureUserType null
```

- Convert the resource to JSON
```powershell
$SPGroupOwner | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

