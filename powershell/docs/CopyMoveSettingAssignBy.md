# CopyMoveSettingAssignBy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SecurityAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**ContentAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CopyMoveSettingAssignBy = New-Cloud.Governance.ClientCopyMoveSettingAssignBy  -ConfigurationAssignBy null `
 -SecurityAssignBy null `
 -ContentAssignBy null
```

- Convert the resource to JSON
```powershell
$CopyMoveSettingAssignBy | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

