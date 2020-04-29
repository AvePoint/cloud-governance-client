# GroupMembershipItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoginName** | **String** |  | [optional] [default to null]
**DisplayName** | **String** |  | [optional] [default to null]
**Action** | [**GroupMembershipAction**](GroupMembershipAction.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGroupMembershipItem  -LoginName null `
 -DisplayName null `
 -Action null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

