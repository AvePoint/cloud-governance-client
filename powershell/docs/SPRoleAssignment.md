# SPRoleAssignment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] 
**Name** | **String** |  | [optional] 
**LoginName** | **String** |  | [optional] 
**PrincipalType** | [**SPPrincipalType**](SPPrincipalType.md) |  | [optional] 
**PrincipalTypeDescription** | **String** |  | [optional] 
**PermissionLevels** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SPRoleAssignment = New-Cloud.Governance.ClientSPRoleAssignment  -Id null `
 -Name null `
 -LoginName null `
 -PrincipalType null `
 -PrincipalTypeDescription null `
 -PermissionLevels null
```

- Convert the resource to JSON
```powershell
$SPRoleAssignment | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

