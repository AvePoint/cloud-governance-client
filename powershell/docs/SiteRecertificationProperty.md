# SiteRecertificationProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PermissionRecertificationStatus** | [**RecertificationStatus**](RecertificationStatus.md) |  | [optional] [default to null]
**PermissionRecertificationStatusDesc** | **String** |  | [optional] [readonly] [default to null]
**OwnershipRecertificationStatus** | [**RecertificationStatus**](RecertificationStatus.md) |  | [optional] [default to null]
**OwnershipRecertificationStatusDesc** | **String** |  | [optional] [readonly] [default to null]
**MetadataRecertificationStatus** | [**RecertificationStatus**](RecertificationStatus.md) |  | [optional] [default to null]
**MetadataRecertificationStatusDesc** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSiteRecertificationProperty  -PermissionRecertificationStatus null `
 -PermissionRecertificationStatusDesc null `
 -OwnershipRecertificationStatus null `
 -OwnershipRecertificationStatusDesc null `
 -MetadataRecertificationStatus null `
 -MetadataRecertificationStatusDesc null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

