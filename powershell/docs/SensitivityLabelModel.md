# SensitivityLabelModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tenant** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**ParentName** | **String** |  | [optional] 
**Id** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SensitivityLabelModel = New-Cloud.Governance.ClientSensitivityLabelModel  -Tenant null `
 -Name null `
 -ParentName null `
 -Id null
```

- Convert the resource to JSON
```powershell
$SensitivityLabelModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

