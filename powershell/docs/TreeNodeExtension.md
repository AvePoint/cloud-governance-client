# TreeNodeExtension
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Size** | **Int32** |  | [optional] 
**UserName** | **String** |  | [optional] 
**Password** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TreeNodeExtension = New-Cloud.Governance.ClientTreeNodeExtension  -Size null `
 -UserName null `
 -Password null
```

- Convert the resource to JSON
```powershell
$TreeNodeExtension | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

