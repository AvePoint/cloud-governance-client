# IntModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IntModel = New-Cloud.Governance.ClientIntModel  -Id null `
 -Name null `
 -Description null
```

- Convert the resource to JSON
```powershell
$IntModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

