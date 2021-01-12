# TaskComment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssigneeDisplayName** | **String** |  | [optional] 
**CommentTime** | **System.DateTime** |  | [optional] 
**Content** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TaskComment = New-Cloud.Governance.ClientTaskComment  -AssigneeDisplayName null `
 -CommentTime null `
 -Content null
```

- Convert the resource to JSON
```powershell
$TaskComment | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

