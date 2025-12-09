# ChangeContactByUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**OriginalPrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**NewPrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**OriginalSecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**NewSecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**OriginalPrimaryAdministrator** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**NewPrimaryAdministrator** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**OriginalAdditionalAdministrators** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**NewAdditionalAdministrators** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**SiteTitle** | **String** | Site Title | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeContactByUrlSetting = New-Cloud.Governance.ClientChangeContactByUrlSetting  -SiteId null `
 -SiteUrl null `
 -OriginalPrimaryContact null `
 -NewPrimaryContact null `
 -OriginalSecondaryContact null `
 -NewSecondaryContact null `
 -OriginalPrimaryAdministrator null `
 -NewPrimaryAdministrator null `
 -OriginalAdditionalAdministrators null `
 -NewAdditionalAdministrators null `
 -SiteTitle null
```

- Convert the resource to JSON
```powershell
$ChangeContactByUrlSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

