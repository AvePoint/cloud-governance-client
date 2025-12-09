# ChangeDistributionGroupSettingsCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ValidDomains** | **String[]** |  | [optional] 
**GroupObjectId** | **String** |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**GroupDisplayName** | **String** |  | [optional] 
**GroupDescription** | **String** |  | [optional] 
**PrimarySmtpAddress** | **String** |  | [optional] 
**EmailAddresses** | **String[]** |  | [optional] 
**HiddenFromAddressListsEnabled** | **Boolean** |  | [optional] [default to $false]
**RequireSenderAuthenticationEnabled** | **Boolean** |  | [optional] [default to $false]
**SendAsPermissions** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**SendOnBehalfPermissions** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**SpecifiedSenders** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeDistributionGroupSettingsCheckResult = New-Cloud.Governance.ClientChangeDistributionGroupSettingsCheckResult  -ValidDomains null `
 -GroupObjectId null `
 -OfficeTenantId null `
 -GroupDisplayName null `
 -GroupDescription null `
 -PrimarySmtpAddress null `
 -EmailAddresses null `
 -HiddenFromAddressListsEnabled null `
 -RequireSenderAuthenticationEnabled null `
 -SendAsPermissions null `
 -SendOnBehalfPermissions null `
 -SpecifiedSenders null `
 -Metadatas null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeDistributionGroupSettingsCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

