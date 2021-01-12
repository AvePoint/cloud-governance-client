# UserInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentityName** | **String** |  | [optional] 
**UserDisplayName** | **String** |  | [optional] 
**DomainGroup** | **Boolean** |  | [optional] 
**Department** | **String** |  | [optional] 
**MobilePhone** | **String** |  | [optional] 
**Manager** | **String** |  | [optional] 
**Permission** | **String** |  | [optional] 
**IsDeleted** | **Boolean** |  | [optional] 
**SecurityToken** | **String** |  | [optional] 
**UserType** | **Int32** |  | [optional] 
**AzureUserType** | **String** |  | [optional] 
**LegalPerson** | **Boolean** |  | [optional] 
**AuthenticationType** | [**AuthenticationType**](AuthenticationType.md) |  | [optional] 
**AdminCenterUrl** | **String** |  | [optional] 
**InviteType** | [**InviteType**](InviteType.md) |  | [optional] 
**Type** | **String** |  | [optional] 
**IsRegisteredAosGroup** | **Boolean** |  | [optional] 
**IsExternalUser** | [**ExternalUserType**](ExternalUserType.md) |  | [optional] 
**IsAPIExceptional** | **Boolean** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**ObjectId** | **String** |  | [optional] 
**Version** | **Int32** |  | [optional] 
**JobTitle** | **String** |  | [optional] 
**UsageLocation** | **String** |  | [optional] 
**PhysicalDeliveryOfficeName** | **String** |  | [optional] 
**IsOtherTenantUser** | **Boolean** |  | [optional] 
**NetworkId** | **String** |  | [optional] 
**IsValidateByProfile** | **Boolean** |  | [optional] 
**ProxyAddresses** | **String[]** |  | [optional] 
**Id** | **Int32** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**IsValid** | **Boolean** |  | [optional] 
**ExistInAOS** | **Boolean** |  | [optional] 

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
 -NetworkId null `
 -IsValidateByProfile null `
 -ProxyAddresses null `
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

