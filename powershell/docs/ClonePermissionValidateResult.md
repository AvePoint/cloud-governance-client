# ClonePermissionValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ClonePermissionValidateResult = New-Cloud.Governance.ClientClonePermissionValidateResult  -SiteId null `
 -SiteUrl null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ClonePermissionValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

