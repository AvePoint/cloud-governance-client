# RequestUserWithPermissions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**User** | [**ApiUser**](ApiUser.md) |  | [optional] 
**PermissionLevels** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RequestUserWithPermissions = New-Cloud.Governance.ClientRequestUserWithPermissions  -User null `
 -PermissionLevels null
```

- Convert the resource to JSON
```powershell
$RequestUserWithPermissions | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

