# PermissionLevel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** | Permission level ID | [optional] 
**IdInSharePoint** | **Int32** | Permission ID in SharePoint | [optional] [default to 0]
**Name** | **String** | Permission name | [optional] 
**Description** | **String** | Permission description | [optional] [readonly] 
**IsExcluded** | **Boolean** | Whether the permission is excluded. | [optional] [readonly] [default to $false]
**Type** | **Int32** | Permission type | [optional] [readonly] [default to 0]

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

