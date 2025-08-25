# CreateTeamGalleryMentionSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowTeamMentions** | **Boolean** |  | [optional] [default to $false]
**AllowChannelMentions** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateTeamGalleryMentionSetting = New-Cloud.Governance.ClientCreateTeamGalleryMentionSetting  -AllowTeamMentions null `
 -AllowChannelMentions null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateTeamGalleryMentionSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

