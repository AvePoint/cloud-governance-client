# DeploymentManagerPlanSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [default to $false]
**Plans** | **String[]** |  | [optional] 
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**Default** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$DeploymentManagerPlanSettings = New-Cloud.Governance.ClientDeploymentManagerPlanSettings  -Enabled null `
 -Plans null `
 -AssignBy null `
 -Default null
```

- Convert the resource to JSON
```powershell
$DeploymentManagerPlanSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

