# TeamMentionsResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowTeamMentions** | **Boolean** |  | [optional] [default to $false]
**AllowChannelMentions** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$TeamMentionsResult = New-Cloud.Governance.ClientTeamMentionsResult  -AllowTeamMentions null `
 -AllowChannelMentions null
```

- Convert the resource to JSON
```powershell
$TeamMentionsResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

