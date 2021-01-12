# GroupMembershipItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoginName** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**Action** | [**GroupMembershipAction**](GroupMembershipAction.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GroupMembershipItem = New-Cloud.Governance.ClientGroupMembershipItem  -LoginName null `
 -DisplayName null `
 -Action null
```

- Convert the resource to JSON
```powershell
$GroupMembershipItem | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

