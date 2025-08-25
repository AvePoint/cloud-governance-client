# ChangeSiteContactSubRequestAdminContactSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**OriginalPrimaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**NewPrimaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**OriginalSecondaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**NewSecondaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**OriginalPrimaryAdministrator** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**NewPrimaryAdministrator** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**OriginalAdditionalAdministrators** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**NewAdditionalAdministrators** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**SiteTitle** | **String** | Site Title | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteContactSubRequestAdminContactSettings = New-Cloud.Governance.ClientChangeSiteContactSubRequestAdminContactSettings  -SiteId null `
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
$ChangeSiteContactSubRequestAdminContactSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

