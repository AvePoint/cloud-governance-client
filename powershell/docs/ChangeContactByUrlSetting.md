# ChangeContactByUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**OriginalPrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**NewPrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**OriginalSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**NewSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**OriginalPrimaryAdministrator** | [**ApiUser**](ApiUser.md) |  | [optional] 
**NewPrimaryAdministrator** | [**ApiUser**](ApiUser.md) |  | [optional] 
**OriginalAdditionalAdministrators** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**NewAdditionalAdministrators** | [**ApiUser[]**](ApiUser.md) |  | [optional] 

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
 -NewAdditionalAdministrators null
```

- Convert the resource to JSON
```powershell
$ChangeContactByUrlSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

