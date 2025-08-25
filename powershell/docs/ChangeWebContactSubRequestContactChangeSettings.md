# ChangeWebContactSubRequestContactChangeSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**WebId** | **String** |  | [optional] 
**WebUrl** | **String** |  | [optional] 
**WebTitle** | **String** | Web title | [optional] 
**PrimaryContact** | [**ChangeWebContactByUrlSettingPrimaryContact**](ChangeWebContactByUrlSettingPrimaryContact.md) |  | [optional] 
**SecondaryContact** | [**ChangeWebContactByUrlSettingPrimaryContact**](ChangeWebContactByUrlSettingPrimaryContact.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeWebContactSubRequestContactChangeSettings = New-Cloud.Governance.ClientChangeWebContactSubRequestContactChangeSettings  -SiteId null `
 -SiteUrl null `
 -WebId null `
 -WebUrl null `
 -WebTitle null `
 -PrimaryContact null `
 -SecondaryContact null
```

- Convert the resource to JSON
```powershell
$ChangeWebContactSubRequestContactChangeSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

