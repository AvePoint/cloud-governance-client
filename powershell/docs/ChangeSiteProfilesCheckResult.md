# ChangeSiteProfilesCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Office365TenantId** | **String** |  | [optional] 
**IsAppliedPolicy** | **Boolean** |  | [optional] [default to $false]
**OriginalPolicy** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**HasOngoingRenewTask** | **Boolean** |  | [optional] [default to $false]
**HasOngoingElectionTask** | **Boolean** |  | [optional] [default to $false]
**OriginalExternalSharingProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalStorageManagementProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalContactElectionProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalRenewalProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**SiteUrl** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**Sensitivity** | [**StringModel**](StringModel.md) | StringModel model | [optional] 
**Privacy** | **Boolean** |  | [optional] [default to $false]
**SiteTitle** | **String** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteProfilesCheckResult = New-Cloud.Governance.ClientChangeSiteProfilesCheckResult  -Office365TenantId null `
 -IsAppliedPolicy null `
 -OriginalPolicy null `
 -HasOngoingRenewTask null `
 -HasOngoingElectionTask null `
 -OriginalExternalSharingProfile null `
 -OriginalStorageManagementProfile null `
 -OriginalContactElectionProfile null `
 -OriginalRenewalProfile null `
 -SiteUrl null `
 -Classification null `
 -Sensitivity null `
 -Privacy null `
 -SiteTitle null `
 -PrimaryContact null `
 -SecondaryContact null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeSiteProfilesCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

