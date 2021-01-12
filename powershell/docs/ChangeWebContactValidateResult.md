# ChangeWebContactValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**WebId** | **String** |  | [optional] 
**WebUrl** | **String** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] 
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeWebContactValidateResult = New-Cloud.Governance.ClientChangeWebContactValidateResult  -SiteId null `
 -SiteUrl null `
 -WebId null `
 -WebUrl null `
 -PrimaryContact null `
 -SecondaryContact null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeWebContactValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

