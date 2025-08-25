# RequestGroupWithPermissions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Group name | [optional] 
**Description** | **String** | Group description | [optional] 
**Users** | [**GroupUser[]**](GroupUser.md) | The list of the group users | [optional] 
**PermissionLevels** | [**PermissionLevel[]**](PermissionLevel.md) | The list of the group permission levels | [optional] 
**GroupOwner** | [**RequestGroupWithPermissionsGroupOwner**](RequestGroupWithPermissionsGroupOwner.md) |  | [optional] 
**GroupOwnerType** | [**GroupOwnerType**](GroupOwnerType.md) | Group owner type | [optional] 
**BuildInGroupType** | [**SharePointBuildInGroupType**](SharePointBuildInGroupType.md) | Built-in group type | [optional] 
**SpGroupViewType** | [**SPGroupViewOptionType**](SPGroupViewOptionType.md) |  | [optional] 
**SpGroupEditType** | [**SPGroupEditOptionType**](SPGroupEditOptionType.md) |  | [optional] 
**SpGroupEditOptionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SpGroupViewOptionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RequestGroupWithPermissions = New-Cloud.Governance.ClientRequestGroupWithPermissions  -Name null `
 -Description null `
 -Users null `
 -PermissionLevels null `
 -GroupOwner null `
 -GroupOwnerType null `
 -BuildInGroupType null `
 -SpGroupViewType null `
 -SpGroupEditType null `
 -SpGroupEditOptionAssignBy null `
 -SpGroupViewOptionAssignBy null
```

- Convert the resource to JSON
```powershell
$RequestGroupWithPermissions | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

