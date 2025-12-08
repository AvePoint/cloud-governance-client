# ChangeYammerSettingsCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsAppliedPolicy** | **Boolean** |  | [optional] [default to $false]
**OriginalPolicy** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**HasOngoingRenewTask** | **Boolean** |  | [optional] [default to $false]
**HasOngoingElectionTask** | **Boolean** |  | [optional] [default to $false]
**OriginalExternalSharingProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalStorageManagementProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalContactElectionProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalRenewalProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**YammerSiteUrl** | **String** |  | [optional] 
**IsSiteLocked** | **Boolean** |  | [optional] [default to $false]
**YammerPrivacy** | **Boolean** |  | [optional] [default to $false]
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsHiddenFromAddressListsEnabled** | **Boolean** |  | [optional] [default to $false]
**IsHideFromOutlookClientsEnabled** | **Boolean** |  | [optional] [default to $false]
**IsHaveExchangePermission** | **Boolean** |  | [optional] [default to $false]
**IsAssignableToRole** | **Boolean** |  | [optional] [default to $false]
**YammerName** | **String** |  | [optional] 
**YammerDescription** | **String** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**Owners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Members** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**CoOwners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**SiteTitle** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**IsEnableSensitivityLabel** | **Boolean** |  | [optional] [default to $false]
**SiteUrl** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**Sensitivity** | [**StringModel**](StringModel.md) | StringModel model | [optional] 
**Privacy** | **Boolean** |  | [optional] [default to $false]
**EnvironmentName** | **String** |  | [optional] 
**WorkspaceTypeWithValidated** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**IsHybrid** | **Boolean** |  | [optional] [default to $false]
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeYammerSettingsCheckResult = New-Cloud.Governance.ClientChangeYammerSettingsCheckResult  -IsAppliedPolicy null `
 -OriginalPolicy null `
 -HasOngoingRenewTask null `
 -HasOngoingElectionTask null `
 -OriginalExternalSharingProfile null `
 -OriginalStorageManagementProfile null `
 -OriginalContactElectionProfile null `
 -OriginalRenewalProfile null `
 -YammerSiteUrl null `
 -IsSiteLocked null `
 -YammerPrivacy null `
 -Metadatas null `
 -IsHiddenFromAddressListsEnabled null `
 -IsHideFromOutlookClientsEnabled null `
 -IsHaveExchangePermission null `
 -IsAssignableToRole null `
 -YammerName null `
 -YammerDescription null `
 -PrimaryContact null `
 -SecondaryContact null `
 -Owners null `
 -Members null `
 -CoOwners null `
 -SiteTitle null `
 -SiteId null `
 -Classification null `
 -IsEnableSensitivityLabel null `
 -SiteUrl null `
 -TenantId null `
 -Sensitivity null `
 -Privacy null `
 -EnvironmentName null `
 -WorkspaceTypeWithValidated null `
 -IsHybrid null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeYammerSettingsCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

