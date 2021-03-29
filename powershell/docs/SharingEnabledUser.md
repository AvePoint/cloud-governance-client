# SharingEnabledUser
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsSharePointGroup** | **Boolean** |  | [optional] [default to $false]
**IsGuestUser** | **Boolean** |  | [optional] [default to $false]
**IsGuestUserExistsInOrganization** | **Boolean** |  | [optional] [default to $false]
**Id** | **String** |  | [optional] 
**LoginName** | **String** |  | [optional] 
**IsExternalUser** | [**ExternalUserType**](ExternalUserType.md) |  | [optional] 
**AzureUserType** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**IsGroup** | **Boolean** |  | [optional] [default to $false]
**IsLocalUser** | **Boolean** |  | [optional] [readonly] [default to $false]
**Email** | **String** |  | [optional] 
**JobTitle** | **String** |  | [optional] [readonly] 
**PhysicalDeliveryOfficeName** | **String** |  | [optional] [readonly] 
**IsValid** | **Boolean** |  | [optional] [readonly] [default to $false]
**TenantId** | **String** |  | [optional] [readonly] 
**AdditionalData** | [**System.Collections.Hashtable**](AnyType.md) |  | [optional] [readonly] 
**ApiUserType** | [**ApiUserType**](ApiUserType.md) |  | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$SharingEnabledUser = New-Cloud.Governance.ClientSharingEnabledUser  -IsSharePointGroup null `
 -IsGuestUser null `
 -IsGuestUserExistsInOrganization null `
 -Id null `
 -LoginName null `
 -IsExternalUser null `
 -AzureUserType null `
 -DisplayName null `
 -IsGroup null `
 -IsLocalUser null `
 -Email null `
 -JobTitle null `
 -PhysicalDeliveryOfficeName null `
 -IsValid null `
 -TenantId null `
 -AdditionalData null `
 -ApiUserType null
```

- Convert the resource to JSON
```powershell
$SharingEnabledUser | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

