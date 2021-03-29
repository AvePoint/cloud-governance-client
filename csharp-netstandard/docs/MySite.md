# Cloud.Governance.Client.Model.MySite
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FullUrl** | **string** |  | [optional] 
**Title** | **string** |  | [optional] 
**Department** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Size** | **long?** |  | [optional] [default to 0]
**QuotaSize** | **long** |  | [optional] [default to 0]
**Type** | **MySiteType** |  | [optional] 
**MySiteType** | **string** |  | [optional] 
**Classification** | **string** |  | [optional] 
**Sensitivity** | **string** |  | [optional] 
**IsCommunicationSite** | **bool** |  | [optional] [default to false]
**CreatedTime** | **DateTime** |  | [optional] 
**StorageUsed** | **string** |  | [optional] 
**PrimaryAdministrator** | [**ApiUser**](ApiUser.md) |  | [optional] 
**AdditionalAdministrator** | [**List&lt;ApiUser&gt;**](ApiUser.md) |  | [optional] 
**PreferredDataLocation** | **string** |  | [optional] 
**PreferredDataLocationName** | **string** |  | [optional] 
**Id** | **Guid** |  | [optional] 
**Phase** | **AutoImportPhase** |  | [optional] 
**PhaseStartTime** | **DateTime?** |  | [optional] 
**PhaseDescription** | **string** |  | [optional] 
**AutoImportProfileId** | **Guid?** |  | [optional] 
**AutoImportProfileName** | **string** |  | [optional] 
**PolicyName** | **string** |  | [optional] 
**PolicyDescription** | **string** |  | [optional] 
**IsCurrentRenewer** | **bool** |  | [optional] [default to false]
**PhaseAssignees** | [**List&lt;ApiUser&gt;**](ApiUser.md) |  | [optional] 
**PhaseDueDate** | **DateTime?** |  | [optional] 
**Metadatas** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**ErrorMessage** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

