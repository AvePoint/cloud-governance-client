# LinkValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **String** | Title of link metadata | [optional] 
**Address** | **String** | Address of link metadata | [optional] 

## Examples

- Prepare the resource
```powershell
$LinkValue = New-Cloud.Governance.ClientLinkValue  -Title null `
 -Address null
```

- Convert the resource to JSON
```powershell
$LinkValue | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

