# SPRoleAssignment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**LoginName** | **String** |  | [optional] [default to null]
**PrincipalType** | [**SPPrincipalType**](SPPrincipalType.md) |  | [optional] [default to null]
**PrincipalTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**PermissionLevels** | **String[]** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSPRoleAssignment  -Id null `
 -Name null `
 -LoginName null `
 -PrincipalType null `
 -PrincipalTypeDescription null `
 -PermissionLevels null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

