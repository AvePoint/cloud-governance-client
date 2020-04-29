# SiteReport
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**Url** | **String** |  | [optional] [default to null]
**Department** | **String** |  | [optional] [default to null]
**PolicyName** | **String** |  | [optional] [default to null]
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
**Status** | **String** |  | [optional] [readonly] [default to null]
**ClaimStatus** | **String** |  | [optional] [readonly] [default to null]
**Sharing** | **String** |  | [optional] [readonly] [default to null]
**StorageQuota** | **Int64** |  | [optional] [default to null]
**StorageUsed** | **Int64** |  | [optional] [default to null]
**InactivityThresholdTime** | **System.DateTime** |  | [optional] [default to null]
**LeaseExpirationTime** | **System.DateTime** |  | [optional] [default to null]
**PermissionRecertificationStatus** | **String** |  | [optional] [readonly] [default to null]
**MetadataRecertificationStatus** | **String** |  | [optional] [readonly] [default to null]
**OwnershipRecertificationStatus** | **String** |  | [optional] [readonly] [default to null]
**GeoLocation** | **String** |  | [optional] [readonly] [default to null]
**Hub** | **String** |  | [optional] [default to null]
**Phase** | **String** |  | [optional] [readonly] [default to null]
**AllMetadata** | **Hashtable** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSiteReport  -Id null `
 -Description null `
 -Title null `
 -Url null `
 -Department null `
 -PolicyName null `
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
 -ClaimStatus null `
 -Sharing null `
 -StorageQuota null `
 -StorageUsed null `
 -InactivityThresholdTime null `
 -LeaseExpirationTime null `
 -PermissionRecertificationStatus null `
 -MetadataRecertificationStatus null `
 -OwnershipRecertificationStatus null `
 -GeoLocation null `
 -Hub null `
 -Phase null `
 -AllMetadata null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

