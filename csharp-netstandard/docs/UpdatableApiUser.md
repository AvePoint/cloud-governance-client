# Cloud.Governance.Client.Model.UpdatableApiUser
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** |  | [optional] 
**JobTitle** | **string** |  | [optional] 
**TenantId** | **string** |  | [optional] 
**PeopleFilterProfileId** | **Guid?** |  | [optional] 
**ApiUserType** | **ApiUserType** |  | [optional] 
**UserSource** | **UserSource** |  | [optional] 
**Id** | **string** | Object ID | [optional] 
**LoginName** | **string** | Login name | [optional] 
**IsExternalUser** | **ExternalUserType** | Whether the user is an external user. | [optional] 
**AzureUserType** | **string** | User type in Azure AD | [optional] 
**DisplayName** | **string** | User display name | [optional] 
**IsGroup** | **bool** | Whether an object is a domain group. | [optional] [default to false]
**IsLocalUser** | **bool** | Whether the user is a local system user. | [optional] [readonly] [default to false]
**PhysicalDeliveryOfficeName** | **string** | Physical delivery office name of the user | [optional] [readonly] 
**IsValid** | **bool** | Whether the user is valid. | [optional] [readonly] [default to false]
**AdditionalData** | **Dictionary&lt;string, Object&gt;** | User additional data | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

