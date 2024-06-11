# MailboxAutoMapping
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableAutoMapping** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$MailboxAutoMapping = New-Cloud.Governance.ClientMailboxAutoMapping  -EnableAutoMapping null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$MailboxAutoMapping | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

