# ServicePermissionItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PermissionType** | [**ServicePermissionType**](ServicePermissionType.md) |  | [optional] [default to null]
**Value** | **String** |  | [optional] [default to null]
**TenantId** | **String** |  | [optional] [default to null]
**PropertyInputType** | [**AadPropertyInputType**](AadPropertyInputType.md) |  | [optional] [default to null]
**PermissionId** | **String** |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientServicePermissionItem  -PermissionType null `
 -Value null `
 -TenantId null `
 -PropertyInputType null `
 -PermissionId null `
 -Name null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

