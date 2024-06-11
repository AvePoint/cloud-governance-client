# ManualImportEnvironmentJobModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | [**ImportObjectType**](ImportObjectType.md) |  | [optional] 
**Workspaces** | [**ImportEnvironmentModel[]**](ImportEnvironmentModel.md) |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**FileName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManualImportEnvironmentJobModel = New-Cloud.Governance.ClientManualImportEnvironmentJobModel  -ObjectType null `
 -Workspaces null `
 -Name null `
 -Description null `
 -FileName null
```

- Convert the resource to JSON
```powershell
$ManualImportEnvironmentJobModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

