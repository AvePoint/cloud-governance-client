# SPRoleAssignment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] [default to 0]
**Name** | **String** |  | [optional] 
**LoginName** | **String** |  | [optional] 
**AzureUserType** | **String** |  | [optional] 
**PrincipalType** | [**SPPrincipalType**](SPPrincipalType.md) |  | [optional] 
**PrincipalTypeDescription** | **String** |  | [optional] 
**PermissionLevels** | **String[]** |  | [optional] 
**TemporaryPermissionSetting** | [**GrantPermissionModelPermissionDurationSettings**](GrantPermissionModelPermissionDurationSettings.md) |  | [optional] 
**ObjectId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SPRoleAssignment = New-Cloud.Governance.ClientSPRoleAssignment  -Id null `
 -Name null `
 -LoginName null `
 -AzureUserType null `
 -PrincipalType null `
 -PrincipalTypeDescription null `
 -PermissionLevels null `
 -TemporaryPermissionSetting null `
 -ObjectId null
```

- Convert the resource to JSON
```powershell
$SPRoleAssignment | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

