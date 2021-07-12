# CreateWebUrlValidationResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentWebUrl** | **String** |  | [optional] 
**ParentSiteUrl** | **String** |  | [optional] 
**SitePrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SiteSecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateWebUrlValidationResult = New-Cloud.Governance.ClientCreateWebUrlValidationResult  -ParentWebUrl null `
 -ParentSiteUrl null `
 -SitePrimaryContact null `
 -SiteSecondaryContact null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$CreateWebUrlValidationResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

