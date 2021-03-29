# BooleanChangedProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeValue** | **Boolean** |  | [optional] [default to $false]
**OriginalValue** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$BooleanChangedProperty = New-Cloud.Governance.ClientBooleanChangedProperty  -ChangeValue null `
 -OriginalValue null
```

- Convert the resource to JSON
```powershell
$BooleanChangedProperty | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

