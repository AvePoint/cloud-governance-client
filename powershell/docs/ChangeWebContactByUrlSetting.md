# ChangeWebContactByUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**WebId** | **String** |  | [optional] 
**WebUrl** | **String** |  | [optional] 
**PrimaryContact** | [**ApiUserChangedProperty**](ApiUserChangedProperty.md) |  | [optional] 
**SecondaryContact** | [**ApiUserChangedProperty**](ApiUserChangedProperty.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeWebContactByUrlSetting = New-Cloud.Governance.ClientChangeWebContactByUrlSetting  -SiteId null `
 -SiteUrl null `
 -WebId null `
 -WebUrl null `
 -PrimaryContact null `
 -SecondaryContact null
```

- Convert the resource to JSON
```powershell
$ChangeWebContactByUrlSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

