# UpdatableApiUser
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **String** |  | [optional] 
**JobTitle** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**PeopleFilterProfileId** | **String** |  | [optional] 
**ApiUserType** | [**ApiUserType**](ApiUserType.md) |  | [optional] 
**Id** | **String** |  | [optional] 
**LoginName** | **String** |  | [optional] 
**IsExternalUser** | [**ExternalUserType**](ExternalUserType.md) |  | [optional] 
**AzureUserType** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**IsGroup** | **Boolean** |  | [optional] [default to $false]
**IsLocalUser** | **Boolean** |  | [optional] [readonly] [default to $false]
**PhysicalDeliveryOfficeName** | **String** |  | [optional] [readonly] 
**IsValid** | **Boolean** |  | [optional] [readonly] [default to $false]
**AdditionalData** | [**System.Collections.Hashtable**](AnyType.md) |  | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$UpdatableApiUser = New-Cloud.Governance.ClientUpdatableApiUser  -Email null `
 -JobTitle null `
 -TenantId null `
 -PeopleFilterProfileId null `
 -ApiUserType null `
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

