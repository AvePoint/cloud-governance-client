# WebLifecycleValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebId** | **String** |  | [optional] 
**WebUrl** | **String** |  | [optional] 
**WebRelativeUrl** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WebLifecycleValidateResult = New-Cloud.Governance.ClientWebLifecycleValidateResult  -WebId null `
 -WebUrl null `
 -WebRelativeUrl null `
 -SiteId null `
 -SiteUrl null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$WebLifecycleValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

