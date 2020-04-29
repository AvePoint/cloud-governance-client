# ChangePermissionValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SiteUrl** | **String** |  | [optional] [default to null]
**WebId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**WebServerRelativeUrl** | **String** |  | [optional] [default to null]
**ListTitle** | **String** |  | [optional] [default to null]
**ObjectUrl** | **String** |  | [optional] [default to null]
**IsInherit** | **Boolean** |  | [optional] [default to null]
**InheritNodeType** | [**NodeType**](NodeType.md) |  | [optional] [default to null]
**TopInheritUrl** | **String** |  | [optional] [default to null]
**CheckType** | [**NodeType**](NodeType.md) |  | [optional] [default to null]
**IsValid** | **Boolean** |  | [optional] [readonly] [default to null]
**ErrorMessage** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangePermissionValidateResult  -SiteId null `
 -SiteUrl null `
 -WebId null `
 -WebServerRelativeUrl null `
 -ListTitle null `
 -ObjectUrl null `
 -IsInherit null `
 -InheritNodeType null `
 -TopInheritUrl null `
 -CheckType null `
 -IsValid null `
 -ErrorMessage null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

