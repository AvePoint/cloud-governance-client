# GroupLinks
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupSiteLink** | **String** |  | [optional] 
**GroupPlannerLink** | **String** |  | [optional] 
**GroupFilesLink** | **String** |  | [optional] 
**GroupConversationsLink** | **String** |  | [optional] 
**GroupNotebookLink** | **String** |  | [optional] 
**YammerGroupLink** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GroupLinks = New-Cloud.Governance.ClientGroupLinks  -GroupSiteLink null `
 -GroupPlannerLink null `
 -GroupFilesLink null `
 -GroupConversationsLink null `
 -GroupNotebookLink null `
 -YammerGroupLink null
```

- Convert the resource to JSON
```powershell
$GroupLinks | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

