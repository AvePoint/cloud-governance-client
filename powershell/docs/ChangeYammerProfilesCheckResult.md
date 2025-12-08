# ChangeYammerProfilesCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**IsAppliedPolicy** | **Boolean** |  | [optional] [default to $false]
**OriginalPolicy** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**HasOngoingRenewTask** | **Boolean** |  | [optional] [default to $false]
**HasOngoingElectionTask** | **Boolean** |  | [optional] [default to $false]
**OriginalExternalSharingProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalStorageManagementProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalContactElectionProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalRenewalProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**TeamSiteUrl** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**Sensitivity** | [**StringModel**](StringModel.md) | StringModel model | [optional] 
**YammerPrivacy** | **Boolean** |  | [optional] [default to $false]
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeYammerProfilesCheckResult = New-Cloud.Governance.ClientChangeYammerProfilesCheckResult  -TenantId null `
 -IsAppliedPolicy null `
 -OriginalPolicy null `
 -HasOngoingRenewTask null `
 -HasOngoingElectionTask null `
 -OriginalExternalSharingProfile null `
 -OriginalStorageManagementProfile null `
 -OriginalContactElectionProfile null `
 -OriginalRenewalProfile null `
 -TeamSiteUrl null `
 -Classification null `
 -Sensitivity null `
 -YammerPrivacy null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeYammerProfilesCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

