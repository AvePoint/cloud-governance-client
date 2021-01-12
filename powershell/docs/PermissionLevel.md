# PermissionLevel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**IdInSharePoint** | **Int32** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] [readonly] 
**IsExcluded** | **Boolean** |  | [optional] [readonly] 
**Type** | **Int32** |  | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$PermissionLevel = New-Cloud.Governance.ClientPermissionLevel  -Id null `
 -IdInSharePoint null `
 -Name null `
 -Description null `
 -IsExcluded null `
 -Type null
```

- Convert the resource to JSON
```powershell
$PermissionLevel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

