# SpecifyContactModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**PrimaryEmailTemplate** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SecondaryEmailTemplate** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SelectedSiteIds** | **String[]** |  | [optional] [default to null]
**IsFromTask** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSpecifyContactModel  -PrimaryContact null `
 -SecondaryContact null `
 -PrimaryEmailTemplate null `
 -SecondaryEmailTemplate null `
 -SelectedSiteIds null `
 -IsFromTask null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

