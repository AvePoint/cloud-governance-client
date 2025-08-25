# ChangeWebSettingRequestUrl
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteUrl** | **String** |  | [optional] 
**WebUrl** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 
**WebId** | **String** |  | [optional] 
**WebTitle** | **String** | Web Title | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeWebSettingRequestUrl = New-Cloud.Governance.ClientChangeWebSettingRequestUrl  -SiteUrl null `
 -WebUrl null `
 -SiteId null `
 -WebId null `
 -WebTitle null
```

- Convert the resource to JSON
```powershell
$ChangeWebSettingRequestUrl | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

