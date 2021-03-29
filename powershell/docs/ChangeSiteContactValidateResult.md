# ChangeSiteContactValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**PrimaryAdministrator** | [**ApiUser**](ApiUser.md) |  | [optional] 
**AdditionalAdministrators** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteContactValidateResult = New-Cloud.Governance.ClientChangeSiteContactValidateResult  -SiteId null `
 -SiteUrl null `
 -PrimaryContact null `
 -SecondaryContact null `
 -PrimaryAdministrator null `
 -AdditionalAdministrators null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeSiteContactValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

