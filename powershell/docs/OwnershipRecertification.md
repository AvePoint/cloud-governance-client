# OwnershipRecertification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SiteUrl** | **String** |  | [optional] [default to null]
**SiteTitle** | **String** |  | [optional] [default to null]
**SiteDescription** | **String** |  | [optional] [default to null]
**Policy** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**GeneratedTime** | **System.DateTime** |  | [optional] [default to null]
**PrimaryAdministrator** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**Template** | **String** |  | [optional] [default to null]
**Status** | [**TaskResult**](TaskResult.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientOwnershipRecertification  -TaskId null `
 -SiteId null `
 -SiteUrl null `
 -SiteTitle null `
 -SiteDescription null `
 -Policy null `
 -GeneratedTime null `
 -PrimaryAdministrator null `
 -PrimaryContact null `
 -SecondaryContact null `
 -Template null `
 -Status null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

