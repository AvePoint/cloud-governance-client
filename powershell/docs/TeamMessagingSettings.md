# TeamMessagingSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowUserEditMessages** | **Boolean** |  | [optional] [default to $false]
**AllowUserDeleteMessages** | **Boolean** |  | [optional] [default to $false]
**AllowOwnerDeleteMessages** | **Boolean** |  | [optional] [default to $false]
**AllowTeamMentions** | **Boolean** |  | [optional] [default to $false]
**AllowChannelMentions** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$TeamMessagingSettings = New-Cloud.Governance.ClientTeamMessagingSettings  -AllowUserEditMessages null `
 -AllowUserDeleteMessages null `
 -AllowOwnerDeleteMessages null `
 -AllowTeamMentions null `
 -AllowChannelMentions null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$TeamMessagingSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

