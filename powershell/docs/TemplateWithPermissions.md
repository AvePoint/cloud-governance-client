# TemplateWithPermissions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateId** | **String** |  | [optional] 
**IsUseCommon** | **Boolean** |  | [optional] [default to $false]
**UserPermissions** | [**ServiceUserWithPermissions[]**](ServiceUserWithPermissions.md) |  | [optional] 
**GroupPermissions** | [**ServiceGroupWithPermissions[]**](ServiceGroupWithPermissions.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TemplateWithPermissions = New-Cloud.Governance.ClientTemplateWithPermissions  -TemplateId null `
 -IsUseCommon null `
 -UserPermissions null `
 -GroupPermissions null
```

- Convert the resource to JSON
```powershell
$TemplateWithPermissions | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

