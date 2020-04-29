# SiteInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FullUrl** | **String** |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**HubSiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**IsHubSite** | **Boolean** |  | [optional] [default to null]
**HubSiteTitle** | **String** |  | [optional] [default to null]
**WebAppId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**IsOnlineSite** | **Boolean** |  | [optional] [default to null]
**PrimarySiteContact** | **String** |  | [optional] [default to null]
**PrimarySiteContactIdentityName** | **String** |  | [optional] [default to null]
**PrimarySiteContactEmail** | **String** |  | [optional] [default to null]
**SecondarySiteContact** | **String** |  | [optional] [default to null]
**SecondarySiteContactIdentityName** | **String** |  | [optional] [default to null]
**SecondarySiteContactEmail** | **String** |  | [optional] [default to null]
**SiteOwner** | **String** |  | [optional] [default to null]
**SiteOwnerEmail** | **String** |  | [optional] [default to null]
**CreatedTime** | **System.DateTime** |  | [optional] [default to null]
**Status** | [**SiteStatus**](SiteStatus.md) |  | [optional] [default to null]
**SecondaryAdmin** | **String** |  | [optional] [default to null]
**AdditionalAdmin** | **String** |  | [optional] [default to null]
**AdditionalAdminEmail** | **String** |  | [optional] [default to null]
**FarmId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ModifiedTime** | **System.DateTime** |  | [optional] [default to null]
**HostHeader** | **String** |  | [optional] [default to null]
**RootWebId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**QuotaTemplateName** | **String** |  | [optional] [default to null]
**Size** | **Int64** |  | [optional] [default to null]
**SizeValue** | [**SizeValue**](SizeValue.md) |  | [optional] [default to null]
**ManagedPath** | **String** |  | [optional] [default to null]
**IsDeleted** | **Int32** |  | [optional] [default to null]
**RequestId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ContentDBName** | **String** |  | [optional] [default to null]
**PolicyId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**LifecycleActionLockId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**AutoLifecycleLockId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SiteTemplate** | **String** |  | [optional] [default to null]
**SiteTemplateTitle** | **String** |  | [optional] [default to null]
**ServerRelativeUrl** | **String** |  | [optional] [default to null]
**TimeLastChecked** | **System.DateTime** |  | [optional] [default to null]
**LastAccessedTime** | **System.DateTime** |  | [optional] [default to null]
**NoAccessThreshold** | **System.DateTime** |  | [optional] [default to null]
**ExpiredThreshold** | **System.DateTime** |  | [optional] [default to null]
**Properties** | [**SiteProperty**](SiteProperty.md) |  | [optional] [default to null]
**QuotaSize** | **Double** |  | [optional] [default to null]
**RecurrenceProperties** | [**SiteRecertificationProperty**](SiteRecertificationProperty.md) |  | [optional] [default to null]
**ClaimStatus** | [**ClaimStatus**](ClaimStatus.md) |  | [optional] [default to null]
**LockProperties** | [**LockSiteInfo**](LockSiteInfo.md) |  | [optional] [default to null]
**EnableManualArchive** | **Boolean** |  | [optional] [default to null]
**Phase** | **Int32** |  | [optional] [default to null]
**PhaseTime** | **System.DateTime** |  | [optional] [default to null]
**AutoImportProfileId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SharingCapabilities** | **Int32** |  | [optional] [default to null]
**AccessThresholdExpirationDate** | **System.DateTime** |  | [optional] [default to null]
**LeasePeriodExpirationDate** | **System.DateTime** |  | [optional] [default to null]
**PermissionRecertificationStatus** | **Int32** |  | [optional] [default to null]
**OwnershipRecertificationStatus** | **Int32** |  | [optional] [default to null]
**MetadataRecertificationStatus** | **Int32** |  | [optional] [default to null]
**SharingCapabilitiesDesc** | **String** |  | [optional] [readonly] [default to null]
**ExtensionProperties** | **Hashtable** |  | [optional] [default to null]
**PhaseTimeDisplay** | **String** |  | [optional] [default to null]
**CurrentRenewers** | **String** |  | [optional] [default to null]
**RenewDueDate** | **System.DateTime** |  | [optional] [default to null]
**AutoImportProfileName** | **String** |  | [optional] [default to null]
**PhaseDisplay** | [**AutoImportPhase**](AutoImportPhase.md) |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**Department** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**PolicyName** | **String** |  | [optional] [default to null]
**MaxDepth** | **Int32** |  | [optional] [default to null]
**QuotaSizeValue** | **Int64** |  | [optional] [default to null]
**ApplyPolicyStatus** | [**ApplyPolicyStatus**](ApplyPolicyStatus.md) |  | [optional] [default to null]
**AppliedDeploymentPlans** | **String** |  | [optional] [default to null]
**Location** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSiteInfo  -FullUrl null `
 -Id null `
 -HubSiteId null `
 -IsHubSite null `
 -HubSiteTitle null `
 -WebAppId null `
 -IsOnlineSite null `
 -PrimarySiteContact null `
 -PrimarySiteContactIdentityName null `
 -PrimarySiteContactEmail null `
 -SecondarySiteContact null `
 -SecondarySiteContactIdentityName null `
 -SecondarySiteContactEmail null `
 -SiteOwner null `
 -SiteOwnerEmail null `
 -CreatedTime null `
 -Status null `
 -SecondaryAdmin null `
 -AdditionalAdmin null `
 -AdditionalAdminEmail null `
 -FarmId null `
 -ModifiedTime null `
 -HostHeader null `
 -RootWebId null `
 -QuotaTemplateName null `
 -Size null `
 -SizeValue null `
 -ManagedPath null `
 -IsDeleted null `
 -RequestId null `
 -ContentDBName null `
 -PolicyId null `
 -LifecycleActionLockId null `
 -AutoLifecycleLockId null `
 -SiteTemplate null `
 -SiteTemplateTitle null `
 -ServerRelativeUrl null `
 -TimeLastChecked null `
 -LastAccessedTime null `
 -NoAccessThreshold null `
 -ExpiredThreshold null `
 -Properties null `
 -QuotaSize null `
 -RecurrenceProperties null `
 -ClaimStatus null `
 -LockProperties null `
 -EnableManualArchive null `
 -Phase null `
 -PhaseTime null `
 -AutoImportProfileId null `
 -SharingCapabilities null `
 -AccessThresholdExpirationDate null `
 -LeasePeriodExpirationDate null `
 -PermissionRecertificationStatus null `
 -OwnershipRecertificationStatus null `
 -MetadataRecertificationStatus null `
 -SharingCapabilitiesDesc null `
 -ExtensionProperties null `
 -PhaseTimeDisplay null `
 -CurrentRenewers null `
 -RenewDueDate null `
 -AutoImportProfileName null `
 -PhaseDisplay null `
 -Title null `
 -Department null `
 -Description null `
 -PolicyName null `
 -MaxDepth null `
 -QuotaSizeValue null `
 -ApplyPolicyStatus null `
 -AppliedDeploymentPlans null `
 -Location null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

