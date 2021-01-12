# GuidBooleanModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] 
**SeletedItem** | **String** |  | [optional] 
**AllItems** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GuidBooleanModel = New-Cloud.Governance.ClientGuidBooleanModel  -Enabled null `
 -SeletedItem null `
 -AllItems null
```

- Convert the resource to JSON
```powershell
$GuidBooleanModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

