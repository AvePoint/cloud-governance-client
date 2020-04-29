# SiteList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**Url** | **String** |  | [optional] [default to null]
**Department** | **String** |  | [optional] [default to null]
**PolicyName** | **String** |  | [optional] [default to null]
**PolicyId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Template** | **String** |  | [optional] [default to null]
**Owner** | **String** |  | [optional] [default to null]
**OwnerDisplayName** | **String** |  | [optional] [default to null]
**PrimaryContact** | **String** |  | [optional] [default to null]
**PrimaryContactDisplayName** | **String** |  | [optional] [default to null]
**SecondaryContact** | **String** |  | [optional] [default to null]
**SecondaryContactDisplayName** | **String** |  | [optional] [default to null]
**AdditionalAdministrators** | **String** |  | [optional] [default to null]
**AdditionalAdministratorDisplayNames** | **String** |  | [optional] [default to null]
**CreatedTime** | **String** |  | [optional] [default to null]
**Status** | [**SiteStatus**](SiteStatus.md) |  | [optional] [default to null]
**StatusDescription** | **String** |  | [optional] [readonly] [default to null]
**ClaimStatus** | [**ClaimStatus**](ClaimStatus.md) |  | [optional] [default to null]
**ClaimStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**Sharing** | [**SharingCapabilities**](SharingCapabilities.md) |  | [optional] [default to null]
**SharingDescription** | **String** |  | [optional] [readonly] [default to null]
**StorageQuota** | **Int64** |  | [optional] [default to null]
**StorageUsed** | **Int64** |  | [optional] [default to null]
**InactivityThresholdTime** | **System.DateTime** |  | [optional] [default to null]
**LeaseExpirationTime** | **System.DateTime** |  | [optional] [default to null]
**PermissionRecertificationStatus** | [**RecertificationStatus**](RecertificationStatus.md) |  | [optional] [default to null]
**PermissionRecertificationStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**MetadataRecertificationStatus** | [**RecertificationStatus**](RecertificationStatus.md) |  | [optional] [default to null]
**MetadataRecertificationStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**OwnershipRecertificationStatus** | [**RecertificationStatus**](RecertificationStatus.md) |  | [optional] [default to null]
**OwnershipRecertificationStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**GeoLocation** | **String** |  | [optional] [default to null]
**GeoLocationDescription** | **String** |  | [optional] [readonly] [default to null]
**Hub** | **String** |  | [optional] [default to null]
**Phase** | [**AutoImportPhase**](AutoImportPhase.md) |  | [optional] [default to null]
**PhaseDescription** | **String** |  | [optional] [readonly] [default to null]
**Metadata** | [**ReportMetadata[]**](ReportMetadata.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSiteList  -Id null `
 -Description null `
 -Title null `
 -Url null `
 -Department null `
 -PolicyName null `
 -PolicyId null `
 -Template null `
 -Owner null `
 -OwnerDisplayName null `
 -PrimaryContact null `
 -PrimaryContactDisplayName null `
 -SecondaryContact null `
 -SecondaryContactDisplayName null `
 -AdditionalAdministrators null `
 -AdditionalAdministratorDisplayNames null `
 -CreatedTime null `
 -Status null `
 -StatusDescription null `
 -ClaimStatus null `
 -ClaimStatusDescription null `
 -Sharing null `
 -SharingDescription null `
 -StorageQuota null `
 -StorageUsed null `
 -InactivityThresholdTime null `
 -LeaseExpirationTime null `
 -PermissionRecertificationStatus null `
 -PermissionRecertificationStatusDescription null `
 -MetadataRecertificationStatus null `
 -MetadataRecertificationStatusDescription null `
 -OwnershipRecertificationStatus null `
 -OwnershipRecertificationStatusDescription null `
 -GeoLocation null `
 -GeoLocationDescription null `
 -Hub null `
 -Phase null `
 -PhaseDescription null `
 -Metadata null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

