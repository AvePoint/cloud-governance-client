# AppSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableInstallApp** | **Boolean** |  | [optional] [default to null]
**EnableAddSiteInfoCard** | **Boolean** |  | [optional] [default to null]
**EnableAddTimeLine** | **Boolean** |  | [optional] [default to null]
**EnableAddPanel** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientAppSettings  -EnableInstallApp null `
 -EnableAddSiteInfoCard null `
 -EnableAddTimeLine null `
 -EnableAddPanel null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

