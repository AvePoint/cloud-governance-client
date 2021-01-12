# StringChangedProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeValue** | **String** |  | [optional] 
**OriginalValue** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StringChangedProperty = New-Cloud.Governance.ClientStringChangedProperty  -ChangeValue null `
 -OriginalValue null
```

- Convert the resource to JSON
```powershell
$StringChangedProperty | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

