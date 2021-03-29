# GrantPermissionGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] [default to 0]
**Name** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**PermissionIds** | **String[]** |  | [optional] 
**Description** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GrantPermissionGroup = New-Cloud.Governance.ClientGrantPermissionGroup  -Id null `
 -Name null `
 -DisplayName null `
 -PermissionIds null `
 -Description null
```

- Convert the resource to JSON
```powershell
$GrantPermissionGroup | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

