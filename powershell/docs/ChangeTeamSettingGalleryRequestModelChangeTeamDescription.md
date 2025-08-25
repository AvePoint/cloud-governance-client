# ChangeTeamSettingGalleryRequestModelChangeTeamDescription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeamDescription** | **String** |  | [optional] 
**OriginalTeamDescription** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeTeamSettingGalleryRequestModelChangeTeamDescription = New-Cloud.Governance.ClientChangeTeamSettingGalleryRequestModelChangeTeamDescription  -TeamDescription null `
 -OriginalTeamDescription null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeTeamSettingGalleryRequestModelChangeTeamDescription | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

