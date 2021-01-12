# ChangeListSettingObjectInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteUrl** | **String** |  | [optional] 
**WebId** | **String** |  | [optional] 
**WebUrl** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 
**ObjectUrl** | **String** |  | [optional] 
**ObjectTitle** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeListSettingObjectInfo = New-Cloud.Governance.ClientChangeListSettingObjectInfo  -SiteUrl null `
 -WebId null `
 -WebUrl null `
 -SiteId null `
 -ObjectUrl null `
 -ObjectTitle null
```

- Convert the resource to JSON
```powershell
$ChangeListSettingObjectInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

