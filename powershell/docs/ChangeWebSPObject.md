# ChangeWebSPObject
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
$ChangeWebSPObject = New-Cloud.Governance.ClientChangeWebSPObject  -SiteUrl null `
 -WebUrl null `
 -SiteId null `
 -WebId null `
 -WebTitle null
```

- Convert the resource to JSON
```powershell
$ChangeWebSPObject | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

