# ServiceGroupWithPermissions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UsersAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**GroupOwnerAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**AllowChangePermissionLevel** | **Boolean** |  | [optional] [default to $false]
**Removable** | **Boolean** |  | [optional] [default to $false]
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Users** | [**GroupUser[]**](GroupUser.md) |  | [optional] 
**PermissionLevels** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] 
**GroupOwner** | [**ApiUser**](ApiUser.md) |  | [optional] 
**GroupOwnerType** | [**GroupOwnerType**](GroupOwnerType.md) |  | [optional] 
**BuildInGroupType** | [**SharePointBuildInGroupType**](SharePointBuildInGroupType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ServiceGroupWithPermissions = New-Cloud.Governance.ClientServiceGroupWithPermissions  -UsersAssignBy null `
 -GroupOwnerAssignBy null `
 -AllowChangePermissionLevel null `
 -Removable null `
 -Name null `
 -Description null `
 -Users null `
 -PermissionLevels null `
 -GroupOwner null `
 -GroupOwnerType null `
 -BuildInGroupType null
```

- Convert the resource to JSON
```powershell
$ServiceGroupWithPermissions | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

