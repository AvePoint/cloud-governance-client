# Int64ChangedProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeValue** | **Int64** |  | [optional] [default to 0]
**OriginalValue** | **Int64** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$Int64ChangedProperty = New-Cloud.Governance.ClientInt64ChangedProperty  -ChangeValue null `
 -OriginalValue null
```

- Convert the resource to JSON
```powershell
$Int64ChangedProperty | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

