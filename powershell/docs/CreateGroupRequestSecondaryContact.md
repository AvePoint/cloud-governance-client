# CreateGroupRequestSecondaryContact
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** | Object ID | [optional] 
**LoginName** | **String** | Login name | [optional] 
**IsExternalUser** | [**ExternalUserType**](ExternalUserType.md) | Whether the user is an external user. | [optional] 
**AzureUserType** | **String** | User type in Azure AD | [optional] 
**DisplayName** | **String** | User display name | [optional] 
**IsGroup** | **Boolean** | Whether an object is a domain group. | [optional] [default to $false]
**IsLocalUser** | **Boolean** | Whether the user is a local system user. | [optional] [readonly] [default to $false]
**Email** | **String** | User e-mail address | [optional] 
**JobTitle** | **String** | User job title | [optional] [readonly] 
**PhysicalDeliveryOfficeName** | **String** | Physical delivery office name of the user | [optional] [readonly] 
**IsValid** | **Boolean** | Whether the user is valid. | [optional] [readonly] [default to $false]
**IsAccountEnabled** | **Boolean** | Whether the user is valid. | [optional] [readonly] [default to $false]
**TenantId** | **String** | Office 365 tenant ID of the user | [optional] [readonly] 
**AdditionalData** | [**System.Collections.Hashtable**](AnyType.md) | User additional data | [optional] [readonly] 
**ApiUserType** | [**ApiUserType**](ApiUserType.md) | ApiUser type | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$CreateGroupRequestSecondaryContact = New-Cloud.Governance.ClientCreateGroupRequestSecondaryContact  -Id null `
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
 -IsAccountEnabled null `
 -TenantId null `
 -AdditionalData null `
 -ApiUserType null
```

- Convert the resource to JSON
```powershell
$CreateGroupRequestSecondaryContact | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

