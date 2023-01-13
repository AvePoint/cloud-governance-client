# GroupLinks
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupSiteLink** | **String** | Group team site link | [optional] 
**GroupPlannerLink** | **String** | Planner link | [optional] 
**GroupFilesLink** | **String** | Files link | [optional] 
**GroupConversationsLink** | **String** | Conversations link | [optional] 
**GroupNotebookLink** | **String** | Notebook link | [optional] 
**YammerGroupLink** | **String** | Yammer community link | [optional] 
**TeamLink** | **String** | Team link | [optional] 

## Examples

- Prepare the resource
```powershell
$GroupLinks = New-Cloud.Governance.ClientGroupLinks  -GroupSiteLink null `
 -GroupPlannerLink null `
 -GroupFilesLink null `
 -GroupConversationsLink null `
 -GroupNotebookLink null `
 -YammerGroupLink null `
 -TeamLink null
```

- Convert the resource to JSON
```powershell
$GroupLinks | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

