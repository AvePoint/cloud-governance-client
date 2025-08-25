# TextModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** |  | [optional] 
**Id** | **String** | StringModel ID | [optional] 
**Name** | **String** | StringModel name | [optional] 

## Examples

- Prepare the resource
```powershell
$TextModel = New-Cloud.Governance.ClientTextModel  -Description null `
 -Id null `
 -Name null
```

- Convert the resource to JSON
```powershell
$TextModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

