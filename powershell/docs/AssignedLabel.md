# AssignedLabel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LabelId** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**FullName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AssignedLabel = New-Cloud.Governance.ClientAssignedLabel  -LabelId null `
 -DisplayName null `
 -FullName null
```

- Convert the resource to JSON
```powershell
$AssignedLabel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

