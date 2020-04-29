# GrantPermissionSPObject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**WebServerRelativeUrl** | **String** |  | [optional] [default to null]
**ListTitle** | **String** |  | [optional] [default to null]
**TopInheritUrl** | **String** |  | [optional] [default to null]
**InheritNodeType** | [**NodeType**](NodeType.md) |  | [optional] [default to null]
**IsInheritedPermission** | **Boolean** |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**FullUrl** | **String** |  | [optional] [default to null]
**Type** | [**NodeType**](NodeType.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGrantPermissionSPObject  -WebId null `
 -SiteId null `
 -WebServerRelativeUrl null `
 -ListTitle null `
 -TopInheritUrl null `
 -InheritNodeType null `
 -IsInheritedPermission null `
 -Id null `
 -Title null `
 -FullUrl null `
 -Type null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

