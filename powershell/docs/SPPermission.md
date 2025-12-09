# SPPermission
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SpGroups** | [**SPGroup[]**](SPGroup.md) |  | [optional] 
**SpRoleAssignments** | [**SPRoleAssignment[]**](SPRoleAssignment.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SPPermission = New-Cloud.Governance.ClientSPPermission  -SpGroups null `
 -SpRoleAssignments null
```

- Convert the resource to JSON
```powershell
$SPPermission | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

