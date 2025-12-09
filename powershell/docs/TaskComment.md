# TaskComment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssigneeDisplayName** | **String** |  | [optional] 
**CommentTime** | **System.DateTime** |  | [optional] 
**Content** | **String** |  | [optional] 
**TaskResult** | [**TaskResult**](TaskResult.md) |  | [optional] 
**OldVersion** | **Int32** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$TaskComment = New-Cloud.Governance.ClientTaskComment  -AssigneeDisplayName null `
 -CommentTime null `
 -Content null `
 -TaskResult null `
 -OldVersion null
```

- Convert the resource to JSON
```powershell
$TaskComment | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

