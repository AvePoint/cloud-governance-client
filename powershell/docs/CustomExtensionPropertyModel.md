# CustomExtensionPropertyModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyName** | **String** |  | [optional] 
**PropertyDataType** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CustomExtensionPropertyModel = New-Cloud.Governance.ClientCustomExtensionPropertyModel  -PropertyName null `
 -PropertyDataType null
```

- Convert the resource to JSON
```powershell
$CustomExtensionPropertyModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

