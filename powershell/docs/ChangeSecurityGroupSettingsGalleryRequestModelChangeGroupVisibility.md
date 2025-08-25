# ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupVisibility
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPublic** | **Boolean** |  | [optional] [default to $false]
**OriginalIsPublic** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupVisibility = New-Cloud.Governance.ClientChangeSecurityGroupSettingsGalleryRequestModelChangeGroupVisibility  -IsPublic null `
 -OriginalIsPublic null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupVisibility | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

