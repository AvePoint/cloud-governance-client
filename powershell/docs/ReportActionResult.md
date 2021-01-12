# ReportActionResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **String** |  | [optional] 
**UrlOrEmail** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ReportActionResult = New-Cloud.Governance.ClientReportActionResult  -Reason null `
 -UrlOrEmail null `
 -Title null
```

- Convert the resource to JSON
```powershell
$ReportActionResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

