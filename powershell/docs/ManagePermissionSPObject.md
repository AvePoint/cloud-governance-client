# ManagePermissionSPObject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentUrl** | **String** |  | [optional] 
**ParentNodeType** | [**NodeType**](NodeType.md) |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**WebUrl** | **String** |  | [optional] 
**PrimaryAdministrator** | [**ApiUser**](ApiUser.md) |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**TemporaryGroupTitle** | **String** |  | [optional] 
**WebId** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 
**WebServerRelativeUrl** | **String** |  | [optional] 
**ListTitle** | **String** |  | [optional] 
**TopInheritUrl** | **String** |  | [optional] 
**InheritNodeType** | [**NodeType**](NodeType.md) |  | [optional] 
**IsInheritedPermission** | **Boolean** |  | [optional] 
**Id** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**FullUrl** | **String** |  | [optional] 
**Type** | [**NodeType**](NodeType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManagePermissionSPObject = New-Cloud.Governance.ClientManagePermissionSPObject  -ParentUrl null `
 -ParentNodeType null `
 -SiteUrl null `
 -WebUrl null `
 -PrimaryAdministrator null `
 -PrimaryContact null `
 -SecondaryContact null `
 -TemporaryGroupTitle null `
 -WebId null `
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

- Convert the resource to JSON
```powershell
$ManagePermissionSPObject | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

