# SharingEnabledUser
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsSharePointGroup** | **Boolean** |  | [optional] 
**IsGuestUser** | **Boolean** |  | [optional] 
**IsGuestUserExistsInOrganization** | **Boolean** |  | [optional] 
**Id** | **String** |  | [optional] 
**LoginName** | **String** |  | [optional] 
**IsExternalUser** | [**ExternalUserType**](ExternalUserType.md) |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**IsGroup** | **Boolean** |  | [optional] 
**IsLocalUser** | **Boolean** |  | [optional] [readonly] 
**Email** | **String** |  | [optional] 
**JobTitle** | **String** |  | [optional] [readonly] 
**PhysicalDeliveryOfficeName** | **String** |  | [optional] [readonly] 
**IsValid** | **Boolean** |  | [optional] [readonly] 
**TenantId** | **String** |  | [optional] [readonly] 
**AdditionalData** | [**System.Collections.Hashtable**](AnyType.md) |  | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$SharingEnabledUser = New-Cloud.Governance.ClientSharingEnabledUser  -IsSharePointGroup null `
 -IsGuestUser null `
 -IsGuestUserExistsInOrganization null `
 -Id null `
 -LoginName null `
 -IsExternalUser null `
 -DisplayName null `
 -IsGroup null `
 -IsLocalUser null `
 -Email null `
 -JobTitle null `
 -PhysicalDeliveryOfficeName null `
 -IsValid null `
 -TenantId null `
 -AdditionalData null
```

- Convert the resource to JSON
```powershell
$SharingEnabledUser | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

