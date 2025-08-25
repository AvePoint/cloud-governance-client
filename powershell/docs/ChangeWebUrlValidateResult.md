# ChangeWebUrlValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | [**ChangeWebSettingRequestUrl**](ChangeWebSettingRequestUrl.md) |  | [optional] 
**WebTitle** | **String** |  | [optional] 
**WebDescription** | **String** |  | [optional] 
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeWebUrlValidateResult = New-Cloud.Governance.ClientChangeWebUrlValidateResult  -Url null `
 -WebTitle null `
 -WebDescription null `
 -Metadatas null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeWebUrlValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

