# DeploymentManagerPlanSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [default to null]
**Plans** | **String[]** |  | [optional] [default to null]
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**Default** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientDeploymentManagerPlanSettings  -Enabled null `
 -Plans null `
 -AssignBy null `
 -Default null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

