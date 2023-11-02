# ManualImportPowerBIJobModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | [**ImportObjectType**](ImportObjectType.md) |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**FileName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManualImportPowerBIJobModel = New-Cloud.Governance.ClientManualImportPowerBIJobModel  -ObjectType null `
 -Name null `
 -Description null `
 -FileName null
```

- Convert the resource to JSON
```powershell
$ManualImportPowerBIJobModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

