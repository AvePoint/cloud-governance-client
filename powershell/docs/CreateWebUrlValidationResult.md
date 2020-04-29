# CreateWebUrlValidationResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentWebUrl** | **String** |  | [optional] [default to null]
**ParentSiteUrl** | **String** |  | [optional] [default to null]
**SitePrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**SiteSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**IsValid** | **Boolean** |  | [optional] [readonly] [default to null]
**ErrorMessage** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientCreateWebUrlValidationResult  -ParentWebUrl null `
 -ParentSiteUrl null `
 -SitePrimaryContact null `
 -SiteSecondaryContact null `
 -IsValid null `
 -ErrorMessage null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

