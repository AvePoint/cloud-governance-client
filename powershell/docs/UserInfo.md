# UserInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentityName** | **String** |  | [optional] 
**UserDisplayName** | **String** |  | [optional] 
**DomainGroup** | **Boolean** |  | [optional] [default to $false]
**Department** | **String** |  | [optional] 
**MobilePhone** | **String** |  | [optional] 
**Manager** | **String** |  | [optional] 
**Permission** | **String** |  | [optional] 
**IsDeleted** | **Boolean** |  | [optional] [default to $false]
**SecurityToken** | **String** |  | [optional] 
**UserType** | **Int32** |  | [optional] [default to 0]
**AzureUserType** | **String** |  | [optional] 
**LegalPerson** | **Boolean** |  | [optional] [default to $false]
**AuthenticationType** | [**AuthenticationType**](AuthenticationType.md) |  | [optional] 
**AdminCenterUrl** | **String** |  | [optional] 
**InviteType** | [**InviteType**](InviteType.md) |  | [optional] 
**Type** | **String** |  | [optional] 
**IsRegisteredAosGroup** | **Boolean** |  | [optional] [default to $false]
**IsExternalUser** | [**ExternalUserType**](ExternalUserType.md) |  | [optional] 
**IsAPIExceptional** | **Boolean** |  | [optional] [default to $false]
**TenantId** | **String** |  | [optional] 
**ObjectId** | **String** |  | [optional] 
**Version** | **Int32** |  | [optional] [default to 0]
**JobTitle** | **String** |  | [optional] 
**UsageLocation** | **String** |  | [optional] 
**PhysicalDeliveryOfficeName** | **String** |  | [optional] 
**IsOtherTenantUser** | **Boolean** |  | [optional] [default to $false]
**IsAccountEnabled** | **Boolean** |  | [optional] [default to $false]
**NetworkId** | **String** |  | [optional] 
**IsValidateByProfile** | **Boolean** |  | [optional] [default to $false]
**ProxyAddresses** | **String[]** |  | [optional] 
**PrincipalType** | [**PrincipalType**](PrincipalType.md) |  | [optional] 
**Inviter** | **String** |  | [optional] 
**CreatedTime** | **System.DateTime** |  | [optional] 
**LastModifiedTime** | **System.DateTime** |  | [optional] 
**Id** | **Int32** |  | [optional] [default to 0]
**DisplayName** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ExistInAOS** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$UserInfo = New-Cloud.Governance.ClientUserInfo  -IdentityName null `
 -UserDisplayName null `
 -DomainGroup null `
 -Department null `
 -MobilePhone null `
 -Manager null `
 -Permission null `
 -IsDeleted null `
 -SecurityToken null `
 -UserType null `
 -AzureUserType null `
 -LegalPerson null `
 -AuthenticationType null `
 -AdminCenterUrl null `
 -InviteType null `
 -Type null `
 -IsRegisteredAosGroup null `
 -IsExternalUser null `
 -IsAPIExceptional null `
 -TenantId null `
 -ObjectId null `
 -Version null `
 -JobTitle null `
 -UsageLocation null `
 -PhysicalDeliveryOfficeName null `
 -IsOtherTenantUser null `
 -IsAccountEnabled null `
 -NetworkId null `
 -IsValidateByProfile null `
 -ProxyAddresses null `
 -PrincipalType null `
 -Inviter null `
 -CreatedTime null `
 -LastModifiedTime null `
 -Id null `
 -DisplayName null `
 -Title null `
 -Email null `
 -IsValid null `
 -ExistInAOS null
```

- Convert the resource to JSON
```powershell
$UserInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

