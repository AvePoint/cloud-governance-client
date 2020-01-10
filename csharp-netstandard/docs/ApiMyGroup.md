# Cloud.Governance.Client.Model.ApiMyGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **string** |  | [optional] 
**PolicyId** | **Guid** |  | [optional] 
**TenantId** | **Guid** |  | [optional] 
**GroupName** | **string** |  | [optional] 
**Email** | **string** |  | [optional] 
**Language** | **string** |  | [optional] 
**ApplyPolicyStatus** | **int** |  | [optional] 
**EnableTeamCollaboration** | **bool** |  | [optional] 
**GroupType** | **string** |  | [optional] [readonly] 
**CreatedTime** | **DateTime?** |  | [optional] 
**Owners** | [**List&lt;ApiUser&gt;**](ApiUser.md) |  | [optional] 
**PreferredDataLocation** | **string** |  | [optional] 
**PreferredDataLocationName** | **string** |  | [optional] [readonly] 
**Id** | **Guid** |  | [optional] 
**Phase** | **AutoImportPhase** |  | [optional] 
**PhaseStartTime** | **DateTime?** |  | [optional] 
**PhaseDescription** | **string** |  | [optional] [readonly] 
**AutoImportProfileId** | **Guid?** |  | [optional] 
**AutoImportProfileName** | **string** |  | [optional] 
**PolicyName** | **string** |  | [optional] 
**PolicyDescription** | **string** |  | [optional] 
**IsCurrentRenewer** | **bool** |  | [optional] 
**PhaseAssignees** | [**List&lt;ApiUser&gt;**](ApiUser.md) |  | [optional] 
**PhaseDueDate** | **DateTime?** |  | [optional] 
**Metadatas** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

