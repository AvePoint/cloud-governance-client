# CreateWebServiceAppSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableInstallApp** | **Boolean** |  | [optional] [default to $false]
**EnableAddSiteInfoCard** | **Boolean** |  | [optional] [default to $false]
**EnableAddTimeLine** | **Boolean** |  | [optional] [default to $false]
**EnableAddPanel** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$CreateWebServiceAppSettings = New-Cloud.Governance.ClientCreateWebServiceAppSettings  -EnableInstallApp null `
 -EnableAddSiteInfoCard null `
 -EnableAddTimeLine null `
 -EnableAddPanel null
```

- Convert the resource to JSON
```powershell
$CreateWebServiceAppSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

