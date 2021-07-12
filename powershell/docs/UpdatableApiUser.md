# UpdatableApiUser
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **String** |  | [optional] 
**JobTitle** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**PeopleFilterProfileId** | **String** |  | [optional] 
**ApiUserType** | [**ApiUserType**](ApiUserType.md) |  | [optional] 
**UserSource** | [**UserSource**](UserSource.md) |  | [optional] 
**Id** | **String** | Object ID | [optional] 
**LoginName** | **String** | Login name | [optional] 
**IsExternalUser** | [**ExternalUserType**](ExternalUserType.md) | Whether the user is an external user. | [optional] 
**AzureUserType** | **String** | User type in Azure AD | [optional] 
**DisplayName** | **String** | User display name | [optional] 
**IsGroup** | **Boolean** | Whether an object is a domain group. | [optional] [default to $false]
**IsLocalUser** | **Boolean** | Whether the user is a local system user. | [optional] [readonly] [default to $false]
**PhysicalDeliveryOfficeName** | **String** | Physical delivery office name of the user | [optional] [readonly] 
**IsValid** | **Boolean** | Whether the user is valid. | [optional] [readonly] [default to $false]
**AdditionalData** | [**System.Collections.Hashtable**](AnyType.md) | User additional data | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$UpdatableApiUser = New-Cloud.Governance.ClientUpdatableApiUser  -Email null `
 -JobTitle null `
 -TenantId null `
 -PeopleFilterProfileId null `
 -ApiUserType null `
 -UserSource null `
 -Id null `
 -LoginName null `
 -IsExternalUser null `
 -AzureUserType null `
 -DisplayName null `
 -IsGroup null `
 -IsLocalUser null `
 -PhysicalDeliveryOfficeName null `
 -IsValid null `
 -AdditionalData null
```

- Convert the resource to JSON
```powershell
$UpdatableApiUser | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

