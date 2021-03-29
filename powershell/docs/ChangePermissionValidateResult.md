# ChangePermissionValidateResult
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
**InheritNodeType** | [**NodeType**](NodeType.md) |  | [optional] 
**TopInheritUrl** | **String** |  | [optional] 
**CheckType** | [**NodeType**](NodeType.md) |  | [optional] 
**UserMetadata** | [**System.Collections.Hashtable**](UserInfo.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangePermissionValidateResult = New-Cloud.Governance.ClientChangePermissionValidateResult  -SiteId null `
 -SiteUrl null `
 -WebId null `
 -WebServerRelativeUrl null `
 -ListTitle null `
 -ObjectUrl null `
 -IsInherit null `
 -InheritNodeType null `
 -TopInheritUrl null `
 -CheckType null `
 -UserMetadata null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangePermissionValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

