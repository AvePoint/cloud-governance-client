# ChangePermissionRequestObjectProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**WebId** | **String** |  | [optional] 
**WebServerRelativeUrl** | **String** |  | [optional] 
**ListTitle** | **String** |  | [optional] 
**ObjectUrl** | **String** |  | [optional] 
**IsInherit** | **Boolean** |  | [optional] [default to $false]
**InheritNodeType** | [**TreeNodeType**](TreeNodeType.md) |  | [optional] 
**TopInheritUrl** | **String** |  | [optional] 
**CheckType** | [**TreeNodeType**](TreeNodeType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangePermissionRequestObjectProperty = New-Cloud.Governance.ClientChangePermissionRequestObjectProperty  -SiteId null `
 -SiteUrl null `
 -WebId null `
 -WebServerRelativeUrl null `
 -ListTitle null `
 -ObjectUrl null `
 -IsInherit null `
 -InheritNodeType null `
 -TopInheritUrl null `
 -CheckType null
```

- Convert the resource to JSON
```powershell
$ChangePermissionRequestObjectProperty | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

