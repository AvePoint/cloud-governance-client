# Cloud.Governance.Client.Model.ChangeSiteProfilesCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Office365TenantId** | **Guid** |  | [optional] 
**IsAppliedPolicy** | **bool** |  | [optional] [default to false]
**OriginalPolicy** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**HasOngoingRenewTask** | **bool** |  | [optional] [default to false]
**HasOngoingElectionTask** | **bool** |  | [optional] [default to false]
**OriginalExternalSharingProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalStorageManagementProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalContactElectionProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalRenewalProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**SiteUrl** | **string** |  | [optional] 
**Classification** | **string** |  | [optional] 
**Sensitivity** | [**StringModel**](StringModel.md) | StringModel model | [optional] 
**Privacy** | **bool** |  | [optional] [default to false]
**SiteTitle** | **string** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**IsValid** | **bool** |  | [optional] [default to false]
**ErrorMessage** | **string** |  | [optional] 
**MessageCode** | **MessageCode** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

