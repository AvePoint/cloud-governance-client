# GuidModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** | Object ID | [optional] 
**Name** | **String** | Object name | [optional] 
**Description** | **String** | Object description | [optional] 

## Examples

- Prepare the resource
```powershell
$GuidModel = New-Cloud.Governance.ClientGuidModel  -Id null `
 -Name null `
 -Description null
```

- Convert the resource to JSON
```powershell
$GuidModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

