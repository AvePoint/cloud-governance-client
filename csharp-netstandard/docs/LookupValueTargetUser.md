# Cloud.Governance.Client.Model.LookupValueTargetUser
Lookup user
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Object ID | [optional] 
**LoginName** | **string** | Login name | [optional] 
**IsExternalUser** | **ExternalUserType** |  | [optional] 
**AzureUserType** | **string** | User type in Azure AD | [optional] 
**DisplayName** | **string** | User display name | [optional] 
**IsGroup** | **bool** | Whether an object is a domain group. | [optional] [default to false]
**IsLocalUser** | **bool** | Whether the user is a local system user. | [optional] [readonly] [default to false]
**Email** | **string** | User e-mail address | [optional] 
**JobTitle** | **string** | User job title | [optional] [readonly] 
**PhysicalDeliveryOfficeName** | **string** | Physical delivery office name of the user | [optional] [readonly] 
**IsValid** | **bool** | Whether the user is valid. | [optional] [readonly] [default to false]
**TenantId** | **string** | Office 365 tenant ID of the user | [optional] [readonly] 
**AdditionalData** | **Dictionary&lt;string, Object&gt;** | User additional data | [optional] [readonly] 
**ApiUserType** | **ApiUserType** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

