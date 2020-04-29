# WebLifecycleValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**WebUrl** | **String** |  | [optional] [default to null]
**WebRelativeUrl** | **String** |  | [optional] [default to null]
**SiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SiteUrl** | **String** |  | [optional] [default to null]
**IsValid** | **Boolean** |  | [optional] [readonly] [default to null]
**ErrorMessage** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientWebLifecycleValidateResult  -WebId null `
 -WebUrl null `
 -WebRelativeUrl null `
 -SiteId null `
 -SiteUrl null `
 -IsValid null `
 -ErrorMessage null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

